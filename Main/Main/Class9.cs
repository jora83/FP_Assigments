using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Class9
    {
        public void Nine()
        {
            int n, d=2;

            Console.WriteLine("n=");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i<=n; i++)
            {
                if(n%d == 0)
                {
                    Console.WriteLine(d);
                }
                d++;
            }
        }
    }
}
