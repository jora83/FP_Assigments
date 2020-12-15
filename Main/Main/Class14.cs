using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Class14
    {
        public void Fourteen()
        {
            int n, o = 0,p;

            Console.WriteLine("n=");
            n = int.Parse(Console.ReadLine());
            p = n;
            while (n != 0)
            {
                o = o + n % 10;
                o = o * 10;
                n = n / 10;
            }
            o = o / 10;

            if (p == o)
            {
                Console.WriteLine($"{p} este palindrom");
            }
            else
            {
                Console.WriteLine($"{p} nu este palindrom");
            }
        }
    }
}
