using Microsoft.Win32.SafeHandles;
using System;
using System.Dynamic;
using Main;
using System.Timers;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            int p;
            
            Console.WriteLine("1.Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. ");
            Console.WriteLine("2.Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. ");
            Console.WriteLine("3.Determinati daca n se divide cu k, unde n si k sunt date de intrare. ");
            Console.WriteLine("4.Detreminati daca un an y este an bisect.");
            Console.WriteLine("5.Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. ");
            Console.WriteLine("6.Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. ");
            Console.WriteLine("7.(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. ");
            Console.WriteLine("8.(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.   ");
            Console.WriteLine("9.Afisati toti divizorii numarului n. ");
            Console.WriteLine("10.Test de primalitate: determinati daca un numar n este prim.");
            Console.WriteLine("11.Afisati in ordine inversa cifrele unui numar n. ");
            Console.WriteLine("12.Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].");
            Console.WriteLine("13.Determianti cati ani bisecti sunt intre anii y1 si y2.");
            Console.WriteLine("14.Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. ");
            Console.WriteLine("15.Se dau 3 numere. Sa se afiseze in ordine crescatoare. ");
            Console.WriteLine("16.Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)");
            Console.WriteLine("17.Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. ");
            Console.WriteLine("18.Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2. ");
            Console.WriteLine("19.Determinati daca un numar e format doar cu 2 cifre care se pot repeta.De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.");
            Console.WriteLine("20.Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3).");
            Console.WriteLine("21.Ghiciti un numar intre 1 si 1024 prin intrebari de forma numarul este mai mare sau egal decat x?. ");
            Console.WriteLine("Alegeti numarul unei probleme din lista de programe");
            p = int.Parse(Console.ReadLine());

            Main.Class1 one = new Class1();
            Main.Class2 two = new Class2();
            Main.Class3 three = new Class3();
            Main.Class4 four = new Class4();
            Main.Class5 five = new Class5();
            Main.Class6 six = new Class6();
            Main.Class7 seven = new Class7();
            Main.Class8 eight = new Class8();
            Main.Class9 nine = new Class9();
            Main.Class10 ten = new Class10();
            Main.Class11 eleven = new Class11();
            Main.Class12 twelve = new Class12();
            Main.Class13 thirteen = new Class13();
            Main.Class14 fourteen = new Class14();
            Main.Class15 fifteen = new Class15();
            Main.Class16 sixteen = new Class16();
            Main.Class17 seventeen = new Class17();
            Main.Class18 eighteen = new Class18();
            Main.Class19 nineteen = new Class19();
            Main.Class20 twenty = new Class20();
            Main.Class21 twentyone = new Class21();
            if (p == 1)
            {
                one.One();
            }
            if (p == 2)
            {
                two.Two();
            }
            if(p == 3)
            {
                three.Three();
            }
            if (p == 4)
            {
                four.Four();
            }
            if (p == 5)
            {
                five.Five();
            }
            if (p == 6)
            {
                six.Six();
            }
            if(p == 7)
            {
                seven.Seven();
            }
            if(p == 8)
            {
                eight.Eight();
            }
            if(p == 9)
            {
                nine.Nine();
            }
            if(p == 10)
            {
                ten.Ten();
            }
            if(p == 11)
            {
                eleven.Eleven();
            }
            if (p == 12)
            {
                twelve.Twelve();
            }
            if (p == 13)
            {
                thirteen.Thirteen();
            }
            if (p == 14)
            {
                fourteen.Fourteen();
            }
            if (p == 15)
            {
                fifteen.Fifteen();
            }
            if (p == 16)
            {
                sixteen.Sixteen();
            }
            if (p == 17)
            {
                seventeen.Seventeen();
            }
            if (p == 18)
            {
                eighteen.Eighteen();
            }
            if (p == 19)
            {
                nineteen.Nineteen();
            }
            if (p == 20)
            {
                twenty.Twenty();
            }
            if (p == 21)
            {
                twentyone.Twentyone();
            }
















        }
    }
}
