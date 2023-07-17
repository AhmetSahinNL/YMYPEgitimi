Console.WriteLine("Hello, World!");

//Operatörler
//= eşittir operatörleri => değer ataması yapar
//== kontrol operatörü => a ve b değerini kontrol eder

int a = 0;
int b = 1;

var c = (a == b);

// + - * / 

int r = ((5 * 2) + 5) - 0;

// += eşittirden sonraki değeri + işaretinden önceki değere ekler
// -= eşittirden sonraki değeri - işaretinden önceki değerden çıkartır


int z = 1;

z += 5; //===> z = z + 5;

//++; kullanılan değişkenin rakamını 1 artırır
//--; kullanılan değişkenin rakamını 1 azaltır
int x = 1;
x++;
x--;

//+ operatörü string değerlerde birleştirme işlemi yapar;

string name = "Taner" + " " + "Saydam"; // Taner Saydam
string name2 = $"{name} 34 yaşında bir eğitmen"; // ==> Taner Saydam 34 yaşında bir eğitmen
//@ operatör  Ters bölü işaretini kullanmamızı sağlıyor \\
string url = @"http:\"; //== > http:\ 

var result = name + 2; // Rakam + string birleştirme işlemi yapar ==> Taner Saydam2

//% => mod operatörü sayının verilen sayıya tam bölünüp bölünmediğini kontrol eder 0 - 1 

var r2 = (x % 2);

