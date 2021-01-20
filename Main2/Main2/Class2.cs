using System;
using System.Collections.Generic;
using System.Text;

namespace Main2
{
    class Class2
    {
        public void Two()
        {
            int n, a, nrnegative=0, nrpare=0, nr0=0, nrpozitive=0;

            Console.WriteLine("lungimea secventei=");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                a = int.Parse(Console.ReadLine());

                if (a < 0) nrnegative++;
            
                if (a % 2 == 0) nrpare++;
               
                if (a == 0) nr0++;

                if (a > 0) nrpozitive++;

                n--;
            }
            Console.WriteLine("in secvanta data exista:");
            Console.WriteLine($"{nrnegative} numere negative");
            Console.WriteLine($"{nrpare} numere pare");
            Console.WriteLine($"{nr0} numere care sunt 0");
            Console.WriteLine($"{nrpozitive} numere pozitive");
        }
    }
}
