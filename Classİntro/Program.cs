using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Mehmet";
            int yas = 36;
         
            //Kurs kurs1;//

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C# : ";
            kurs1.izlenmeOrani = 68;
            kurs1.Egitmen = "Engin Demirog";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C# : ";
            kurs2.izlenmeOrani = 68;
            kurs2.Egitmen = "Engin Demirog";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "java : ";
            kurs3.izlenmeOrani = 64;
            kurs3.Egitmen = "mehmet";

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "python : ";
            kurs4.izlenmeOrani = 63;
            kurs4.Egitmen = "Anıl bey : ";

            //Console.WriteLine(kurs2.KursAdi + " " + kurs2.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3,kurs4 };
            foreach (var kurs in kurslar)//kurs takma isim
            {
                Console.WriteLine(kurs.KursAdi);
            }


        }


    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }




    }
}
