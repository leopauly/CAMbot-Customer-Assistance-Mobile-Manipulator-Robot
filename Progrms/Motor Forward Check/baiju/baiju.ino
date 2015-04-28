
void setup() 
{ 
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
{
  digitalWrite(13, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(12, LOW); 
  digitalWrite(11, HIGH);
  digitalWrite(10, LOW);  // turn the LED off by making the voltage LOW
 
  digitalWrite(4, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(5,LOW); 
  digitalWrite(6, HIGH);
  digitalWrite(7, LOW);  // turn the LED off by making the voltage LOW
 
}
