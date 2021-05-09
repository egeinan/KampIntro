using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "c kampı";
            string kurs2 = "java kampı";
            string kurs3 = "python kampı";

            string [] kurslar = new string[] {"c kampı", "java kampı",
            "python kampı"};

            
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for olan bitti\n");

            foreach (string kurs in kurslar)  // dizileri kendi içinde döndürür.
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu");




        }
    }
}
