#include <Servo.h>
 
const int buttonPin = 4; 
int buttonState = 1;

Servo myservo1;  // create servo object to control a servo
Servo myservo2;
Servo myservo3;
Servo myservo4;
Servo myservo5;
Servo myservo6;// a maximum of eight servo objects can be created
 
int pos = 0;    // variable to store the servo position
 
void setup() 
{ 
myservo1.attach(3);  //1
myservo2.attach(5);    //2
myservo3.attach(6); //3  
myservo4.attach(9);
myservo5.attach(10);
myservo6.attach(11);
pinMode(buttonPin, INPUT);
 
}


void loop() 
{ 
  buttonState = digitalRead(buttonPin);  
 if(buttonState ==LOW)
   {
    myservo1.write(0);
   myservo2.write(90);
   myservo3.write(90);
   myservo4.write(0);
   myservo5.write(0);
   myservo6.write(0);
         
         delay(1000);
         delay(1000);
   myservo1.write(0);
   myservo2.write(90);
   myservo3.write(135);
   myservo4.write(0);
   myservo5.write(0);
   myservo6.write(0);
   
    delay(1000);
    delay(1000);
  
   myservo1.write(0);
   myservo2.write(90);
   myservo3.write(135);
   myservo4.write(45);
   myservo5.write(0);
   myservo6.write(0);
   
   delay(1000);
   delay(1000);
  
   myservo1.write(0);
   myservo2.write(90);
   myservo3.write(180);
   myservo4.write(45);
   myservo5.write(0);
   myservo6.write(0);
         
         delay(1000);
         delay(1000);
  
   myservo1.write(0);
   myservo2.write(90);
   myservo3.write(180);
   myservo4.write(45);
   myservo5.write(0);
   myservo6.write(140);
   
    delay(1000);
    delay(1000);
  
   myservo1.write(0);
   myservo2.write(90);
   myservo3.write(180);
   myservo4.write(45);
   myservo5.write(0);
   myservo6.write(90);
   
   delay(1000);
   delay(1000);
   
   myservo1.write(0);
   myservo2.write(90);
   myservo3.write(180);
   myservo4.write(45);
   myservo5.write(90);
   myservo6.write(90);
         
         delay(1000);
         delay(1000);

   myservo1.write(0);
   myservo2.write(90);
   myservo3.write(90);
   myservo4.write(45);
   myservo5.write(90);
   myservo6.write(90);
   
    delay(1000);
    delay(1000);

   myservo1.write(180);
   myservo2.write(90);
   myservo3.write(90);
   myservo4.write(45);
   myservo5.write(90);
   myservo6.write(90);
   
   delay(1000);
   delay(1000);
   
   myservo1.write(180);
   myservo2.write(90);
   myservo3.write(90);
   myservo4.write(45);
   myservo5.write(0);
   myservo6.write(90);
         
         delay(1000);
         delay(1000);
         
   myservo1.write(180);
   myservo2.write(90);
   myservo3.write(90);
   myservo4.write(0);
   myservo5.write(0);
   myservo6.write(140);
   
    delay(1000);
    delay(1000);    
     
    while(1);
  }
} 

