#include <stdio.h>

#include <stdlib.h>
#include <esp_system.h>
#include <esp_log.h>

//#define LED 13
//#define PB 

#define OFF 0       //ESTADO APAGADO
#define MEDIUM 1    //ESTADO PARPADEO 0.5s
#define FAST 2      //ESTADO PARPADEO 0.1s
#define SLOW 3      //ESTADO PARPADEO 1s
#define VARIABLE 4  //ESTADO PARPADEO VARIABLE

struct IO_DATA
{
    bool pb;
    bool led;
} io_data;


uint8_t prev_state = OFF;
uint8_t curr_state = OFF;
//uint8_t next_state = 0;

/*-------- FSM FUNCTIONS --------*/

int offFunc(void) {
    prev_state = curr_state;
    curr_state = OFF;

    while (1) {
        if (io_data.pb == true) {
            io_data.pb = false;
            return MEDIUM;
        }
    }
}

int mediumFunc(void) {
    prev_state = curr_state;
    curr_state = MEDIUM;

    while (1) {
        if (io_data.pb == true) {
            io_data.pb = false;
            return FAST;
        }
    }
}

int fastFunc(void) {
    prev_state = curr_state;
    curr_state = FAST;

    while (1) {
        if (io_data.pb == true) {
            io_data.pb = false;
            return SLOW;
        }
    }
}

int slowFunc(void) {
    prev_state = curr_state;
    curr_state = SLOW;

    while (1) {
        if (io_data.pb == true) {
            io_data.pb = false;
            return VARIABLE;
        }
    }
}

int varFunc(void) {
    prev_state = curr_state;
    curr_state = VARIABLE;

    while (1) {
        if (io_data.pb == true) {
            io_data.pb = false;
            return OFF;
        }
    }
}

void app_main(void)
{

}