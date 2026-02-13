/*
 * motor.h
 *
 *  Created on: Aug 13, 2025
 *      Author: Kwief
 */

#ifndef MOTOR_H_
#define MOTOR_H_

typedef struct{
	GPIO_TypeDef *dir_port;
	uint16_t dir_pin;
	TIM_TypeDef *tim;
	uint16_t steps_move;
	uint16_t clk_pin;
	GPIO_TypeDef *clk_port;
}StepMotorAxis;

extern volatile bool dir_z;
extern volatile bool dir_x;


void step_dir(StepMotorAxis *axis, uint8_t dir);
void stepmotor_axis(StepMotorAxis *axis,GPIO_TypeDef *port,GPIO_TypeDef *clk_port,uint16_t pin,TIM_TypeDef *tim,uint16_t tim_pin);
void stepmotor_stop(StepMotorAxis *axis);
void stepmotor_start(StepMotorAxis *axis);
void stepmotor_run(StepMotorAxis *axis,uint16_t steps, uint8_t dir);
void stepmotor_move_z(StepMotorAxis *axis,uint16_t pixel,uint8_t dir);
void stepmotor_dir(StepMotorAxis *axis, uint8_t dir);
void stepmotor_dir_z(StepMotorAxis *axis, uint8_t dir);
void stepmotor_move_x(StepMotorAxis *axis,uint16_t pixel,uint8_t dir);


typedef enum{
	DOWN_FIFO,
	DRILL_Z,
	BACKDRILL_Z,
	STEP_X,
	MOVE_Y,
	MOVEBACK_X


}MachineState_StepMotor;

typedef enum{
	POP_FIFO,
	MOVE_Z,
	BACK_Z,
	MOVE_X,
	MOVE_BACK_X,
	MOVEBACK_Y
}SecondControl;


typedef enum{

	FIFO,
	DRILLOWANIE,
	POWROT

}wiercenie;

#endif /* MOTOR_H_ */
