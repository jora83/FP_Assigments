using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Class10
    {
        public void Ten()
        {
            int n;

            Console.WriteLine("n=");
            n = int.Parse(Console.ReadLine());

            if(n == 1 || n == 0)
            {
                Console.WriteLine($"{n} nu este un numar prim");
                return;
            }
            else
            {
                for(int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0) 
                    {
                        Console.WriteLine($"{n} nu este un numar prim");
                        return;
                    }
                }
            }
            Console.WriteLine($"{n} este un numar prim");
        }
    }
}
