using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Class21
    {
        int n, x = 102;
        bool g = false, gg=false, pass= false;
        string da = "da", nu = "nu", r;

        public void Twentyone()
        {
           
            do
            {
                Console.WriteLine("alegeti un numar intre 1 si 1024");
                n = int.Parse(Console.ReadLine());
                if (n < 1 || n > 1024)
                {
                    Console.WriteLine("numarul introdus este gresit");
                    Console.WriteLine("");
                }
            }
            while (n < 1 || n > 1024);

            hundreedtohundreeed();

            



        }


        private void hundreedtohundreeed()
        {
            while (g == false)
            {
                Console.WriteLine($"numarul este mai mare sau egal decat {x}?");
                r = Console.ReadLine();
                if (r == da)
                {
                    x =x + 102;
                }
                if (r == nu)
                {
                    x = x - 10;
                    tentoten();
                    g = true;
                }

            }
        }

        private void tentoten()
        {
            while (gg == false)
            {
                Console.WriteLine($"numarul este mai mare sau egal decat {x}?");
                r = Console.ReadLine();
                if (pass == true)
                {
                    onetoone();
                    gg = true;
                }
                if (r == da)
                {
                    x = x + 10;
                }
                if (r == nu)
                {
                    x = x - 10;
                    pass = true;
                }
               

            }
        }

        private void onetoone()
        {
            Console.WriteLine($"nnnnnnumarul este mai mare sau egal decat {x}?");
            r = Console.ReadLine();
            if (r == da)
            {
                x = x + 1;
            }

        }

    }
  
}
