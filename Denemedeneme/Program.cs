static void Main(string[] args)
{
    //Kullanıcıya ismini girmesini yazdırıyoruz
    Console.Write("Lütfen isminizi giriniz : ");
    //kullanıcının girdiği değeri name değişkenine atıyoruz.
    string name = Console.ReadLine();
    //hoşgeldin mesajı iletiyoruz
    Console.WriteLine("Sayı tahmin oyununa hoşgeldin {0}", name);
    //Random sınıfından bir nesne türetiyoruz
    Random rastgele = new Random();
    //tamsayı türünde sayi isimli değişken tanımlayıp rastgele adında ürettiğimiz 1 ile 100 aralığında rastgele sayı atıyoruz 
    int sayi = rastgele.Next(1, 100);
    //tahmin isinli tamsayı değişkeni bildiriyoruz
    int tahmin;
    //kaç tahminde bulacağını tutan tahminSayisi adında int değişken tanımlıyoruz ve 0 değerini atıyoruz.
    int tahminSayisi = 0;
    //kullanıcıdan doğru tahminde bulunana kadar dönecek bir while döngüsü oluşturuyoruz.
    while (true)
    {
        //Kullanıcıdan 1 ile 100 arasında bir sayı girmesi isteniyor
        Console.Write("\nLütfen 1 ile 100 arasında bir sayı tahmin et : ");
        //girilen değeri string türünde girilenTahmin değişkenine atıyoruz.
        string girilenTahmin = Console.ReadLine();
        //girilen değerin int sayı türüne çevrilip çevrilemediği kontrol ediliyor ve çevrilmesi durumunda tahmin değişkenine atanıyor.
        if (int.TryParse(girilenTahmin, out tahmin))
        {
            //tahminSayisi değişkeni 1 arttırılıyor
            tahminSayisi++;
            //sayı değişkeninin tahmin sayısına eşit olma durumu kontrol ediliyor 
            if (sayi == tahmin)
            {
                //sayı değişkeninin tahmin değişkenine eşit olması durumunda kullanıcıya mesaj verilerek kaç denemede tahmin edildiği belirtiliyor ve döngüden çıkılıyor
                Console.WriteLine("Tebrikler {0}. denemede doğru tahminde bulundunuz.", tahminSayisi);
                break;
            }
            //sayı değişkeninin tahmin değişkeinden küçük olma durumu kontrol ediliyor. 
            else if (tahmin < sayi)
            {
                //sayı değişkenin tahmin değişkeninden küçük olması durumunda daha büyük değer girilmesi belirtilerek döngü bir sonraki iterasyondan devam ediyor
                Console.WriteLine("Daha büyük bir tahminde bulunun...");
                continue;
            }
            //sayı değişkeninin tahmin değişkeni ile yukarıda ki koşulları sağlamaması durumu kontrol ediliyor.
            else
            {
                // kullanıcıya daha küçük bir değer girmesi konusunda mesaj verilir ve döngü bir sonraki iterasyondan devam ettirilir
                Console.WriteLine("Daha küçük bir sayı tahmininde bulunun...");
                continue;
            }
        }
        //girilen değerin int sayı türüne çevrilip çevrilemediği kontrol ediliyor ve çevrilmemesi durumunda çalıştırılacak blok
        else
        {

            Console.WriteLine("Bir tamsayı değeri girmeniz gerekmektedir...");
            continue;
        }

    }

}
