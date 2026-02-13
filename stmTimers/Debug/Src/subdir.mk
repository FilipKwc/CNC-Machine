################################################################################
# Automatically-generated file. Do not edit!
# Toolchain: GNU Tools for STM32 (13.3.rel1)
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
../Src/clkdir.c \
../Src/fifo.c \
../Src/main.c \
../Src/motor.c \
../Src/syscalls.c \
../Src/sysmem.c \
../Src/timers.c 

OBJS += \
./Src/clkdir.o \
./Src/fifo.o \
./Src/main.o \
./Src/motor.o \
./Src/syscalls.o \
./Src/sysmem.o \
./Src/timers.o 

C_DEPS += \
./Src/clkdir.d \
./Src/fifo.d \
./Src/main.d \
./Src/motor.d \
./Src/syscalls.d \
./Src/sysmem.d \
./Src/timers.d 


# Each subdirectory must supply rules for building sources it contributes
Src/%.o Src/%.su Src/%.cyclo: ../Src/%.c Src/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m4 -std=gnu11 -g3 -DDEBUG -DSTM32F303xE -DSTM32 -DSTM32F3 -DSTM32F303RETx -c -I../drivers/CMSIS/Include -I../drivers/CMSIS/Device/ST/STM32F3xx/Include -I../Inc -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -fcyclomatic-complexity -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" --specs=nano.specs -mfpu=fpv4-sp-d16 -mfloat-abi=hard -mthumb -o "$@"

clean: clean-Src

clean-Src:
	-$(RM) ./Src/clkdir.cyclo ./Src/clkdir.d ./Src/clkdir.o ./Src/clkdir.su ./Src/fifo.cyclo ./Src/fifo.d ./Src/fifo.o ./Src/fifo.su ./Src/main.cyclo ./Src/main.d ./Src/main.o ./Src/main.su ./Src/motor.cyclo ./Src/motor.d ./Src/motor.o ./Src/motor.su ./Src/syscalls.cyclo ./Src/syscalls.d ./Src/syscalls.o ./Src/syscalls.su ./Src/sysmem.cyclo ./Src/sysmem.d ./Src/sysmem.o ./Src/sysmem.su ./Src/timers.cyclo ./Src/timers.d ./Src/timers.o ./Src/timers.su

.PHONY: clean-Src

