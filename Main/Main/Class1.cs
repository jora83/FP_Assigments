using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Class1
    {
        public void One()
        {
            float a, b, x;

            Console.WriteLine("a=");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            b = float.Parse(Console.ReadLine());

            if (a == 0 && b == 0)
            {
                Console.WriteLine("x apartine multimii numerelor rationale");
                return;
            }
            if (a == 0 && b != 0)
            {
                Console.WriteLine("Ecuatia nu poate fi rezolvata");
                return;
            }
            if (a != 0 && b == 0)
            {
                Console.WriteLine("x=0");
                return;
            }
            if (a != 0 && b != 0)
            {
                x = -b / a;
                Console.WriteLine($"x={x}");
                return;
            }
        }
    }
}
