class Program
{
    class Ogrenci
    {
        public string Ad;
        public int Numara;
        public bool SiniftaMi;
    }

    static List<Ogrenci> ogrenciListesi = new List<Ogrenci>
    {
        new Ogrenci { Numara = 101, Ad = "Ali A.", SiniftaMi = true },
        new Ogrenci { Numara = 202, Ad = "Ayşe B.", SiniftaMi = false },
        new Ogrenci { Numara = 303, Ad = "Mehmet C.", SiniftaMi = true },
        new Ogrenci { Numara = 404, Ad = "Zeynep D.", SiniftaMi = true },
        new Ogrenci { Numara = 505, Ad = "Kemal E.", SiniftaMi = false },
    };

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("---------------- Öğrenci Kayıt ve Yoklama Takip Sistemi ----------------");
            Console.WriteLine("1. Öğrenci Kaydı Yap");
            Console.WriteLine("2. Öğrenci Listesini Görüntüle");
            Console.WriteLine("3. Gelmeyen Öğrencileri Görüntüle");
            Console.WriteLine("4. Yoklama Al");
            Console.WriteLine("5. Çıkış");
            Console.WriteLine("------------------------------------------------------------------------");

            Console.WriteLine("Lütfen bir işlem seçiniz (1-5): ");
            int secim;
            if (!int.TryParse(Console.ReadLine(), out secim) || secim < 1 || secim > 5)
            {
                Console.WriteLine("Hatalı seçim! Lütfen geçerli bir işlem seçiniz.");
                continue;
            }

            switch (secim)
            {
                case 1:
                    OgrenciKaydiYap();
                    break;
                case 2:
                    OgrenciListesiniGoruntule();
                    break;
                case 3:
                    GelmeyenOgrencileriGoruntule();
                    break;
                case 4:
                    YoklamaAl();
                    break;
                case 5:
                    Console.WriteLine("Çıkış yapılıyor...");
                    return;
            }

            Console.WriteLine("------------------------------------------------");
        }
    }

    static void OgrenciKaydiYap()
    {
        Console.WriteLine("Öğrenci adını giriniz: ");
        string ad = Console.ReadLine();

        Console.WriteLine("Öğrenci numarasını giriniz: ");
        int numara;
        if (!int.TryParse(Console.ReadLine(), out numara))
        {
            Console.WriteLine("Hatalı numara girdiniz! Lütfen tekrar deneyiniz.");
            return;
        }

        ogrenciListesi.Add(new Ogrenci { Ad = ad, Numara = numara });
        Console.WriteLine($"Öğrenci kaydı başarıyla yapıldı: {ad}, {numara}");
    }

    static void OgrenciListesiniGoruntule()
    {
        Console.WriteLine("****************************** ÖĞRENCİ LİSTESİ ******************************");
        foreach (var ogrenci in ogrenciListesi)
        {
            Console.WriteLine($"Öğrenci Adı: {ogrenci.Ad} - Öğrenci Numarası: {ogrenci.Numara} - Sınıfta mı? {(ogrenci.SiniftaMi ? "Evet" : "Hayır")}");
        }
    }

    static void GelmeyenOgrencileriGoruntule()
    {
        Console.WriteLine("****************************** GELMEYEN ÖĞRENCİLER ******************************");
        foreach (var ogrenci in ogrenciListesi)
        {
            if (!ogrenci.SiniftaMi)
            {
                Console.WriteLine($"{ogrenci.Numara}. numaralı {ogrenci.Ad} isimli öğrenci sınıfta değildir.");
            }
        }
    }

    static void YoklamaAl()
    {
        Console.WriteLine("Öğrenci numarasını giriniz: ");
        int numara;
        if (!int.TryParse(Console.ReadLine(), out numara))
        {
            Console.WriteLine("Hatalı numara girdiniz! Lütfen tekrar deneyiniz.");
            return;
        }

        var ogrenci = ogrenciListesi.Find(o => o.Numara == numara);
        if (ogrenci != null)
        {
            Console.WriteLine($"Yoklama alındı: {ogrenci.Ad}, {ogrenci.Numara}");
            Console.WriteLine("Öğrenci sınıfta mı? (Evet: E, Hayır: H)");
            string cevap = Console.ReadLine().ToLower();

            ogrenci.SiniftaMi = (cevap == "e");
        }
        else
        {
            Console.WriteLine("Öğrenci bulunamadı. Geçersiz numara girdiniz.");
        }
    }
}
