enum Meter{
  FAN_SWITCH,
  FOG_SWITCH,
  TEMP,
  HUMI,
  BRIGHT,
  PH,
  EC,
};

void ControlMeter(byte meter){
  if(meter == FOG_SWITCH){
//    digitalWrite()
  }
  else if(meter == FAN_SWITCH){
    
  }
}


void setup() {
  // put your setup code here, to run once:
  ConnectionInit();
}

void loop() {
  // put your main code here, to run repeatedly:
  ReadByte();
  Unpacakge();
  Send();
}