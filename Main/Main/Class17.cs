using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Class17
    {
        public void Seventeen()
        {
            int a, b, r;

            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            b = int.Parse(Console.ReadLine());

            r = a % b;
            while(r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            Console.WriteLine($"{b}");
        }
    }
}
