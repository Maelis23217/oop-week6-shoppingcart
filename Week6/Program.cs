using System;
using System.Collections.Generic;
using System.Collections;

namespace Week6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Shopping_Cart shop = new Shopping_Cart();

            Orange o1 = new Orange();
            Orange o2 = new Orange();
            Orange o3 = new Orange();
            Apple a1 = new Apple();
            Apple a2 = new Apple();
            Apple a3 = new Apple();

            shop.oranges.Add(o1);
            shop.oranges.Add(o2);
            shop.oranges.Add(o3);

            shop.apples.Add(o1);
            shop.apples.Add(o2);
            shop.apples.Add(o3);

            Console.ReadKey();

        }
    }
}
