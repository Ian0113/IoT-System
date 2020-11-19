/*腳位定義  ----------------------------------------------------------------*/
#define         _PIN_FAN                4


void MeterInit(){
  pinMode(_PIN_FAN, OUTPUT);
  digitalWrite(_PIN_FAN, LOW);
  delay(500);
}

void FanON(){
  digitalWrite(_PIN_FAN, HIGH);
}

void FanOFF(){
  digitalWrite(_PIN_FAN, LOW);
}

byte FanStatus(){
  return digitalRead(_PIN_FAN);
}