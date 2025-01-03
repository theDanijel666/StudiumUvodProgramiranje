using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetljaWHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            while (a > 3)
            {
                Console.WriteLine(a);
                a--;
            }
            Console.WriteLine("a je postao " + a);

            while (a > 2)
            {
                Console.WriteLine(a);
                a = a * 1;
            }
            Console.WriteLine("a je postao " + a);
        }
    }
}
