using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Class7
    {
        public void Seven()
        {
            int a, b, aux;

            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            b = int.Parse(Console.ReadLine());

            aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");


        }
    }
}
