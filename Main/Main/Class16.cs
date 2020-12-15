using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Class16
    {
        public void Sixteen()
        {
            int a, b, c;

            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("c=");
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (b > c)
                {
                    Console.WriteLine($"{a}, {b}, {c}");
                }
            }
            if (a > c)
            {
                if (c > b)
                {
                    Console.WriteLine($"{a}, {c}, {b}");
                }
            }

            if (b > a)
            {
                if (a > c)
                {
                    Console.WriteLine($"{b},{a}, {c}");
                }
            }
            if (b > c)
            {
                if (c > a)
                {
                    Console.WriteLine($"{b}, {c}, {a}");
                }
            }

            if (c > a)
            {
                if (a > b)
                {
                    Console.WriteLine($"{c}, {a}, {b}");
                }
            }
            if (c > b)
            {
                if (b > a)
                {
                    Console.WriteLine($"{c}, {b}, {a}");
                }
            }

        }
    }
}
