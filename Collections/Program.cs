using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Ahmet", "Hamza", "Furkan" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            isimler = new string[5]; // isimlerin adresi 
            //esittir yeni adres, artık ilk listeden ap ayrı bir yerde tutuluyor.
            isimler[4] = "Ahmet";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[1]);

            // using ile eklenip kullanılır
            List<string> isimler2 = new List<string> {"Hamza", "Furkan", "Gökhan", "Halil" };
            //list koleksiyonu sayesinde bellekteki yer kaybolmadan listemizle işlem yapılabilir.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Ali");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[3]);

        }
    }
}
