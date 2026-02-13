/*
 * clkdir.c
 *
 *  Created on: Apr 22, 2025
 *      Author: Kwief
 */

#include "main.h"
#include "fifo.h"


void send_ack(void)
{
	USART2->TDR = 'p';
	while (!(USART2->ISR & USART_ISR_TXE)) { }
	while (!(USART2->ISR & USART_ISR_TC)) { }

}

void config_UART(void)
{


	//PA2_TXAF7
	GPIOA -> MODER &= ~(GPIO_MODER_MODER2_0);
    GPIOA->MODER |= GPIO_MODER_MODER2_1;
    GPIOA->AFR[0] &= ~((0xF << GPIO_AFRL_AFRL2_Pos));
	GPIOA->AFR[0] |= (0x7 << GPIO_AFRL_AFRL2_Pos);

	//PA3_RXAF7
	GPIOA -> MODER &= ~(GPIO_MODER_MODER3_0);
	GPIOA->MODER |= GPIO_MODER_MODER3_1;
	GPIOA->AFR[0] &= ~((0xF << GPIO_AFRL_AFRL3_Pos));
	GPIOA->AFR[0] |= (0x7 << GPIO_AFRL_AFRL3_Pos);

	//GPIOA -> OTYPER |= GPIO_OTYPER_OT_3;
	//GPIOA->PUPDR |= GPIO_PUPDR_PUPDR3_0;
	RCC -> APB1ENR |= RCC_APB1ENR_USART2EN;

	//RCC -> CFGR |= RCC_CFGR_PPRE1_2;

	USART2->BRR = 18000000/9600;

	USART2-> CR1 |= USART_CR1_UE | USART_CR1_TE | USART_CR1_RE;
	USART2-> CR1 |=  USART_CR1_RXNEIE;

	NVIC_SetPriority(USART2_IRQn, 0);
	NVIC_EnableIRQ(USART2_IRQn);

}




int fifo_push(fifo_t *f, uint16_t value)
{
    uint16_t next = (f->head + 1) % FIFO_SIZE;



    f->buffer[f->head] = value;  // Zapisz pod aktualnym head
    f->head = next;               // Przesuń head

    return 1;
}

int fifo_pop(fifo_t *f, uint16_t *value)
{
    if (f->head == f->tail) {
        return 0; // Pusty
    }

    *value = f->buffer[f->tail];
    f->tail = (f->tail + 1) ;
    		//% FIFO_SIZE;
    return 1;
}



