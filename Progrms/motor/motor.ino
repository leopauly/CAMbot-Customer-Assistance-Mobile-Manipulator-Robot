const int buttonPin = 3; 
int buttonState = 1;
char dat;

void setup() 
{ 
  Serial.begin (9600);
  pinMode(13, OUTPUT);
  pinMode(12, OUTPUT);
  pinMode(11, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(7, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(4, OUTPUT);
  
  
}


void loop() 
{ if(Serial.available()>0)
  {    
  dat=Serial.read();  
  
  if(dat=='A')
  {
  digitalWrite(12, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(13, LOW); 
  digitalWrite(10, HIGH);
  digitalWrite(11, LOW);  // turn the LED off by making the voltage LOW
 
  digitalWrite(5, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(4,LOW); 
  digitalWrite(7, HIGH);
  digitalWrite(6, LOW);
  delay(80000);
  
  digitalWrite(13, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(12, LOW); 
  digitalWrite(11, HIGH);
  digitalWrite(10, LOW);  // turn the LED off by making the voltage LOW
 
  digitalWrite(4, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(5,LOW); 
  digitalWrite(6, HIGH);
  digitalWrite(7, LOW);
  delay(80000);
  digitalWrite(12, LOW);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(13, LOW); 
  digitalWrite(10, LOW);
  digitalWrite(11, LOW);  // turn the LED off by making the voltage LOW
 
  digitalWrite(5, LOW);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(4,LOW); 
  digitalWrite(7, LOW);
  digitalWrite(6, LOW);
  
  }
 }

}
  
