using System;

namespace ders24
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;//outta değer atamadan çalışır refte çalışmaz aşağıda satatic intte tanımlanan number yukarda iş görmez 
            int number2 = 100;
            var result2 = Add3(number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.ReadLine();




        }


        static int Add3(int number1 , int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
                static int Add3(int number1 , int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    } 
}
