using System;

namespace Ödev6
{
    class Program
    {
        static void Main(string[] args)

        {

            urun Urun1 = new urun();
            Urun1.UrunAdi = "elma";
            urun Urun2 = new urun    ();
            Urun2.UrunAdi = "armut";
            urun Urun3 = new urun();
            Urun3.UrunAdi = "portakal";

            urun[] urunler = new urun[] { Urun1, Urun2, Urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi);
            }
            //-------------------------------------------------------------------------------------------------
            //  for (int i = 0; i < urunler; i++)
            //{
            //    Console.WriteLine(urunler[i].UrunAdi);           For Döngüsünü kapattım çünkü while döngüsü ile çakışıyor.
            //}
            //Console.WriteLine("for bitti");

            //------------------------------------------------------------------------------------------------------

            int i = 0;
            while (i < urunler.Length)
            {
                Console.WriteLine(urunler[i].UrunAdi);
                i++;
            }


        }

    }
    class urun
    {
        public string UrunAdi { get; set; }



    }
}
