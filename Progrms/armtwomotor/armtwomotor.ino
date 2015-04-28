#include <Servo.h>
 


Servo myservo1;  // create servo object to control a servo
Servo myservo2;
Servo myservo3;
Servo myservo4;
Servo myservo5;
Servo myservo6;// a maximum of eight servo objects can be created
 
int pos = 0;    // variable to store the servo position
 
void setup() 
{ 
myservo1.attach(9);  //1
myservo2.attach(10);    //2
//myservo3.attach(6); //3  
//myservo4.attach(11);
//myservo5.attach(10);
//myservo6.attach(9);

 
}


void loop() 
{ 
 
   myservo1.write(20);
   myservo2.write(0);

    delay(1000);
    delay(1000);
    
   myservo1.write(150);
   myservo2.write(0);

    delay(1000);
    delay(1000);
    
   myservo1.write(70);
   myservo2.write(0);
  
   delay(1000);
    delay(1000);
    
   myservo1.write(70);
   myservo2.write(90);
   
   
    delay(1000);
    delay(1000);
    
   myservo1.write(90);
   myservo2.write(90);
    
  
    delay(1000);
    delay(1000);
    
   myservo1.write(90);
   myservo2.write(0);
} 

