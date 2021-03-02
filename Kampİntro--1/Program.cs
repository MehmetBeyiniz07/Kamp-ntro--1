using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kampİntro__1
{
    class Program
    {
        public static bool True { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 1.45;
            double dolarBugun = 1.55;
//-----------------------------------------------------------------------------------------------------------------
            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Dolar azaldı");
            }
            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Dolar Yükseldi");
            }
            else
            {
                Console.WriteLine("Dolar Değişmedi");
            } 
//----------------------------------------------------------------------------------------------------------------------


            if (sistemeGirisYapmismi == true)// tababasarak2kereififtamamlar
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }



//------------------------------------------------------------------------------------------------------------------------


            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);


            Console.ReadLine();
        }
    }
}
