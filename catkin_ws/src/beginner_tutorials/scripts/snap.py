import numpy as np
import cv2

cap = cv2.VideoCapture(0)

gray=cv2.imread('images.jpg')
cv2.imshow('frame',gray)
cv2.waitKey(0)
    
