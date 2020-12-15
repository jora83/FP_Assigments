using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Class19
    {
        public void Nineteen()
        {
            int n, nn, a=38, b=37, a1, b1;
            bool bol = true, v = true ;

            Console.WriteLine("n=");
            n = int.Parse(Console.ReadLine());
            nn = n;

            while (bol == true)
            {
                a = n % 10;
                n = n / 10;
                if (n % 10 != a)
                {
                    b = n % 10;
                    bol = false;
                }
               
                Console.WriteLine($"a={a}, b={b}");
            }

            n = nn;
            
            while (n != 0)
            {
                if(n % 10 == a || n % 10 == b)
                {
                    v = true;
                }
                else
                {
                    v = false;
                    n = 0;
                    Console.WriteLine($"{nn} nu este format din doua cifre care se repeta");
                    return;
                }
                n = n / 10;
            }

            if (v == true)
            {
                Console.WriteLine($"{nn} este format din doua cifre care se repeta");
            }
        }
    }
}
