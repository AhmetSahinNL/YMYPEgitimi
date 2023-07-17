using System.Linq;

namespace _06.Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<string> names = new();
            names.Add("Taner");
            names.Add("Tugay");
            names.Add("Tahir");
            names.Add("Toprak");
            names.Add("Türkan");
            names.Add("Seval");

            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[5]);

            //For, Foreach, While

            //for(int x 0; x < names.Count(); x++)
            //{
            //
            //  Console.WriteLine(names[x]);
            //}

            //foreach(var x in names)
            //{
            //    Console.WriteLine(x);
            //}

            //int x = 0;
            //while(names.count() > 0)
            //{
            //    x++;
            //    if (x == 5) break;
            //    Console.WriteLine("Çalışıyor!");
            //}

            for (int x = 0; x < names.Count(); x++)
            {
                if(x == 4)
                {
                    break; //bu döngüyü sonlandırır
                }

                if(x == 2)
                {
                    continue; //bu da döngüde kalan kısmı atlar.
                }
                Console.WriteLine(names[x]);
            }

            //oop içerisinde tip belirtmek zorunda olduğun için liste belirtilen tipte olmak zorunda
            //json formatı kullanıyor olsaydın listede farklı tipler olabilirdi

        }
    }
}