/*
 * clkdir.h
 *
 *  Created on: Apr 22, 2025
 *      Author: Kwief
 */

#ifndef CLKDIR_H_
#define CLKDIR_H_
#include <stdint.h>

#include <stm32f3xx.h>
void DIRconfig_x(void);
void DIRconfig_y(void);
void DIRconfig_z(void);


#define DIRx_ON GPIOB -> BSRR |= GPIO_BSRR_BS_3;
#define DIRx_OFF GPIOB -> BSRR &= ~GPIO_BSRR_BR_3;

#define DIRy_ON GPIOB -> BSRR |= GPIO_BSRR_BS_4;
#define DIRy_OFF GPIOB -> BSRR &=  ~GPIO_BSRR_BR_4;

#define DIRz_ON GPIOB -> BSRR |= GPIO_BSRR_BS_5;
#define DIRz_OFF GPIOB -> BSRR &= ~GPIO_BSRR_BR_5;
#define ChipE_z 7
#define ChipE_y 9
#define ChipE_x 8


void CHIPEconfig_x(void);
void CHIPEconfig_y(void);
void CHIPEconfig_z(void);
void ChipEnable(uint16_t chip_pin,uint16_t chip, GPIO_TypeDef *chip_port);

#endif /* CLKDIR_H_ */
