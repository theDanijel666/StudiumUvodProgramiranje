using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachPrimjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] brojevi = { 1, 2, 4, 7, 3, 1, 4, 54, 64, 32, 345, 1 };

            foreach(int i in brojevi)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            foreach (var i in brojevi)
            {
                Console.WriteLine(i/2);
            }

            Console.WriteLine();

            foreach (var i in brojevi)
            {
                if(i%3==0) Console.WriteLine(i);
            }
        }
    }
}
