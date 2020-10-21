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

            shop.orange.Add(o1);
            shop.orange.Add(o2);
            shop.orange.Add(o3);


            Console.ReadKey();

        }
    }
}
