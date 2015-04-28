#!/usr/bin/env python

import rospy
from std_msgs.msg import String
import numpy as np
import cv2
import time


def callback(data):
      rospy.loginfo(rospy.get_caller_id()+"I heard %s",data.data)
      print('arm being moved')
      out()

      
          
def out():
    pub = rospy.Publisher('sound', String)
    r = rospy.Rate(10) # 10hz
    while not rospy.is_shutdown():
        str = "action completed %s"%rospy.get_time()
        rospy.loginfo(str)
        pub.publish(str)
        r.sleep()
        time.sleep(3)
           
    
    
def camera():

    # in ROS, nodes are unique named. If two nodes with the same
    # node are launched, the previous one is kicked off. The 
    # anonymous=True flag means that rospy will choose a unique
    # name for our 'talker' node so that multiple talkers can
    # run simultaenously.
    rospy.init_node('roboticarm', anonymous=True)
    rospy.Subscriber("arm", String, callback)

    # spin() simply keeps python from exiting until this node is stopped
    rospy.spin()
   
        
if __name__ == '__main__':
    camera()
