using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kursu";
            string kurs2 = "Programlamaya Başlangıç";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            //array - dizi nasıl tanımlanır?
//--------------------------------------------------------------------------------------------------------------------------------------
            string[] kurslar = new string[] { "c#","python","Java", "Yazılım Geliştirici Kursu", "Programlamaya Başlangıç"  };
            

            for (int i = 1; i < 10; i+=2)//i=i+2 i yi 2 2 arttır demek.
            {
                Console.WriteLine(i);
            }
//---------------------------------------------------------------------------------------------------------------------------
            for (int i = 0; i <4; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("Sayfa Sonu - footer");
//----------------------------------------------------------------------------------------------------------------------------
            for (int i = 0; i <kurslar.Length; i++)// lenght ne kadar eleman varsa yazdır demektir.
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
//-----------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Sayfa Sonu - footer");

            foreach (string kurs in kurslar)//kurs kısmına abc falan filan yazsan farketmez
            {
                Console.WriteLine(kurs);//dizi temelli yapıları tek tek döndürmeye yarar kursları tek tek dolaş demek
            }

            Console.WriteLine("foreach bitti");
//----------------------------------------------------------------------------------------------------------------------------













            Console.ReadLine();
        }
    }
}
