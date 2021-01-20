using System;
using System.Collections.Generic;
using System.Text;

namespace Main2
{
    class Class7
    {
       

        public void Seven()
        {
            int n, a, min = int.MaxValue, max = int.MinValue;

            Console.WriteLine("introduceti lungimea secventei");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                a = int.Parse(Console.ReadLine());
                if (a < min)
                {
                    min = a;
                }
                if (a > max)
                {
                    max = a;
                }
                n--;
            }

            Console.WriteLine($"minimul = {min}");
            Console.WriteLine($"maximul = {max}");


        }

           
    }
}
