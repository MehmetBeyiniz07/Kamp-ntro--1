using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string urunAdi = "Elma";
            //double Fiyati = 15;
            //String aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "sulu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("....................................................");

            }//program.cs c#tan geldiğini söyler.
            Console.WriteLine("---------------Metotlar---------------");

            //instance  Örnek
            //encapsulation
            
            SepetManeger sepetManeger = new SepetManeger();
            sepetManeger.Ekle(urun1);
            sepetManeger.Ekle(urun2);
            sepetManeger.Ekle2("armut", "yeşil armut", 12, 50);
            sepetManeger.Ekle2("portakal", "yeşil", 10, 60);
            sepetManeger.Ekle2("elma", "yeşil elma", 14, 70);// sırasıyla urun adi aciklama double sayısını fiyatını yazıyoruz

            //metot tekrar tekrar kullanabilme seçeneği verdi.
            


        }
    }
}
// tekrar tekrar kullanabilirliği sağlayan kod bloğu dont repeat yourself -DRY  tekrar etme kendini