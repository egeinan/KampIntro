using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ege";

            int yas = 24;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Ogrenci = "Ege";
            kurs1.DevamOrani = 100;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Ogrenci = "Eray";
            kurs2.DevamOrani = 100;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Ogrenci = "Erkan";
            kurs3.DevamOrani = 100;


            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Ogrenci + " " + kurs1.DevamOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Ogrenci);
            }
             

        }
    }
}


class Kurs
{


    public string KursAdi { get; set; }
    public string Ogrenci { get; set; }
    public int DevamOrani { get; set; }

}