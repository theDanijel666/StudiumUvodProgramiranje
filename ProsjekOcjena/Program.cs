/*
 * Program traži unos 5 ocjena i ispisuje prosjek.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsjekOcjena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ocjena, suma = 0;
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Unesite {0}. ocjenu: ",i+1);
                ocjena=int.Parse(Console.ReadLine());
                if(ocjena<1 || ocjena > 5)
                {
                    Console.WriteLine("Neispravan unos, pokušajte ponovo.");
                    i--;
                }
                else
                {
                    suma = suma + ocjena;
                }
            }
            Console.WriteLine("Prosjek ocjena je {0} ",(float)suma/5);
            int r;
        }
    }
}
