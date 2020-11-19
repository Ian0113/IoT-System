void setup() {
  // put your setup code here, to run once:
  ConnectionInit();
}

void loop() {
  // put your main code here, to run repeatedly:
  ReadByteFromBroad();
  SendToPC();
  ReadByteFromPC();
  SendToBroad();
}