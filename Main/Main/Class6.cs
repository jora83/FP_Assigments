using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Class6
    {
        public void Six()
        {
            uint a, b, c;

            Console.WriteLine("Introduceti lungimile laturilor");
            Console.WriteLine("a=");
            a = uint.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            b = uint.Parse(Console.ReadLine());
            Console.WriteLine("c=");
            c = uint.Parse(Console.ReadLine());

            if(a+b > c)
            {
                if(a + c > b)
                {
                    if(b + c > a)
                    {
                        Console.WriteLine("Laturile pot forma un triunghi");
                    }
                }
            }
            else
            {
                Console.WriteLine("Laturile nu pot forma un triunghi");
            }

        }
    }
}
