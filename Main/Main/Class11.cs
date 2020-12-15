using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Class11
    {
        public void Eleven()
        {
            int n, o=0;

            Console.WriteLine("n=");
            n = int.Parse(Console.ReadLine());
            
            while(n!=0)
            {
                o = o + n % 10;
                o = o * 10;
                n = n / 10;
            }
            o = o / 10;
            Console.WriteLine($"Numarul in ordine inversa:{o}");
        }
    }
}
