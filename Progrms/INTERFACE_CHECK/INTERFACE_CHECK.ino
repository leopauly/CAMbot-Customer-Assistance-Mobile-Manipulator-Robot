char dat;

void setup() 
{ 
  
  Serial.begin (9600);
  pinMode(13, OUTPUT);
  digitalWrite(13, HIGH);
  
}


void loop() 
{ Serial.println("ready");
  while(Serial.available()>0)
  {dat=Serial.read();
   Serial.println(dat);
  digitalWrite(13, LOW); 
  while(1);  // turn the LED on (HIGH is the voltage level)
  }
   
 
}
