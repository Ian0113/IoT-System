#include <DHT.h>

/*腳位定義  ----------------------------------------------------------------*/
#define         _PIN_DHT_01               2
#define         _PIN_DHT_02               3
#define         _PIN_BRITNESS             A0
DHT dht_01(_PIN_DHT_01, DHT22);
DHT dht_02(_PIN_DHT_02, DHT22);


void MeterInit(){
  pinMode(_PIN_BRITNESS, INPUT);
  delay(500);
}

byte HumiPro(){
  byte humi;
  while(1){
    humi = dht_01.readHumidity();
    if(!isnan(humi) & humi!=0){
      return humi;
    }
  }
}

byte TempPro(){
  byte temp;
  while(1){
    temp = dht_01.readTemperature();
    if(!isnan(temp) & temp!=0){
//      temp = dht_01.readTemperature();
      return temp;
    }
  }
}

int BrightPro(){
  int bright = analogRead(_PIN_BRITNESS);
  bright = map(bright, 0, 1023, 0, 100);
  return (bright);
}