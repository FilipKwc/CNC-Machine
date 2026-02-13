/*
 * fifo.h
 *
 *  Created on: Aug 2, 2025
 *      Author: Kwief
 */

#ifndef FIFO_H_
#define FIFO_H_
#define FIFO_SIZE 2560
#include "stdbool.h"
typedef struct {
 volatile  uint16_t buffer[FIFO_SIZE];
volatile   uint16_t head;
volatile   uint16_t tail;
volatile  uint16_t count;
volatile  uint16_t count_push; // start
 volatile  uint16_t count_pop; //koniec
} fifo_t;

int fifo_pop(fifo_t *f, uint16_t *value);
int fifo_push(fifo_t *f, uint16_t value);
void config_UART(void);
void send_ack(void);

#endif /* FIFO_H_ */
