unsigned char getData,i=0, idFlag=0;
unsigned char rfId[20]={0};
void setup()
{
  pinMode(3, OUTPUT);
  pinMode(2, OUTPUT);
  digitalWrite(2,HIGH);
  digitalWrite(3,HIGH);
  
  pinMode(10, OUTPUT);
  digitalWrite(10,HIGH);
  
   pinMode(10, OUTPUT);
  digitalWrite(8,LOW);
  
  pinMode(13, OUTPUT);
  digitalWrite(13,HIGH);
  Serial.begin (9600);
  Serial.println("RFID Reader");
}

void loop()
{
  i=0;
  Serial.println("Waiting for new Card");
     while(1)
     {       
       while(!Serial.available());
            getData=Serial.read();                 
     
        if(getData<48)
        {
            
           if(idFlag==1)
           {
             Serial.println("Waiting for new Card");
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
   
      
}
