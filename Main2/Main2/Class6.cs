using System;
using System.Collections.Generic;
using System.Text;

namespace Main2
{
    class Class6
    {
        public void Six()
        {
            int n, a, cresc=0;
            bool crescator = false, crescatorr = true;

            Console.WriteLine("introduceti lungimea secventei");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                a = int.Parse(Console.ReadLine());
                if (a-1==cresc)
                {
                    crescator = true;
                }
                else
                {
                    crescator = false;
                    crescatorr = false;
                }
                cresc = a;
                n--;
            }

            if (crescatorr==true)
            {
                Console.WriteLine("numerele din secventa  sunt crescatoare");
            }
            else
            {
                Console.WriteLine("numerele din secventa nu sunt crescatoare");
            }

        }
    }
}
