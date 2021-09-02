

#include <EtherCard.h>
#include <IPAddress.h>
//#include <NetEEPROM.h>
#include <EEPROM.h>
#include <Bounce2.h>

#define STATIC 0
#if STATIC
// ethernet interface ip address
const  static  uint8_t myip [] = { 192 , 168 , 1 , 101 };
const  static  uint8_t gwip [] = { 192 , 168 , 1 , 1 };
const  static  uint8_t dnsip [] = { 192 , 168 , 1 , 1 };
// gateway ip address
#endif

#define start_gry 4
#define muza_palac 3

#define reset_karty 15
#define reset_kule 14
#define reset_273 16

byte stan_gry;
byte play_palac;

Bounce START_GRY = Bounce(); 
Bounce MUZA_PALAC = Bounce(); 


String myString = "";
//byte ip[4] = { 192, 168, 1, 102 };
const char website[] PROGMEM = "192.168.1.1";

static byte komp[] = { 192,168,1,101 };
unsigned long czas_reset_karty = 0;
unsigned long czas_reset_kule = 0;

const int dstPort PROGMEM = 49955;

const int srcPort PROGMEM = 49955;

// ethernet mac address - must be unique on your network
static byte mymac[] = { 0x70,0x69,0x69,0x2D,0x31,0x01 };

byte Ethernet::buffer[500]; // tcp/ip send and receive buffer

//=============================================================================================





//==============================================================================================




