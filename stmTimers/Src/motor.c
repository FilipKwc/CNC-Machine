/*
 * motor.c
 *
 *  Created on: Aug 13, 2025
 *      Author: Kwief
 */


#include "main.h"
#include "motor.h"
#include "timer.h"

volatile bool dir_z;
void stepmotor_axis(StepMotorAxis *axis,GPIO_TypeDef *port,GPIO_TypeDef *clk_port,uint16_t pin,TIM_TypeDef *tim,uint16_t tim_pin)
{
	axis->dir_port = port;
	axis->dir_pin = pin;
	axis->clk_port = clk_port;
	axis->tim = tim;
	axis->clk_pin = tim_pin;
	axis->steps_move = 0;
}

void stepmotor_dir(StepMotorAxis *axis, uint8_t dir)
{
	if(dir) {
		axis->dir_port->BSRR = (1 << axis->dir_pin);

	} else
	{
			axis->dir_port->BSRR = (1 << (axis->dir_pin + 16 ));
	}
}

void stepmotor_stop(StepMotorAxis *axis)
{

	axis->tim->CR1 &= ~TIM_CR1_CEN;
	//axis->tim->SR &= ~TIM_SR_CC1IF;
	//axis->tim->SR &= ~TIM_SR_UIF;
	//axis->tim->DIER=0;
	//axis->tim->SR=0;
	axis->tim->CNT=0;
	axis->steps_move=0;
	axis->clk_port->BSRR = (1<<(axis->clk_pin+16));

}
void stepmotor_start(StepMotorAxis *axis)
{
	axis->tim->CR1 |= TIM_CR1_CEN;
}

void stepmotor_run(StepMotorAxis *axis,uint16_t steps, uint8_t dir)
{
  //  stepmotor_stop(axis);
	stepmotor_dir(axis,dir);
	axis->steps_move=steps;
	axis->tim->CNT=0;
//	axis->tim->SR=0;
	stepmotor_start(axis);
}
void stepmotor_move_x(StepMotorAxis *axis,uint16_t steps,uint8_t dir)
{
	stepmotor_run(axis,steps,dir);
	if(dir)
				{
					dir_x=true;
				} else
				{
					dir_x=false;
				}
}

void stepmotor_move_z(StepMotorAxis *axis,uint16_t pixel,uint8_t dir)
{
	uint16_t steps = pixel * 5;
		if(steps < 55 )
		{

			return;
		} else
		{
				stepmotor_run(axis,steps,dir);
				if(dir)
				{
					dir_z=true;
				} else
				{
					dir_z=false;
				}
		}
}





