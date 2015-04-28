import rospy
import serial 
from std_msgs.msg import String
import time

inp='n'
while (inp!='y'):
 print('Can I start')
 inp=raw_input();
print('system is starting')
ser = serial.Serial('/dev/ttyACM0', 9600)
ser.write('5')
print('The navigation command has been send')
time.sleep(30)
ser.write('10')
print('The navigation command has been stopped')





