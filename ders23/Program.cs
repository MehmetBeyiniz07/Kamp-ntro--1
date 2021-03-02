
using System;
namespace ders23
{
    class Program
    {
        static void Main(string[] args)
        {

            Add();
            

            var result = Add2(20); //result bir int o yüzden result olur
            Add2(20, 30);
            Console.WriteLine(result);


        }
        static void Add()
        {
            Console.WriteLine("added!!");
        }
        static int Add2(int number1, int number2 = 20) //burada default değer 30 atanırsa number 2 ne mi olur yukarda
        {//number1 e default değer 20 atarsak olmaz çünkü defult değerler her zaman sonda olmalı sondan geriye doğru default değerli verirsek hiçbir sıkıntı çıkmaz

            var result = number1 + number2;
            return result;
        }
    }
}
