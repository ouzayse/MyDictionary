using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TValue, TKey>
    {
        TValue[] values;
        TKey[] keys;
        public MyDictionary() 
        {
            values = new TValue[0];
            keys = new TKey[0];
        }
        public void Add(TValue value, TKey key)
        {
            TValue[] tempValues = values;
            TKey[] tempKeys = keys;

            values = new TValue[values.Length + 1];
            keys = new TKey[keys.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                values[i] = tempValues[i];
                keys[i] = tempKeys[i];
            }
            values[values.Length - 1] = value;
            keys[keys.Length - 1] = key;
        }
        public void GetProducts()
        {

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i] + " : " + keys[i] + "  ürünü sisteme eklendi.");
            }

        }
    }
}
