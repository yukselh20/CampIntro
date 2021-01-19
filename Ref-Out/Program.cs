using System;

class Program
{

    static void Main()
    {

        int sayimiz = 3;
        Console.WriteLine("Başlangıç değeri: {0}", sayimiz);
        Kare(sayimiz);
        Console.WriteLine("Kare() sonrası: {0}", sayimiz);
        Kare2(ref sayimiz);
        Console.WriteLine("Kare2() sonrası: {0}", sayimiz);
    }

    static void Kare(int sayi)
    {
        sayi = sayi * sayi;
    }

    static void Kare2(ref int sayi)
    {
        sayi = sayi * sayi;
    }
}