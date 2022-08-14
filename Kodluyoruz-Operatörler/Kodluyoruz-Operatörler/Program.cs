// atama işlemleri
int a = 3;
int b = 3;
b = b + 2;

Console.WriteLine(b);
b += 2;
Console.WriteLine(b);
b /= 1;
Console.WriteLine(b);
a *= 2;
Console.WriteLine(a);

//mantıksal operatorler

bool basariliMi = true;
bool tamamladiMi = false;

if (basariliMi && tamamladiMi)
{
    Console.WriteLine("Perfect");
}
if (basariliMi || tamamladiMi)
{
    Console.WriteLine("Great!..");
}
if (basariliMi && !tamamladiMi)
{
    Console.WriteLine("Fine!");
}

// ilişkisel operatorler

int x = 3;
int y = 4;
bool karsilastirma = x > y;
Console.WriteLine(karsilastirma);

karsilastirma = x < y;
Console.WriteLine(karsilastirma);

karsilastirma = x >= y;
Console.WriteLine(karsilastirma);

karsilastirma = x <= y;
Console.WriteLine(karsilastirma);

karsilastirma = x == y;
Console.WriteLine(karsilastirma);

karsilastirma = x != y;
Console.WriteLine(karsilastirma);

// aritmetik operatorler

int sayi1 = 21;
int sayi2 = 3;
int result1 = sayi1 / sayi2;
Console.WriteLine(result1);

result1 = sayi1 * sayi2;
Console.WriteLine(result1);

result1 = sayi1 + sayi2;
Console.WriteLine(result1);

result1 = sayi1 - sayi2;
Console.WriteLine(result1);

// mod
int result2 = 10 % 4;
Console.WriteLine(result2);