//callback that prints received packets to the serial port
void udpSerialPrint(uint16_t dest_port, uint8_t src_ip[IP_LEN], uint16_t src_port, const char *data, uint16_t len){
  IPAddress src(src_ip[0],src_ip[1],src_ip[2],src_ip[3]);

  Serial.print("dest_port: ");
  Serial.println(dest_port);
  Serial.print("src_port: ");
  Serial.println(src_port);


  Serial.print("src_IP: ");
  ether.printIp(src_ip);
   Serial.println("");
  Serial.print("data: ");
  Serial.println(data);
  char *message = data;

myString = String(message);
 
//Serial.println(myString);
//Serial.println(message);

//if(myString.substring(0, 5) == "ZAPIS"){
// // myString.substring(5, 8).toInt();
// Serial.print("DLUGOSC :  ");
// Serial.println(myString.length());
//  Serial.println(myString.substring(5, 8));
//  if(myString.length() == 19){
//  int liczba1 = myString.substring(5, 8).toInt();
//  int liczba2 = myString.substring(9, 12).toInt();
//  int liczba3 = myString.substring(13, 16).toInt();
//  int liczba4 = myString.substring(17, 19).toInt();
//  Serial.print("LICZBA1 :  ");
//   Serial.println(liczba1);
//   Serial.print("LICZBA2 :  ");
//   Serial.println(liczba2);
//   Serial.print("LICZBA3 :  ");
//   Serial.println(liczba3);
//   Serial.print("LICZBA4 :  ");
//   Serial.println(liczba4);
//  Serial.println("ZAPIS OK 19");
//   byte mac[6] = { 0xCA, 0xFE, 0xBA, 0xBE, 0x00, 0x00 };
// byte ip[4] = { 0, 0, 0, 0 };
//  byte dns[4] = { 8, 8, 8, 8 };
//  byte gw[4] = { 192, 168, 100, 1 };
//  byte subnet[4] = { 255, 255, 255, 0 };
//  ip[0] = liczba1;
//  ip[1] = liczba2;
//  ip[2] = liczba3;
//  ip[3] = liczba4;
//
//  NetEeprom.writeManualConfig(mac, ip, gw, subnet, dns);
//  NetEeprom.readIp(komp);
//   ether.sendUdp("ZAPIS IP KOMPUTERA", 18, srcPort, komp, dstPort );
//  }
//
//  if(myString.length() == 20){
//  int liczba1 = myString.substring(5, 8).toInt();
//  int liczba2 = myString.substring(9, 12).toInt();
//  int liczba3 = myString.substring(13, 16).toInt();
//  int liczba4 = myString.substring(17, 20).toInt();
//  Serial.print("LICZBA1 :  ");
//   Serial.println(liczba1);
//   Serial.print("LICZBA2 :  ");
//   Serial.println(liczba2);
//   Serial.print("LICZBA3 :  ");
//   Serial.println(liczba3);
//   Serial.print("LICZBA4 :  ");
//   Serial.println(liczba4);
//  Serial.println("ZAPIS OK 20");
//  
//  
// byte mac[6] = { 0xCA, 0xFE, 0xBA, 0xBE, 0x00, 0x00 };
// byte ip[4] = { 0, 0, 0, 0 };
//  byte dns[4] = { 8, 8, 8, 8 };
//  byte gw[4] = { 192, 168, 100, 1 };
//  byte subnet[4] = { 255, 255, 255, 0 };
//  ip[0] = liczba1;
//  ip[1] = liczba2;
//  ip[2] = liczba3;
//  ip[3] = liczba4;
//
//  NetEeprom.writeManualConfig(mac, ip, gw, subnet, dns);
//  NetEeprom.readIp(komp);
//    ether.sendUdp("ZAPIS IP KOMPUTERA", 18, srcPort, komp, dstPort );
//  }
//  NetEeprom.readIp(komp);
//  
//}
if(myString == "RESET"){
  stan_gry = 0;
  play_palac = 0;
   
   digitalWrite(reset_273,HIGH);
    delay(2000);
    digitalWrite(reset_273,LOW);
ether.sendUdp("PRZYCISKI ZRESETOWANE", 21, srcPort, komp, dstPort );
    
}
  if(myString == "RESET KARTY"){
  czas_reset_karty = millis();
  digitalWrite(reset_karty,HIGH);
  ether.sendUdp("RESETOWANIE KART", 16, srcPort, komp, dstPort );
 // stan_gry = 0;
 // play_palac = 0;
//  ether.sendUdp("PRZYCISKI ZRESETOWANE", 21, srcPort, komp, dstPort );
  }

  if(myString == "RESET KULE"){
  czas_reset_kule = millis();
  digitalWrite(reset_kule,HIGH);
  ether.sendUdp("RESETOWANIE KULI", 16, srcPort, komp, dstPort );
  }

  if(myString == "RESET 273"){
    digitalWrite(reset_273,HIGH);
    delay(2000);
    digitalWrite(reset_273,LOW);
    ether.sendUdp("RESETOWANIE 273", 15, srcPort, komp, dstPort );
  }
  
  
myString="";
  
}
void setup() {
 // NetEeprom.readIp(komp);
  Serial.begin(9600);
  pinMode(start_gry,INPUT);
  pinMode(muza_palac,INPUT);
  pinMode(reset_karty,OUTPUT);
  pinMode(reset_kule,OUTPUT);
  pinMode(reset_273,OUTPUT);

START_GRY.attach(start_gry);
MUZA_PALAC.attach(muza_palac);

START_GRY.interval(30);
MUZA_PALAC.interval(30);
  
if (ether.begin(sizeof Ethernet::buffer, mymac, SS) == 0)
    Serial.println(F("Failed to access Ethernet controller"));
#if STATIC
  ether.staticSetup(myip, gwip);
#else
  if (!ether.dhcpSetup())
    Serial.println(F("DHCP failed"));
#endif

  ether.printIp("IP:  ", ether.myip);
  ether.printIp("GW:  ", ether.gwip);
  ether.printIp("DNS: ", ether.dnsip);
  //ether.dnsLookup(website);
if (!ether.dnsLookup(website))
    Serial.println("DNS failed");

  ether.printIp("SRV: ", ether.hisip);
  
  //register udpSerialPrint() to port 1337
  ether.udpServerListenOnPort(&udpSerialPrint, 49955);

  //register udpSerialPrint() to port 42.
  ether.udpServerListenOnPort(&udpSerialPrint, 49955);
  delay(1000);
  //char textToSend[] = "CENTRALNY ZALOGOWANY"; 
    ether.sendUdp("CENTRALNY ZALOGOWANY", 25, srcPort, komp, dstPort );
    delay(50);
//if (NetEeprom.checkMagic()) {
//    byte mac[6];
//    NetEeprom.readMac(mac);
//    Serial.print("MAC: "); printMac(mac); Serial.println();
//    if (NetEeprom.isDhcp()) {
//      Serial.println("Network configured using DHCP");
//    } else {
//      byte addr[4];
//      NetEeprom.readIp(addr);
//      Serial.print("IP KOMP: "); printIp(addr); Serial.println();
//      NetEeprom.readDns(addr);
//      Serial.print("DNS: "); printIp(addr); Serial.println();
//      NetEeprom.readGateway(addr);
//      Serial.print("GW: "); printIp(addr); Serial.println();
//      NetEeprom.readSubnet(addr);
//      Serial.print("Subnet: "); printIp(addr); Serial.println();
//    }
//  } else {
//    Serial.println("Network MAC and IP have not been configured");
//  }
//   NetEeprom.readIp(komp);
}

void loop() {
START_GRY.update();
MUZA_PALAC.update();

if(millis() > czas_reset_karty + 3000){
  digitalWrite(reset_karty,LOW);
}
if(millis() > czas_reset_kule + 3000){
  digitalWrite(reset_kule,LOW);
}
if(stan_gry == 0){
if (START_GRY.rose()){
  ether.sendUdp("START GRY", 9, srcPort, komp, dstPort );
  stan_gry = 1;
}
}
if(play_palac == 0){
if (MUZA_PALAC.rose()){
  ether.sendUdp("PLAY PALAC", 10, srcPort, komp, dstPort );
  play_palac = 1;
}
}
  
   ether.packetLoop(ether.packetReceive());
}

//=============================================================================

void printMac(byte mac[]) {
  for (int i = 0; i < 6; i++) {
    if (i > 0) {
      Serial.print(":");
    }
    if (mac[i] < 0x10) {
      Serial.print("0");
    }
    Serial.print(mac[i], HEX);
  }
}

void printIp(byte ip[]) {
  for (int i = 0; i < 4; i++) {
    if (i > 0) {
      Serial.print(".");
    }
    Serial.print(ip[i]);
  }
}
