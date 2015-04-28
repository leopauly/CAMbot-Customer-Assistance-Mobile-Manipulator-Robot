#!/usr/bin/env python
import rospy
from std_msgs.msg import String
import serial 
import time

def speaker():
    pub = rospy.Publisher('speech', String)
    rospy.init_node('speaker', anonymous=True)
    r = rospy.Rate(10) # 1hz
    inp='n'
    while (inp!='y'):
         print('Can I start')
         inp=raw_input();
    print('system is starting')
    ser = serial.Serial('/dev/ttyACM0', 9600)
    ser.write('5')
    print('The navigation command has been send')
    time.sleep(5)
    ser.write('10')
    print('The navigation command has been stopped')
    str = "reached location %s at "%rospy.get_time()
    while not rospy.is_shutdown():
        rospy.loginfo(str)
        pub.publish(str)
        str = "S"
        r.sleep()
        
if __name__ == '__main__':
    try:
        speaker()
    except rospy.ROSInterruptException: pass
