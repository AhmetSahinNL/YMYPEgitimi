using System;
using System.Collections.Generic;

namespace _11.ArabalarConsoleApp
{
    internal class Program
    {
        private static List<Car> cars = new List<Car>
        {
            new Car { Marka = "BMW", Model = 2020, MotorGucu = 5000 },
            new Car { Marka = "Ferrari", Model = 2022, MotorGucu = 8000 },
            new Car { Marka = "Lamborghini", Model = 2021, MotorGucu = 6500 },
            new Car { Marka = "Porsche", Model = 2023, MotorGucu = 6800 }
        };

        private static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine(" <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<   ARABA YAPAY ZEKASINA HOŞGELDİNİZ!   >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> ");
            Console.WriteLine("");
            ShowMenu();
            ProcessUserInput();
        }

        private static void ShowMenu()
        {

            Console.WriteLine("İşlem Listesi");
            Console.WriteLine("1- Araç Sayısı");
            Console.WriteLine("2- Araç Listesi");
            Console.WriteLine("3- Araç Ekle");
            Console.WriteLine("4- Araç Kirala");
            Console.WriteLine("5- Çıkış");
            Console.WriteLine("");
        }

        private static void ProcessUserInput()
        {
            while (true)
            {
                string cevap = Console.ReadLine();

                switch (cevap.ToLower())
                {
                    case "1":
                        Console.WriteLine("");
                        Console.WriteLine("***********************  Araç Sayısı  ***********************");
                        Console.WriteLine("");
                        DisplayCarCount();
                        Console.WriteLine("");
                        break;
                    case "2":
                        Console.WriteLine("");
                        Console.WriteLine("***********************  Araç Listesi  ***********************");
                        ListCars();
                        Console.WriteLine("");
                        break;
                    case "3":
                        Console.WriteLine("");
                        Console.WriteLine("************************  Araç Ekle  ************************");
                        Console.WriteLine("");
                        AddCar();
                        Console.WriteLine("");
                        break;
                        Console.WriteLine("İşlem No:");
                    case "4":
                        Console.WriteLine("");
                        Console.WriteLine("***********************  Araç Kirala  ***********************");
                        Console.WriteLine("");
                        RentCar();
                        Console.WriteLine("");
                        break;
                    case "5":
                        Console.WriteLine("");
                        Exit();
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen tekrar deneyin.");
                        break;
                }
            }
        }

        private static void ListCars()
        {
            Console.WriteLine("");
            foreach (Car car in cars)
            {
                Console.WriteLine($"Marka: {car.Marka} - Model: {car.Model} - Motor Gücü: {car.MotorGucu}");
                Console.WriteLine("");
            }
        }

        private static void DisplayCarCount()
        {
            Console.WriteLine($"Şu anki toplam araç sayısı: {cars.Count}");
        }

        private static void AddCar()
        {
            Console.Write("Markayı yazın: ");
            string marka = Console.ReadLine();

            int model = GetValidNumber("Modeli yazın: ");
            int motorGucu = GetValidNumber("Motor gücünü yazın: ");

            cars.Add(new Car { Marka = marka, Model = model, MotorGucu = motorGucu });
            Console.WriteLine("");
            Console.WriteLine("Araba başarıyla eklendi!");
            Console.WriteLine("");
            Console.WriteLine("Ana menüye dönmek için lütfen herhangi bir tuşa basınız!");

            Console.ReadKey();

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Size daha fazla nasıl yardımcı olabilirim?");
            Console.WriteLine("");

            ShowMenu();
            ProcessUserInput();

        }

        private static int GetValidNumber(string message)
        {
            int number;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    break;
                }
                Console.WriteLine("Lütfen geçerli bir sayı girin.");
            }
            return number;
        }

        private static void RentCar()
        {
            Console.WriteLine("Kiralama yapmak istediğiniz aracın numarasını seçin:");

            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Marka}");
            }

            int selectedCarIndex = GetValidNumber("Araç numarası: ") - 1;

            if (selectedCarIndex >= 0 && selectedCarIndex < cars.Count)
            {
                Console.Write("Kiralama tarihi: ");
                string kiralamaTarihi = Console.ReadLine();

                Console.Write("Kiralama saati: ");
                string kiralamaSaati = Console.ReadLine();

                Console.Write("Teslim tarihi: ");
                string teslimTarihi = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine($"{cars[selectedCarIndex].Marka} marka aracı {kiralamaTarihi} tarihinde saat {kiralamaSaati} 'te kiralamak üzere işlem yaptınız.");
                Console.WriteLine("Kiralama işleminiz tamamlanmıştır.");
                Console.WriteLine($"Teslim tarihiniz: {teslimTarihi} {kiralamaSaati} 'dır.");
                Console.WriteLine("");
                Console.WriteLine("Bilgilendirme: İlgili birimlerimize belirtmeden araç geciktirmek yasaktır. \n               İzinsiz geciktirmelerde cezai işlem uygulanmaktadır.");

                Console.WriteLine("               Ana menüye dönmek için herhangi bir tuşa basınız!");
                Console.WriteLine("");
                Console.ReadKey();

                Console.WriteLine("Sizin için yardımcı olabileceğim farklı bir işlem mevcut mudur?");
                Console.WriteLine("");
                ShowMenu();
                ProcessUserInput();

            }
            else
            {
                Console.WriteLine("Geçersiz bir araç numarası seçtiniz.");
            }
        }

        private static void Exit()
        {
            Console.WriteLine(" <<< Sizlere kaliteli hizmet vermek önceliğimizdir. Bizleri tercih ettiğiniz için teşekkür ederiz. Hoşça kalınız... >>>");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Environment.Exit(0);
        }

        public class Car
        {
            public string Marka;
            public int Model;
            public int MotorGucu;
        }
    }
}
