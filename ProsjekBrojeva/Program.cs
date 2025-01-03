/*
 * Program traži unos brojeva dokle god se ne unese 0. Nakon toga ispisuje prosjek svih unesenih brojeva.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsjekBrojeva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj=1;
            int brojac=0, suma = 0;
            while (broj != 0)
            {
                Console.Write("Unesite broj: ");
                broj=int.Parse(Console.ReadLine());
                if(broj != 0)
                {
                    suma += broj;
                    brojac++;
                }
            }

            Console.WriteLine("Prosjek svih brojeva je " + ((float)suma / brojac).ToString("0.00"));
        }
    }
}
