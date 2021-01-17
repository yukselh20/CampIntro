using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        // naming convention
        // syntax
        public void Ekle(Urun urun) // Urun int string gibi bir veri tipidir. urun ise
                                    // kod bloğunun içeriğinde kullanacağımız atanan değerdir.
        {
            Console.WriteLine("Ürün sepete eklendi, " + urun.Adi );
        }

        // bir class içinde birden fazla metod olabilir.
        public void Ekle2()
        {

        }
    }
}
