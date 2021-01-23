using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> products = new MyDictionary<int, string>();

            products.Add(1, "Kalem");
            products.Add(2, "Kulaklık");
            products.Add(3, "Masa");
            products.Add(4, "Saat");

            products.GetProducts();
        }
    }
}
