using System;
using System.Collections.Generic;
using System.Text;

namespace Main2
{
    class Class5
    {
        public void Five()
        {
            int n, a, poz = 0, nrelem = 0 ;

            Console.WriteLine("lungimea secventei=");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                a = int.Parse(Console.ReadLine());
                if (a == poz)
                {
                    nrelem++;
                }
                n--;
                poz++;
            }

            Console.WriteLine($"exista {nrelem} numere care sunt egale cu pozitia lor");
        }
    }
}
