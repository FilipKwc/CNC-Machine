/*
 * fifo.h
 *
 *  Created on: Aug 2, 2025
 *      Author: Kwief
 */

#ifndef FIFO_H_
#define FIFO_H_
#define FIFO_SIZE 27
#include "stdbool.h"
typedef struct {
 volatile  uint8_t buffer[FIFO_SIZE];
volatile    uint8_t head;
volatile   uint8_t tail;
volatile  uint16_t count;
volatile  uint16_t count_push; // start
 volatile  uint16_t count_pop; //koniec
} fifo_t;

int fifo_pop(fifo_t *f, uint8_t *value);
int fifo_push(fifo_t *f, uint8_t value);
void config_UART(void);
void send_ack(void);

#endif /* FIFO_H_ */
