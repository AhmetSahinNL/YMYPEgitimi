using System;
using System.Collections.Generic;

namespace OgrenciYoklama
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>
            {
                "Ali Yılmaz",
                "Ayşe Demir",
                "Mehmet Kara",
                // Diğer öğrencileri burada ekleyin
            };

            Console.WriteLine("Öğrenci Listesi:");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nYoklama Al (geldi/gelmedi):");
            foreach (string student in students)
            {
                Console.Write($"{student}: ");
                string attendance = Console.ReadLine().ToLower();

                if (attendance == "geldi")
                {
                    Console.WriteLine("Geldi.");
                }
                else if (attendance == "gelmedi")
                {
                    Console.WriteLine("Gelmedi.");
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş! 'geldi' veya 'gelmedi' olarak girin.");

                }
            }

            Console.WriteLine("\nYoklama tamamlandı!");
            
        }
    }
}
