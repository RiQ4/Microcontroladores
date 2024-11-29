#include <stdio.h>
#include <stdlib.h>

#define INIT 0
#define CLOSED 1
#define OPEN 2
#define CLOSING 3
#define OPENING 4
#define ERR 5

#define TRUE 1
#define FALSE 0

#define RT_MAX 180
#define OP_TIME 60

int prev_state = INIT;
int curr_state = INIT;
int next_state = INIT;

struct DATA
{
    unsigned int LSC:1;     //LS Cerrado
    unsigned int LSO:1;     //LS Abierto
    unsigned int SPP:1;     //Pulsador
    unsigned int MO:1;      //Motor para abrir
    unsigned int MC:1;      //Motor para cerrar
    unsigned int RT_CNT;    //Runtime Timer
    unsigned int TIM;       //Timer
    unsigned int ledG:1;    //LED Verde
    unsigned int ledR:1;    //LED Rojo
    unsigned int ledO:1;    //LED Naranja

} data;



int main () {
    print("Hello World!\n");

    //LED Check
    data.ledG = TRUE;
    data.ledR = TRUE;
    data.ledO = TRUE;
    //delay
    data.ledG = FALSE;
    data.ledR = FALSE;
    data.ledO = FALSE;

    while(1) {

        if (next_state == INIT) {
            next_state = initFunc();
        }
        if (next_state == CLOSED) {
            next_state = closedFunc();
        }
        if (next_state == OPEN) {
            next_state = openFunc();
        }
        if (next_state == CLOSING) {
            next_state = closingFunc();
        }
        if (next_state == OPENING) {
            next_state = openingFunc();
        }
        if (next_state == ERR) {
            next_state = errFunc();
        }
    }
}

//-----------------------------Functions----------------------------
int initFunc (void) {
    prev_state == INIT;
    curr_state == INIT;

    data.MC = 0;
    data.MO = 0;
    data.RT_CNT = 0;
    data.SPP = 0;
    data.LSC = 0;
    data.LSO = 0;

    while (1)
    {    
        if (data.LSC == TRUE && data.LSO == FALSE) {
            return CLOSED;
        }

        if ((data.LSC == FALSE && data.LSO == FALSE) || (data.LSC == FALSE && data.LSO == TRUE)) {
            return CLOSING;
        }

        if (data.LSC && data.LSO) {
            return ERR;
        }
    }
}

int closedFunc (void) {
    prev_state= curr_state;
    curr_state == CLOSED;

    data.MC = FALSE;
    data.SPP == FALSE;

    while (1)
    {
        if (data.SPP == TRUE)
        {
            data.SPP == FALSE;
            return OPENING;
        }
    }    
}

int openFunc (void) {
    
    prev_state = curr_state;
    curr_state = OPEN;

    data.MO = FALSE;
    data.SPP == FALSE;

    while (1)
    {
        if (data.SPP == TRUE || data.TIM >= OP_TIME)
        {
            data.SPP == FALSE;
            return CLOSING;
        }
    }
}

int closingFunc (void) {
    prev_state= curr_state;
    curr_state == CLOSING;

    data.MC = TRUE;
    data.RT_CNT = 0;

    while (1) {
        if (data.LSC == TRUE && data.LSO == FALSE) {
            return CLOSED;
        }
        if (data.RT_CNT > RT_MAX) {
            return ERR;
        }
    }
}

int openingFunc (void) {
    prev_state = curr_state;
    curr_state = OPENING;

    data.MO = TRUE;
    data.RT_CNT = 0;
    
    while (1) {
        if (data.LSO == TRUE && data.LSC == FALSE) {
            return OPEN;
        }
        if (data.RT_CNT > RT_MAX) {
            return ERR;
        }
    }
}

int errFunc (void) {
    if (data.RT_CNT >= RT_MAX) {
        //error rt excedido
        print("error\n");
    }     
}
