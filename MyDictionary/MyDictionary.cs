using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Key,Value>
    {
        Key[] keys;
        Value[] values;
        Key[] tempKeyTypes;
        Value[] tempValueTypes;

        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }

        public void Add(Key key, Value value)
        {
            tempKeyTypes = keys;
            tempValueTypes = values;

            keys = new Key[keys.Length+1];
            values = new Value[values.Length + 1];

            for (int i = 0; i < tempValueTypes.Length; i++)
            {
                keys[i] = tempKeyTypes[i];
                values[i] = tempValueTypes[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

            Console.WriteLine("Item : " + value + " added.");
        }

    }
}
