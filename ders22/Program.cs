using System;

namespace ders22
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();//parantez açınce ne tür bir veriyi döndürecez diye soruyor
            Add2(20, 30);
       
            var result = Add2(20 , 30);//result bir int o yüzden result olur
            Console.WriteLine(result);


            Console.ReadLine();




        }
          static void Add()
        {
            Console.WriteLine("added!!");
        }
        static int Add2(int number1, int number2)// void giy onu yap git bunu yap demek o yüzden olmaz int dersek ne tür bir veriyi döndürmek istiyorsak o tipi yazıyoruz.

        {
            
            var result = number1 + number2;
            return result;
        }
    }
}
