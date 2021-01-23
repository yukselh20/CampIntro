using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // t yerine her tip geçebilir. str float int.
    {
        T[] items;
        //constructor
        public MyList() // clasını newlediğin zaman otomatik çalışır. T[] items; i newlemek
            // gerektiği için constructor yapısını kullanırız.
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //Referans numarası yenilendikçe kaybolmaz.
            items = new T[items.Length + 1]; // burda arrayi newledikten sonra referans numarası sıfırlanır.
                                             // Ekleme işlemi gerçekleşmez.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //Emanetleri geçici tutulan itemleri geri aldık.
            }

            items[items.Length - 1] = item; //items arrayinin son elemanı gelen item değeridir.
        }
    }
}
