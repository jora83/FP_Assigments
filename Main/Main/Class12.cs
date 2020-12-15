using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Class12
    {
        public void Twelve()
        {
            int a, b, n, d=0;

            Console.WriteLine("n=");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            b = int.Parse(Console.ReadLine());

            for(int i = a; i<=b; i++)
            {
                if (i % n == 0)
                {
                    d++;
                }
            }
            Console.WriteLine($"{d} numere divizibile");
        }
    }
}
