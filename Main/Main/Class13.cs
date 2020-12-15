using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Class13
    {
        public void Thirteen()
        {
            int y1, y2, nr=0,b;

            Console.WriteLine("y1=");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("y2=");
            y2 = int.Parse(Console.ReadLine());

            if(y1 % 4 == 0)
            {
                nr = 1;
            }

            b = ((y2 - y1) / 4);
            nr = nr + b;

            Console.WriteLine($"intre anii {y1} si {y2} exista {nr} ani bisecti");
        }
    }
}
