using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 = ? == 30


            int[] sayilar = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 1000, 2000, 3000 };

            sayilar = sayilar2;
            sayilar2[0] = 999;
            // sayilar[0] = ? 999

            // int, decimal, string, double, float == değer tipleri
            // class, arrays, interface == referans tipler
            // bellekte 2 tane yer ver--> STACK  HEAP(new komutu sayesinde alan oluşur adrese sahip)
            // değer tipleri anlik, referans tipler ise kalıcı olur.
            // eğer referans tipleri eşitlersen ikisi de tamamen aynı adreste olur.

        }
    }
}
