#include <SoftwareSerial.h>

/*腳位定義  ----------------------------------------------------------------*/
#define         _PIN_TEST_LED           13
#define         _PIN_SOFT_RX            9
#define         _PIN_SOFT_TX            10
SoftwareSerial mySerial(_PIN_SOFT_RX, _PIN_SOFT_TX);

/*程式定義  ----------------------------------------------------------------*/
#define         _IS_DISPLAY_MSG         true
#define         _BAUD                   9600
#define         _PACKAGE_SIZE           64
#define         _TYPE_DATA              0
#define         _TYPE_CONTROL           1
#define         _BOARD                  1

/*程式變數  ----------------------------------------------------------------*/
bool _isRead = false;
bool _isUnpack = false;
bool _isSend = false;
byte *_readBufPrt = new byte[_PACKAGE_SIZE];
byte *_readCntPrt = new byte(0);

void test(){
  byte b = 0;
  b += _TYPE_CONTROL << 7;
  b += _BOARD << 4;
  b += 14;
  mySerial.write(b);
}

void vprint(byte* v, unsigned int vsize, bool isNextLine=true){
  if(_IS_DISPLAY_MSG){
    for(int i=0; i<vsize; i++){
      Serial.print(*(v+i));
      Serial.print(" ");
    }
    if(isNextLine) Serial.println();
    Serial.flush();
  }
}

void sprint(String s, bool isNextLine=false){
  if(_IS_DISPLAY_MSG){
    if(isNextLine) Serial.println(s);
    else Serial.print(s);
    Serial.flush();
  }
}

void ConnectionInit(){
  Serial.begin(_BAUD);
  mySerial.begin(_BAUD);
  while(Serial.available()>0){Serial.read();}
  while(mySerial.available()>0){mySerial.read();}
  pinMode(_PIN_TEST_LED, OUTPUT);
  digitalWrite(_PIN_TEST_LED, LOW);
  delay(500);
}

void ReadByte(){
  delay(1);
  if( (!_isSend) & (!_isUnpack) & mySerial.available()>0){
    // 標頭
    if( (!_isRead) & (byte(mySerial.peek()) == byte(255)) ){
      mySerial.read();
//      *(_readBufPrt+(*_readCntPrt)) =  mySerial.read();
//      (*_readCntPrt)++;
      _isRead = true;
      sprint("封包:");
    }

    // 標尾
    else if( _isRead & (byte(mySerial.peek()) == byte(254)) ){
      digitalWrite(_PIN_TEST_LED, HIGH);
      mySerial.read();
//      *(_readBufPrt+(*_readCntPrt)) =  mySerial.read();
//      (*_readCntPrt)++;
      vprint(_readBufPrt, (*_readCntPrt), true);
      _isRead = false;
      _isUnpack = true;
    }

    // 取到標頭 讀取封包內容
//    else if( _isRead & (byte(mySerial.peek()) >= 0 & byte(mySerial.peek()) <= 253) ){
    else if( _isRead ){
      *(_readBufPrt+(*_readCntPrt)) =  mySerial.read();
      (*_readCntPrt)++;
    }

    // 錯誤訊息
    else{
      (*_readCntPrt) = 0;
      _isRead = false;
      mySerial.read();
    }
  }
}

void Unpacakge(){
  if( _isUnpack & (!_isRead) & (!_isSend)){
    for(int i=0; i<(*_readCntPrt); i++){
      if(i%2 == 0){
        byte type = ((*(_readBufPrt+i)) & 128) >> 7;
        byte board = ((*(_readBufPrt+i)) & 112) >> 4;
        byte meter = (*(_readBufPrt+i)) & 15;
        if(type == _TYPE_CONTROL & board == _BOARD){
          ControlMeter(meter);
        }
      }
    }
    _isUnpack = false;
    _isSend = true;
  }
}

void AddBuf(byte m, byte val){
  if(_isSend){
    byte b = 0;
    b += _TYPE_DATA << 7;
    b += _BOARD << 4;
    b += m;
    *(_readBufPrt+(*_readCntPrt)) = b;
    *(_readBufPrt+(*_readCntPrt)+1) = val;
    (*_readCntPrt) += 2;
  }
}

void Send(){
  if( _isSend ){
    mySerial.write(255);
    delay(15);
    for(int i=0; i<*_readCntPrt; i++){
      mySerial.write(*(_readBufPrt+i));
      mySerial.flush();
      delay(15);
    }
    mySerial.write(254);
    delay(15);
    *_readCntPrt = 0;
    _isSend = false;
    digitalWrite(_PIN_TEST_LED, LOW);
    sprint("傳送...", true);
  }
}