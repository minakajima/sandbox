from machine import ADC
import time

sensor_temp = ADC(4)
conversion_factor = 3.3 / (65535)


while True:
   ADC_voltage = sensor_temp.read_u16() * conversion_factor
   temp = 27 - (ADC_voltage - 0.706)/0.001721
   temp = round(temp, 1)
   print(f"{temp=}°C")
   time.sleep(1)
