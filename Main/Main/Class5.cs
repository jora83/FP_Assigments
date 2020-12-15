using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Class5
    {
        public void Five()
        {
            int n, k, r;
            Console.WriteLine("Introduceti numarul:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a k-a cifra pe care dorit sa o extrageti:");
            k = int.Parse(Console.ReadLine());

            for(int i=2; i <= k; i++)
            {
                n = n / 10;
            }
            r = n % 10;
            Console.WriteLine($"Rezultatul:{r}");
        }
    }
}
