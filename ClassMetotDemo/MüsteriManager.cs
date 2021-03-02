using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MüsteriManager
    {

        public void Ekle(Müsteri müsteri) 
        {
            Console.WriteLine(müsteri.MüsteriAdi + " Kullanıcı Adlı Müşteri Eklendi...!  :   ");



        }

        public void Sil(Müsteri müsteri )
        {
            Console.WriteLine(  müsteri.MüsteriAdi   +" Kullanıcı Adlı Müşteri Silindi...!  :   ");
        }
    }

}
