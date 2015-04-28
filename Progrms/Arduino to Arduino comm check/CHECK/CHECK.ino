const int buttonPin = 3; 
int buttonState=1;
char dat;

void setup() 
{ 
  Serial.begin(9600);
  pinMode(13,OUTPUT);
  pinMode(buttonPin, INPUT);
  digitalWrite(13, HIGH);
  
}


void loop() 
{ buttonState=1; 
  Serial.println(buttonState); 
  buttonState = digitalRead(buttonPin);
  Serial.println(buttonState); 
  if(buttonState==LOW)
   {Serial.println(buttonState); 
    digitalWrite(13, LOW);
    Serial.println("yes");
    while(1);
   }


 }
   
 
