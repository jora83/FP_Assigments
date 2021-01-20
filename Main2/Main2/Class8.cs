using System;
using System.Collections.Generic;
using System.Text;

namespace Main2
{
    class Class8
    {
        public void Eight()
        {
            int n, f;

            Console.WriteLine("introduceti al n-ulea numar ");
            n = int.Parse(Console.ReadLine());

            f = (n - 1) + (n - 2);
            Console.WriteLine(f);
        }   
    }
}
