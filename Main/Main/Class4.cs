using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Class4
    {
        public void Four()
        {
            int y;

            Console.WriteLine("y=");
            y = int.Parse(Console.ReadLine());

            if (y % 4 == 0)
            {
                Console.WriteLine($"Anul {y} este bisect");
            }
            else
            {
                Console.WriteLine($"Anul {y} nu este bisect");
            }
        }
    }
}
