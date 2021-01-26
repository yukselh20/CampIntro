using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Dictionary yapısı Key ve Value ikilisinden oluşmaktadır.
            Key lerin her birisi özeldir tek bir değer tutar.
            Her bir key yapısı bir "value" yani bir değere karşılık gelmektedir.
            Kullanıcı key değerini girdiğinde ona karşılık gelen değeri alır.
            Key yapısı str,int vs olabilir.
             */


            MyDictionary<string, int> nameAge = new MyDictionary<string, int>();
            nameAge.Add("Hamza", 19);
            nameAge.Add("Fatih", 22);
            nameAge.Add("Mehmet", 30);
            nameAge.Add("Ömer", 15);

        }
    }
}
