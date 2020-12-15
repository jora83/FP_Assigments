using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Class2
    {
        public void Two()
        {
            double a, b, c, x1, x2, d;

            Console.WriteLine("a=");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("c=");
            c = double.Parse(Console.ReadLine());

            d = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine($"delta={d}");
            x1 = ((-1*b) - Math.Sqrt(d)) / (2 * a);
            x2 = ((-1*b) + Math.Sqrt(d)) /(2 * a);

            Console.WriteLine($"x1={x1}");
            Console.WriteLine($"x2={x2}");

        }
    }
}
