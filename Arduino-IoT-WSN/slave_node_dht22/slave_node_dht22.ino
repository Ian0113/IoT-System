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
  AddBuf(TEMP, random(22, 26));
//  AddBuf(TEMP, TempPor());
  AddBuf(HUMI, random(33, 50));
//  AddBuf(HUMI, HumiPro());
  AddBuf(BRIGHT, random(66, 100));
//  AddBuf(BRIGHT, BrightPro());
  Send();
}