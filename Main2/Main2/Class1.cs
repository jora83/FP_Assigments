using System;
using System.Collections.Generic;
using System.Text;

namespace Main2
{
    class Class1
    {
        public void One()
        {
            int n, a, nrpare=0;

            Console.WriteLine("n=");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    nrpare++;
                }
                n--;
            }

            Console.WriteLine($"exista {nrpare} numere pare in secventa");
        }
    }
}
