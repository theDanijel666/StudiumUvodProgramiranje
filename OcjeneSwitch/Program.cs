/*
 * Za unešenu ocjenu ispisati slovima
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcjeneSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite ocjenu: ");
            int ocjena=int.Parse(Console.ReadLine());

            switch (ocjena)
            {
                case 1:
                    Console.WriteLine("Nedovoljan!");
                    break;
                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Dobar");
                    break;
                case 4:
                    Console.WriteLine("Vrlo dobar");
                    break;
                case 5:
                    Console.WriteLine("Odličan");
                    break;
                default:
                    Console.WriteLine("Neispravan unos, ocjena mora biti 1 do 5!");
                    break;

            }

            float pi = 3.142f;

            switch (pi)
            { 
                case 3:  //pi==3 
                    Console.WriteLine("+");
                    break;
                case 3.1f:  //pi==3.1
                    Console.WriteLine("Preciznije");
                    break;
                case 3.14f:  //pi==3.14
                    Console.WriteLine("Točno");
                    break;
                default:
                    Console.WriteLine("?");
                    break;
            }
        }
    }
}
