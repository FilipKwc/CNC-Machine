/*
 * clkdir.c
 *
 *  Created on: Apr 22, 2025
 *      Author: Kwief
 */

#include "main.h"

#define DIRx_ON GPIOB -> BSRR |= GPIO_BSRR_BS_3;
#define DIRx_OFF GPIOB -> BSRR |= GPIO_BSRR_BR_3;

#define DIRy_ON GPIOB -> BSRR |= GPIO_BSRR_BS_4;
#define DIRy_OFF GPIOB -> BSRR |= GPIO_BSRR_BR_4;

#define DIRz_ON GPIOB -> BSRR |= GPIO_BSRR_BS_5;
#define DIRz_OFF GPIOB -> BSRR |= GPIO_BSRR_BR_5;


void DIRconfig_x(void)
{
		//PB3:D3
		GPIOB -> MODER |= GPIO_MODER_MODER3_0;
		GPIOB -> MODER &= ~(GPIO_MODER_MODER3_1);
		GPIOB -> OTYPER &= ~(GPIO_OTYPER_OT_3);
		GPIOB -> OSPEEDR &= ~(GPIO_OSPEEDER_OSPEEDR3);
		GPIOB -> PUPDR &= ~(GPIO_PUPDR_PUPDR3);

}
void DIRconfig_y(void)
{
	//PB4:D5
		GPIOB -> MODER |= GPIO_MODER_MODER4_0;
		GPIOB -> MODER &= ~(GPIO_MODER_MODER4_1);
		GPIOB -> OTYPER &= ~(GPIO_OTYPER_OT_4);
		GPIOB -> OSPEEDR &= ~(GPIO_OSPEEDER_OSPEEDR4);
		GPIOB -> PUPDR &= ~(GPIO_PUPDR_PUPDR4);

}
void DIRconfig_z(void)
{
	//PB5:D4
		GPIOB -> MODER |= GPIO_MODER_MODER5_0;
		GPIOB -> MODER &= ~(GPIO_MODER_MODER5_1);
		GPIOB -> OTYPER &= ~(GPIO_OTYPER_OT_5);
		GPIOB -> OSPEEDR &= ~(GPIO_OSPEEDER_OSPEEDR5);
		GPIOB -> PUPDR &= ~(GPIO_PUPDR_PUPDR5);
}

void CHIPEconfig_x(void)
{
	//PA8:D7
	GPIOA -> MODER |= GPIO_MODER_MODER8_0;
	GPIOA -> MODER &= ~(GPIO_MODER_MODER8_1);
	GPIOA -> OTYPER &= ~(GPIO_OTYPER_OT_8);
	GPIOA -> OSPEEDR &= ~(GPIO_OSPEEDER_OSPEEDR8);
	GPIOA -> PUPDR &= ~(GPIO_PUPDR_PUPDR8);
}


void CHIPEconfig_y(void)
{
	//PA9:D8
	GPIOA -> MODER |= GPIO_MODER_MODER9_0;
	GPIOA -> MODER &= ~(GPIO_MODER_MODER9_1);
	GPIOA -> OTYPER &= ~(GPIO_OTYPER_OT_9);
	GPIOA -> OSPEEDR &= ~(GPIO_OSPEEDER_OSPEEDR9);
	GPIOA -> PUPDR &= ~(GPIO_PUPDR_PUPDR9);
}

void CHIPEconfig_z(void)
{
	//PC7:D9
	GPIOC -> MODER |= GPIO_MODER_MODER7_0;
	GPIOC -> MODER &= ~(GPIO_MODER_MODER7_1);
	GPIOC -> OTYPER &= ~(GPIO_OTYPER_OT_7);
	GPIOC -> OSPEEDR &= ~(GPIO_OSPEEDER_OSPEEDR7);
	GPIOC -> PUPDR &= ~(GPIO_PUPDR_PUPDR7);
}



void ChipEnable(uint16_t chip_pin,uint16_t chip, GPIO_TypeDef *chip_port)
{
	if(chip) {
		chip_port->BSRR = (1 << chip_pin);

	} else
	{
		chip_port->BSRR = (1 << (chip_pin + 16 ));
	}
}


