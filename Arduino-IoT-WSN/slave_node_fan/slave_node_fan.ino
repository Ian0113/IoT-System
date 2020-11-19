enum Meter{
  FAN_SWITCH,
  FOG_SWITCH,
  TEMP,
  HUMI,
  BRIGHT,
  PH,
  EC,
};

void ControlMeter(byte meter, byte sw){
  if(meter == FAN_SWITCH){
    if(sw == 1){
      FanON();
    }
    else{
      FanOFF();
    }
  }
}


void setup() {
  // put your setup code here, to run once:
  ConnectionInit();
  MeterInit();
}

void loop() {
  // put your main code here, to run repeatedly:
  ReadByte();
  Unpacakge();
  AddBuf(FAN_SWITCH, FanStatus());
  Send();
}