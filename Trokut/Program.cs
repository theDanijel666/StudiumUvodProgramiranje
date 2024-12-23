using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trokut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, P, O;

            Console.WriteLine("Unesite duljinu stranice a: ");
            a=double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite duljinu stranice b: ");
            b=double.Parse(Console.ReadLine());

            P = a * b / 2;
            c = Math.Sqrt(a * a + b * b);
            O = a + b + c;

            Console.WriteLine("Površina je " + P);
            Console.WriteLine("Opseg je " + O);
            Console.WriteLine("Hipotenuza je " + c);
        }
    }
}
