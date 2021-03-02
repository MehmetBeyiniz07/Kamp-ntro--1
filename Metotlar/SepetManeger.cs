using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManeger
    {
        //bir metod nasıl yazılır görelim.
        public void Ekle(Urun urun) //Urun urun sonradan eklendi.
        {
            Console.WriteLine("Tebrikler. Sepete eklendi...!  : "+ urun.Adi +" ");



        }


    public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi...!?????*  : "+ urunAdi +" ");
        }

    }//syntax yazım değişimi
}
