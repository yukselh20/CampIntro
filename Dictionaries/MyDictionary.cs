using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionaries
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] tempArray = keys;
            V[] tempArray1 = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];


            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = keys[i];
            }

            for (int i = 0; i < tempArray1.Length; i++)
            {
                tempArray1[i] = values[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

    }

    
}
