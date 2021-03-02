using System;

namespace while_döngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("Merhaba Dünya");
                i++;
            }
            Console.ReadKey();
            //------------------------------------------------------------------
            Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            while (sayi >= 0)
            {
                Console.WriteLine(sayi);
                System.Threading.Thread.Sleep(1000);
                sayi--;
            }
            Console.ReadKey();
        }
    }
}
