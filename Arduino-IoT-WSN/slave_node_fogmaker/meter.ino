/*腳位定義  ----------------------------------------------------------------*/
#define         _PIN_FOG                4


void MeterInit(){
  pinMode(_PIN_FOG, OUTPUT);
  digitalWrite(_PIN_FOG, HIGH);
  delay(500);
}

void FogON(){
  digitalWrite(_PIN_FOG, HIGH);
}

void FogOFF(){
  digitalWrite(_PIN_FOG, LOW);
}

byte FogStatus(){
  return digitalRead(_PIN_FOG);
}