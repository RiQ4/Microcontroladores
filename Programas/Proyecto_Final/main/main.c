#include <stdio.h>

#include <stdlib.h>
#include <esp_system.h>

#define LED 13

#define OFF 0       //ESTADO APAGADO
#define MEDIUM 1    //ESTADO PARPADEO 0.5s
#define FAST 2      //ESTADO PARPADEO 0.1s
#define SLOW 3      //ESTADO PARPADEO 1s
#define VARIABLE 4  //ESTADO PARPADEO VARIABLE

bool pb = false;

/*-------- FSM --------*/
void fsm(void) {

}

void app_main(void)
{

}