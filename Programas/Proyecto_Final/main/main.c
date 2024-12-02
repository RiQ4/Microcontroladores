#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdint.h>
#include <stddef.h>

#include <esp_netif.h>
#include <esp_system.h>
#include <esp_log.h>
#include <esp_event.h>
#include <nvs_flash.h>
#include <esp_wifi.h>
#include <mqtt_client.h>

#include <freertos/FreeRTOS.h>
#include <freertos/task.h>
#include <freertos/event_groups.h>

#include "lwip/err.h" //light weight ip packets error handling
#include "lwip/sys.h" //system applications for light weight ip apps

// #define LED 13
// #define PB

#define OFF 0      // ESTADO APAGADO
#define MEDIUM 1   // ESTADO PARPADEO 0.5s
#define FAST 2     // ESTADO PARPADEO 0.1s
#define SLOW 3     // ESTADO PARPADEO 1s
#define VARIABLE 4 // ESTADO PARPADEO VARIABLE

#define SSID "CLAROA084"
#define PASS "20212617"
#define MAX_RETRY 50    //REINTENTOS MAX.
static EventGroupHandle_t s_wifi_event_group;
#define WIFI_CONNECTED_BIT BIT0
#define WIFI_FAIL_BIT      BIT1

static const char *TAG = "Proyecto Final";
static const char *topic = "micro/esp32s3/pf";

static int retry_num = 0;  //REINTENTOS WIFI
bool wifi_connected = false; // ESTADO WIFI
bool mqtt_connected = false; // ESTADO MQTT

struct IO_DATA
{
    bool pb;
    bool led;

} io_data;

uint8_t prev_state = OFF;
uint8_t curr_state = OFF;
// uint8_t next_state = 0;

/*-------- FSM FUNCTIONS --------*/

int offFunc(void)
{
    prev_state = curr_state;
    curr_state = OFF;

    while (1)
    {
        if (io_data.pb == true)
        {
            io_data.pb = false;
            return MEDIUM;
        }
    }
}

int mediumFunc(void)
{
    prev_state = curr_state;
    curr_state = MEDIUM;

    while (1)
    {
        if (io_data.pb == true)
        {
            io_data.pb = false;
            return FAST;
        }
    }
}

int fastFunc(void)
{
    prev_state = curr_state;
    curr_state = FAST;

    while (1)
    {
        if (io_data.pb == true)
        {
            io_data.pb = false;
            return SLOW;
        }
    }
}

int slowFunc(void)
{
    prev_state = curr_state;
    curr_state = SLOW;

    while (1)
    {
        if (io_data.pb == true)
        {
            io_data.pb = false;
            return VARIABLE;
        }
    }
}

int varFunc(void)
{
    prev_state = curr_state;
    curr_state = VARIABLE;

    while (1)
    {
        if (io_data.pb == true)
        {
            io_data.pb = false;
            return OFF;
        }
    }
}

/*-------- MQTT EVENT HANDLER --------*/
static void mqtt5_event_handler(void *handler_args, esp_event_base_t base, int32_t event_id, void *event_data)
{
    ESP_LOGD(TAG, "Event dispatched from event loop base=%s, event_id=%" PRIi32, base, event_id);
    esp_mqtt_event_handle_t event = event_data;
    esp_mqtt_client_handle_t client = event->client;
    int msg_id = 0;

    ESP_LOGD(TAG, "free heap size is %" PRIu32 ", minimum %" PRIu32, esp_get_free_heap_size(), esp_get_minimum_free_heap_size());

    switch ((esp_mqtt_event_id_t)event_id)
    {
    case MQTT_EVENT_CONNECTED:
        ESP_LOGI(TAG, "MQTT_EVENT_CONNECTED");
        mqtt_connected = true;
        // Subscripcion
        //msg_id = esp_mqtt_client_subscribe(client, topic, 1);

        break;
    case MQTT_EVENT_DISCONNECTED:
        ESP_LOGI(TAG, "MQTT_EVENT_DISCONNECTED");
        mqtt_connected = false;
        break;
    case MQTT_EVENT_SUBSCRIBED:
        ESP_LOGI(TAG, "MQTT_EVENT_SUBSCRIBED, msg_id=%d", event->msg_id);
        ESP_LOGI(TAG, "sent publish successful, msg_id=%d", msg_id);
        //msg_id = esp_mqtt_client_publish(client, topic, "entro eri", sizeof("entro eri"), 1, 1);
        break;
    case MQTT_EVENT_UNSUBSCRIBED:
        ESP_LOGI(TAG, "MQTT_EVENT_UNSUBSCRIBED, msg_id=%d", event->msg_id);

        break;
    case MQTT_EVENT_PUBLISHED:
        ESP_LOGI(TAG, "MQTT_EVENT_PUBLISHED, msg_id=%d", event->msg_id);
        ESP_LOGI(TAG, "Published @ micro.");
        break;
    case MQTT_EVENT_DATA:
        ESP_LOGI(TAG, "MQTT_EVENT_DATA");

        break;
    case MQTT_EVENT_ERROR:
        ESP_LOGI(TAG, "MQTT_EVENT_ERROR");
        ESP_LOGI(TAG, "MQTT5 return code is %d", event->error_handle->connect_return_code);
        if (event->error_handle->error_type == MQTT_ERROR_TYPE_TCP_TRANSPORT)
        {
            //log_error_if_nonzero("reported from esp-tls", event->error_handle->esp_tls_last_esp_err);
            //log_error_if_nonzero("reported from tls stack", event->error_handle->esp_tls_stack_err);
            //log_error_if_nonzero("captured as transport's socket errno", event->error_handle->esp_transport_sock_errno);
            ESP_LOGI(TAG, "Last errno string (%s)", strerror(event->error_handle->esp_transport_sock_errno));
        }
        break;
    default:
        ESP_LOGI(TAG, "Other event id:%d", event->event_id);
        break;
    }
}

