using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrananjeIF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Console.Write("Unesite cijeli broj: ");
            a=int.Parse(Console.ReadLine());

            if (a % 2 == 0) Console.WriteLine("Broj je paran");
            else Console.WriteLine("Broj je neparan!");
        }
    }
}
