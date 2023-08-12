using System;
using System.Collections.Generic;

namespace _11.ArabalarConsoleApp
{
    internal class Program
    {
        private static List<Car> cars = new List<Car>();

        private static void Main(string[] args)
        {
            Console.WriteLine("Araba Yapay Zekasına Hoş Geldiniz!");
            Console.WriteLine("Size nasıl yardımcı olabilirim?");
            ShowMenu();
            ProcessUserInput();
        }

        private static void ShowMenu()
        {
            Console.WriteLine("İşlem Listesi");
            Console.WriteLine("1- Araç Listesi");
            Console.WriteLine("2- Araç Sayısı");
            Console.WriteLine("3- Araç Ekle");
            Console.WriteLine("4- Listeyi Göster");
            Console.WriteLine("5- Araç Kirala");
            Console.WriteLine("6- Çıkış");
        }

        private static void ProcessUserInput()
        {
            while (true)
            {
                string cevap = Console.ReadLine();

                switch (cevap.ToLower())
                {
                    case "1":
                        ListCars();
                        break;
                    case "2":
                        DisplayCarCount();
                        break;
                    case "3":
                        AddCar();
                        break;
                    case "4":
                        ShowMenu();
                        break;
                    case "5":
                        RentCar();
                        break;
                    case "6":
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen tekrar deneyin.");
                        break;
                }
            }
        }

        private static void ListCars()
        {
            Console.WriteLine("Araç Listesi:");
            foreach (Car car in cars)
            {
                Console.WriteLine($"Marka: {car.Marka} - Model: {car.Model} - Motor Gücü: {car.MotorGucu}");
            }
        }

        private static void DisplayCarCount()
        {
            Console.WriteLine($"Toplam araç sayısı: {cars.Count}");
        }

        private static void AddCar()
        {
            Console.Write("Markayı yazın: ");
            string marka = Console.ReadLine();

            int model = GetValidNumber("Modeli yazın: ");
            int motorGucu = GetValidNumber("Motor gücünü yazın: ");

            cars.Add(new Car() { Marka = marka, Model = model, MotorGucu = motorGucu });
            Console.WriteLine("Arabanız başarıyla eklenmiştir!");
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
            Console.WriteLine("Kiralamak istediğiniz aracın numarasını seçin:");

            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Marka}");
            }

            int selectedCarIndex = GetValidNumber("Araç numarası: ") - 1;

            if (selectedCarIndex >= 0 && selectedCarIndex < cars.Count)
            {
                Console.WriteLine("Kiralama tarihi: ");
                string kiralamaTarihi = Console.ReadLine();
                Console.WriteLine("Kiralama saati: ");
                string kiralamaSaati = Console.ReadLine();
                Console.WriteLine("Teslim tarihi: ");
                string teslimTarihi = Console.ReadLine();

                Console.WriteLine($"{cars[selectedCarIndex].Marka} marka aracını {kiralamaTarihi} {kiralamaSaati} tarihinde kiralamak üzere işlem yaptınız. Teslim tarihiniz:");
                Console.WriteLine($"Teslim tarihiniz: {teslimTarihi} {kiralamaSaati}.");
                Console.WriteLine("Aracı zamanında teslim etmezseniz cezai işlem uygulanacaktır.");
                Console.WriteLine("Bizi tercih ettiğiniz için teşekkürler (-_-)");
            }
            else
            {
                Console.WriteLine("Geçersiz bir araç numarası seçtiniz.");
            }
        }

        private static void Exit()
        {
            Console.WriteLine("Ziyaretiniz için teşekkürler. Tekrar görüşmek üzere.");
            Environment.Exit(0);
        }
    }

    public class Car
    {
        public string Marka;
        public int Model;
        public int MotorGucu;
    }
}
