
// byte
byte b = 1; 
sbyte c = 2; 

//short
short s = 3; 
ushort us = 4; 

//long
uint ui = 9;   
long l = 10;    
ulong ul = 11;  

//integer
Int16 i16 = 5; 
int i = 6;     
Int32 i32 = 7; 
Int64 i64 = 8; 


//ondalık
float f = 12.12f;  
double dooub = 13.13;  
decimal decim = 14.14M; 

// string
char ch = 'a';   
string str = "oguzhan"; 

// tarih
DateTime dt = DateTime.Now;

// boolean
bool bool1 = true;
bool bool2 = false;

// obje
object object1 = "sadfsdf";
object object2 = 'a';
object object3 = 1;
object object4 = 20.20;

// string ifadeler

string str1 = string.Empty; // ''
str1 = "Oğuzhan Ak";
string isim = "Oğuzhan";
string soyisim = "Ak";
string birleşim = isim + " " + soyisim;

// integer tanımlamaları

int integer1 = 11;
int integer2 = 12;
int integer3 = integer1 * integer2;

// boolean

bool booll = 1 < 3;  // true

//degisken dönüşümleri

string string1 = "20";
int int1 = 20;
string donusmus = string1 + int1.ToString();
Console.WriteLine(donusmus);

int int2 = int1 + Convert.ToInt32(string1);
Console.WriteLine(int2);

int int3 = int2 + int.Parse(string1);


//d atetime

string datetime1 = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime1);

string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime2);

// saat
string saat = DateTime.Now.ToString("HH:mm");
Console.WriteLine(saat);
