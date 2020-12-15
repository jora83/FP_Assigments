using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Class3
    {
        public void Three()
        {
            int n, k;

            Console.WriteLine("n=");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("k=");
            k = int.Parse(Console.ReadLine());

            if (n % k == 0)
            {
                Console.WriteLine("n se divide cu k");
            }
            else
            {
                Console.WriteLine("n nu se divide cu k");
            }

        }
    }
}
