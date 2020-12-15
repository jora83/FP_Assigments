using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Class8
    {
        public void Eight()
        {
            int a, b;
            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
        }
    }
}
