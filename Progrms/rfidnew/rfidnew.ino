#include <Servo.h>

unsigned char getData,i=0, idFlag=0;
unsigned char rfId[20]={0};

Servo myservo1;  // create servo object to control a servo
Servo myservo2;
int l=-1;
void setup()
{
  pinMode(3, OUTPUT);
  pinMode(2, OUTPUT);
  digitalWrite(2,HIGH);
  digitalWrite(3,HIGH);
  
  myservo1.attach(9);  //1
myservo2.attach(10);
  
  pinMode(13, OUTPUT);
  digitalWrite(13,HIGH);
  Serial.begin (9600);
  Serial.println("RFID Reader");
}

void loop()
{
  i=0;
  Serial.println("Waiting for new Card");
    myservo1.write(20);
    myservo2.write(0);
     while(1)
     {       
       while(!Serial.available());
            getData=Serial.read();                 
     
        if(getData<48)
        {
            
           if(idFlag==1)
           {
             Serial.println("Waiting for new Card");
             myservo1.write(20);
             myservo2.write(0);
             idFlag=0;
            for(i=0;i<10;i++)
              {
                Serial.println(rfId[i]-48);
              }
              
           }
            break;
        }
        else
        {
          idFlag=1;
            rfId[i]=getData;      
            Serial.println(getData-48);
            i++;
        }
      
     } 
    if(l==3)
    {Serial.println("arm");
     arm();
    } 
    l++;
}

int arm() 
{ 
 Serial.println("armfunction");
 
   myservo1.write(20);
   myservo2.write(0);

    delay(1000);
    delay(1000);
    
   myservo1.write(180);
   myservo2.write(0);

    delay(1000);
    delay(1000);
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
    
   myservo1.write(150);
   myservo2.write(90);
    
  
    delay(1000);
    delay(1000);
    
   myservo1.write(90);
   myservo2.write(0);
   return(1);
} 

