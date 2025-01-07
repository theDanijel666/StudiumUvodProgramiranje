using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefParametar
{
    internal class Program
    {
        static void povecaj(int a)
        {
            Console.WriteLine("Broj na početku funkcije: " + a);
            a++;
            Console.WriteLine("Broj na kraju funkcije: " + a);
        }

        static void povecaj2(ref int a)
        {
            a++;
        }
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine(i);
            povecaj(i);
            Console.WriteLine(i);
            povecaj2(ref i);
            Console.WriteLine(i);
        }
    }
}
