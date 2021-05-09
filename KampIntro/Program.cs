using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety- tip güvenliği
            // Do not repeat yourself.
            // değer tutucu, nickname --> kategoriEtiketi

            string kategoriEtiketi = "Kategori"; 
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemegirisyapmismi = true; // or false
            double dolarBugun = 8.20;
            double dolarYarin = 8.29;

            if (dolarBugun > dolarYarin)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarBugun < dolarYarin)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmez butonu");
            }


            if (sistemegirisyapmismi == false)
            {
                Console.WriteLine("Kullanıcı ayarları paneli");
            }
            else
            {
                Console.WriteLine("Giriş yapın");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
