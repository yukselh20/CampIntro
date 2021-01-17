using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 3.5;
            urun1.Aciklamasi = "Amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 55;
            urun2.Aciklamasi = "Diyarbakır karpuzu";


            Urun[] urunler = new Urun[] {urun1,urun2 };  // class arrayi. datadan gelen verileri diziye atılır.


            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklamasi);
                Console.WriteLine("*****************************************************");
            }

            Console.WriteLine("---------------Metodlar----------------");


            SepetManager sepetmanager = new SepetManager();

            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);


            DortIslem dortIslem = new DortIslem();

            dortIslem.Topla(10, 145789);

        }
    }
}

// Tekrar tekrar kullanılabilir komut blokları. 