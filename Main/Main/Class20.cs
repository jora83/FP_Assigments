using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Class20
    {
        public void Twenty()
        {
            float m, n, r,rr, p, b=0, per;

            Console.WriteLine("m=");
            m = float.Parse(Console.ReadLine());
            Console.WriteLine("n=");
            n = float.Parse(Console.ReadLine());
            r = m / n;
            r = r / 10;
            rr = r;
            do
            {
                p = rr % 10;
                rr = rr / 10;
                Console.WriteLine($"p{p}  rr{rr}");
                if (p == rr)
                {
                    b++;
                    Console.WriteLine(b);
                }
            } while (rr != 0 && p == rr % 10);

            if (b > 4)
            {
                Console.WriteLine($"{m}/{n}={r}({p})");
                return;
            }
            Console.WriteLine($"{m}/{n}={r}");

        }
    }
}
