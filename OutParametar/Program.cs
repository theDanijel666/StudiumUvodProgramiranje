using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParametar
{
    internal class Program
    {
        static void povecaj(int a)
        {
            a++;
        }

        static void povecaj2(out int a)
        {
            a = 0;
            a++;
        }

        static void Main(string[] args)
        {
            int a;
            //povecaj(a);
            povecaj2(out a);
            Console.WriteLine(a);
        }
    }
}
