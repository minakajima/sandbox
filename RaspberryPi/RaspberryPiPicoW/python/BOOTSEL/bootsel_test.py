from machine import Pin
import time

led = Pin("LED", Pin.OUT)
   
while True:
    if rp2.bootsel_button() == 1:
        led.on()
    else:
        led.off()

    time.sleep(0.1)