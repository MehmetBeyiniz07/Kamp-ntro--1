using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Müsteri müsteri1 = new Müsteri();

            müsteri1.MüsteriAdi = "Ahmet";
            müsteri1.MüsteriSoyadi = "koç";
            müsteri1.MüsteriYasi = 20;

         

            Müsteri müsteri2 = new Müsteri();

            müsteri2.MüsteriAdi = "Mehmet";
            müsteri2.MüsteriSoyadi = "kol";
            müsteri2.MüsteriYasi = 30;

            Müsteri[] müsteriler = new Müsteri[] { müsteri1, müsteri2 };

            foreach(Müsteri müsteri in müsteriler)
            {
                Console.WriteLine(müsteri.MüsteriAdi);
                Console.WriteLine(müsteri.MüsteriSoyadi);
                Console.WriteLine(müsteri.MüsteriYasi);
            }

            MüsteriManager müsteriekle = new MüsteriManager();
            müsteriekle.Ekle(müsteri2);

            MüsteriManager müsteriSil = new MüsteriManager();
            müsteriSil.Sil(müsteri2);


        }
 
    }
}