/*-------- WIFI EVENT HANDLER --------*/
static void wifi_event_handler(void *event_handler_arg, esp_event_base_t event_base, int32_t event_id, void *event_data)
{
    if (event_base == WIFI_EVENT && event_id == WIFI_EVENT_STA_START) {
        esp_wifi_connect();
    } else if (event_base == WIFI_EVENT && event_id == WIFI_EVENT_STA_DISCONNECTED) {
        if (retry_num < MAX_RETRY) {
            esp_wifi_connect();
            retry_num++;
            ESP_LOGI(TAG, "retry to connect to the AP");
        } else {
            xEventGroupSetBits(s_wifi_event_group, WIFI_FAIL_BIT);
        }
        ESP_LOGI(TAG,"connect to the AP fail");
    } else if (event_base == IP_EVENT && event_id == IP_EVENT_STA_GOT_IP) {
        ip_event_got_ip_t* event = (ip_event_got_ip_t*) event_data;
        ESP_LOGI(TAG, "got ip:" IPSTR, IP2STR(&event->ip_info.ip));
        retry_num = 0;
        xEventGroupSetBits(s_wifi_event_group, WIFI_CONNECTED_BIT);
    }
}

/*-------- WIFI INIT CONFIG --------*/
void wifi_init(void)
{
    s_wifi_event_group = xEventGroupCreate();           //Evento FreeRTOS para WiFi

    //ESP_ERROR_CHECK(esp_netif_init());                          //Inicializacion Network Interface
    //ESP_ERROR_CHECK(esp_event_loop_create_default());           //No se
    esp_netif_create_default_wifi_sta();                        //Config Network Interface para STATION

    wifi_init_config_t wifi_init = WIFI_INIT_CONFIG_DEFAULT();  // Config INIT por defecto
    ESP_ERROR_CHECK(esp_wifi_init(&wifi_init));                 //WiFi INIT

    esp_event_handler_instance_t instance_any_id;               //Handler de Evento Cualquiera
    esp_event_handler_instance_t instance_got_ip;               //Handler Evento de IP

    ESP_ERROR_CHECK(esp_event_handler_instance_register(WIFI_EVENT,
                                                        ESP_EVENT_ANY_ID,
                                                        &wifi_event_handler,
                                                        NULL,
                                                        &instance_any_id));     //Registro Evento wifi
    
    ESP_ERROR_CHECK(esp_event_handler_instance_register(IP_EVENT,
                                                        IP_EVENT_STA_GOT_IP,
                                                        &wifi_event_handler,
                                                        NULL,
                                                        &instance_got_ip));     //Registro Evento IP                                                  

    wifi_config_t wifi_config = {
        .sta = {
            .ssid = "",
            .password = ""}};
    strcpy((char *)wifi_config.sta.ssid, SSID);
    strcpy((char *)wifi_config.sta.password, PASS);

    ESP_ERROR_CHECK(esp_wifi_set_mode(WIFI_MODE_STA));                   // Seleccion STA
    ESP_ERROR_CHECK(esp_wifi_set_config(ESP_IF_WIFI_STA, &wifi_config)); // Config STA
    ESP_ERROR_CHECK(esp_wifi_start());                                   // Iniciar WIFI

    ESP_LOGI(TAG, "WIFI INICIADO");

    /* Esto lo saqué del ejemplo. Solo entendí que es para verificar si se logró la conexión */
    EventBits_t bits = xEventGroupWaitBits(s_wifi_event_group,
            WIFI_CONNECTED_BIT | WIFI_FAIL_BIT,
            pdFALSE,
            pdFALSE,
            portMAX_DELAY);


    if (bits & WIFI_CONNECTED_BIT) {
        ESP_LOGI(TAG, "connected to ap SSID:%s", SSID);
        wifi_connected = true;

    } else if (bits & WIFI_FAIL_BIT) {
        ESP_LOGI(TAG, "Failed to connect to SSID:%s", SSID);
    } else {
        ESP_LOGE(TAG, "UNEXPECTED EVENT");
    }
}

/*-------- MQTT CLIENT CONFIG --------*/

esp_mqtt_client_handle_t client = NULL;
static void mqtt5_app_start(void)
{
    ESP_LOGI(TAG, "STARTING MQTT");
    esp_mqtt_client_config_t mqttConfig = {
        .broker.address.uri = "mqtt://test.mosquitto.org:1883",
        .session.protocol_ver = MQTT_PROTOCOL_V_5,
        .network.disable_auto_reconnect = false,
        .credentials.username = "",
        .credentials.authentication.password = ""};

    client = esp_mqtt_client_init(&mqttConfig);
    esp_mqtt_client_register_event(client, ESP_EVENT_ANY_ID, mqtt5_event_handler, client);
    esp_mqtt_client_start(client);
}

void app_main(void)
{
    esp_err_t ret = nvs_flash_init();
    if (ret == ESP_ERR_NVS_NO_FREE_PAGES || ret == ESP_ERR_NVS_NEW_VERSION_FOUND)
    {
        ESP_ERROR_CHECK(nvs_flash_erase());
        ret = nvs_flash_init();
    }
    ESP_ERROR_CHECK(ret);

    ESP_ERROR_CHECK(esp_event_loop_create_default());
    ESP_ERROR_CHECK(esp_netif_init()); 

    wifi_init();

    while (mqtt_connected != true)
    {
        mqtt5_app_start();
        vTaskDelay(5000 / portTICK_PERIOD_MS); // Delay para darle chance
    }
}