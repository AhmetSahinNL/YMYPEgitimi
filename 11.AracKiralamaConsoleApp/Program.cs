using System;
using System.Collections.Generic;

namespace _11.ArabalarConsoleApp
{
    internal class Program
    {
        private static List<Car> cars = new List<Car>
        {
            new Car { Marka = "BMW", Model = 2020, MotorGucu = 5000 }
            new Car { Marka = "Ferrari", Model = 2022, MotorGucu = 8000 }
            new Car { Marka = "Lamborghini", Model = 2021, MotorGucu = 6500 }
            new Car { Marka = "Porsche", Model = 2023, MotorGucu = 6800 }
        };

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

            cars.Add(new Car { Marka = marka, Model = model, MotorGucu = motorGucu });
            Console.WriteLine("Araba başarıyla eklendi!");
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
            // Kiralama işlemleri burada yer alacak
        }

        private static void Exit()
        {
            Console.WriteLine("Ziyaretiniz için teşekkürler. Tekrar görüşmek üzere.");
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
