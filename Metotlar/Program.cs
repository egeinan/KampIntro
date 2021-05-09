using System;

namespace Metotlar
{
    class Program
    { 
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Çilek";
            urun1.Fiyat = 10;
            urun1.Aciklama = "çilekks";


            Urun urun2 = new Urun();
            urun2.Adi = "Muz";
            urun2.Fiyat = 12;
            urun2.Aciklama = "amazon muz";
            
            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------\n\n\n");
            }


            Console.WriteLine("----------Metotlar-------\n\n");
            
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);




        }
    }
}
