using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        //property= özellikler = aşağıdaki ürünün özelliği gibi
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public String Aciklama { get; set; }
        public int stokAdedi { get; set; }
        //manager data acces bunlar bir operasyon tutuyor anlamına gelir. 

    }
}
