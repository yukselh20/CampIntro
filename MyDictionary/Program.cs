﻿using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> sehirler = new Dictionary<int, string>();
            sehirler.Add(18, "Ankara");
            Console.WriteLine(sehirler[18]);


            MyDictionary<int, string> sehirler2 = new MyDictionary<int, string>();
            sehirler2.Add(1, "İstanbul");
            sehirler2.Add(2, "Isparta");
            

        }
    }
}
