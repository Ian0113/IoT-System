#include <SoftwareSerial.h>

/*腳位定義  ----------------------------------------------------------------*/
#define         _PIN_TEST_LED           13
#define         _PIN_SOFT_RX                9
#define         _PIN_SOFT_TX                10



/*程式定義  ----------------------------------------------------------------*/
#define         _IS_DISPLAY_MSG         false
#define         _BAUD                   9600
#define         _PACKAGE_SIZE           64



/*程式變數  ----------------------------------------------------------------*/
SoftwareSerial mySerial(_PIN_SOFT_RX, _PIN_SOFT_TX);
bool _isReadFromBroad = false;
bool _isSendToPC = false;

bool _isReadFromPC = false;
bool _isSendToBroad = false;

byte *_readFromBroadBuf = new byte[_PACKAGE_SIZE];
byte *_readFromBroadCnt = new byte(0);

byte *_readFromPCBuf = new byte[_PACKAGE_SIZE];
byte *_readFromPCCnt = new byte(0);


void test(){
  if(mySerial.available()>0){
    byte b = mySerial.read();
    byte t = 0;
    t = (b & 128) >> 7;
    Serial.println(t);
    t = (b & 112) >> 4;
    Serial.println(t);
    t = (b & 15);
    Serial.println(t);
  }
}

void test2(){
  byte b = 0;
  b += 0 << 7;
  b += 1 << 4;
  b += 14;
//  Serial.println(b);
  mySerial.write(255);
  mySerial.flush();
//  mySerial.write(b);
//  mySerial.flush();
//  mySerial.write(10);
//  mySerial.flush();
  mySerial.write(254);
  mySerial.flush();
//  delay(200);
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
  memset(_readFromBroadBuf, 0, _PACKAGE_SIZE);
  memset(_readFromPCBuf, 0, _PACKAGE_SIZE);
  pinMode(_PIN_TEST_LED, OUTPUT);
  digitalWrite(_PIN_TEST_LED, LOW);
  delay(500);
}

void ReadByteFromBroad(){
  delay(1);
  if( (!_isSendToPC) & mySerial.available()>0){
    // 標頭
    if( (!_isReadFromBroad) & (byte(mySerial.peek()) == byte(255)) ){
      *(_readFromBroadBuf+(*_readFromBroadCnt)) =  mySerial.read();
      (*_readFromBroadCnt)++;
      _isReadFromBroad = true;
      sprint("封包:");
    }

    // 標尾
    else if( _isReadFromBroad & (byte(mySerial.peek()) == byte(254)) ){
      *(_readFromBroadBuf+(*_readFromBroadCnt)) =  mySerial.read();
      (*_readFromBroadCnt)++;
      _isReadFromBroad = false;
      _isSendToPC = true;
      vprint(_readFromBroadBuf, (*_readFromBroadCnt), true);
    }

    // 取到標頭 讀取封包內容
//    else if( _isReadFromBroad & (byte(mySerial.peek()) >= 0 & byte(mySerial.peek()) <= 253) ){
    else if( _isReadFromBroad ){
      *(_readFromBroadBuf+(*_readFromBroadCnt)) =  mySerial.read();
      (*_readFromBroadCnt)++;
    }

    // 錯誤訊息
    else{
      (*_readFromBroadCnt) = 0;
      _isReadFromBroad = false;
      mySerial.read();
    }
  }
}

void ReadByteFromPC(){
  delay(1);
  if( (!_isSendToBroad) & Serial.available()>0){
    // 標頭
    if( (!_isReadFromPC) & (byte(Serial.peek()) == byte(255)) ){
      digitalWrite(_PIN_TEST_LED, HIGH);
      *(_readFromPCBuf+(*_readFromPCCnt)) =  Serial.read();
      (*_readFromPCCnt)++;
      _isReadFromPC = true;
    }

    // 標尾
    else if( _isReadFromPC & (byte(Serial.peek()) == byte(254)) ){
      *(_readFromPCBuf+(*_readFromPCCnt)) =  Serial.read();
      (*_readFromPCCnt)++;
      _isReadFromPC = false;
      _isSendToBroad = true;
    }

    // 取到標頭 讀取封包內容
//    else if( _isReadFromPC & (byte(Serial.peek()) >= 0 & byte(Serial.peek()) <= 253) ){
    else if( _isReadFromPC ){
      *(_readFromPCBuf+(*_readFromPCCnt)) =  Serial.read();
      (*_readFromPCCnt)++;
    }

    // 錯誤訊息
    else{
      (*_readFromPCCnt) = 0;
      _isReadFromPC = false;
      Serial.read();
    }
  }
}

void SendToBroad(){
  if( _isSendToBroad ){
    for(int i=0; i<*_readFromPCCnt; i++){
      mySerial.write(*(_readFromPCBuf+i));
      mySerial.flush();
      delay(15);
    }
    digitalWrite(_PIN_TEST_LED, LOW);
    *_readFromPCCnt = 0;
    _isSendToBroad = false;
  }
}

void SendToPC(){
  if(_isSendToPC){
    for(int i=0; i<*_readFromBroadCnt; i++){
      Serial.write(*(_readFromBroadBuf+i));
      Serial.flush();
    }
    *_readFromBroadCnt = 0;
    _isSendToPC = false;
  }
}