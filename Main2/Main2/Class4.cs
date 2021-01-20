using System;
using System.Collections.Generic;
using System.Text;

namespace Main2
{
    class Class4
    {
        public void Four()
        {
            int n, nr=1, a, poz=0;

            Console.WriteLine("lungimea secventei:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("a=");
            a = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                nr = int.Parse(Console.ReadLine());
               
                if (nr == a)
                {
                    n = 0;
                }
                poz++;
            }

            if (nr == a)
            {
                Console.WriteLine($"pozitia pe care se alfa numarul {a} este {poz}");
            }
            else
            {
                Console.WriteLine($"pozitia pe care se alfa numarul {a} este -1");
            }
            
        }
    }
}
