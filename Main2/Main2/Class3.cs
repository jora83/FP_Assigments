using System;
using System.Collections.Generic;
using System.Text;

namespace Main2
{
    class Class3
    {
        public void Three()
        {
            int n, a=1, suma=1, produs=1;

            Console.WriteLine("introduceti numarul");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                suma = suma + a;
                produs = produs * a;
                a++;
                n--;
            }
            Console.WriteLine($"suma={suma}");
            Console.WriteLine($"produs={produs}");
        }
    }
}
