/*
 * Korisnik unosi raspon brojeva, program ispisuje sve brojeve djeljive s 3 u danom rasponu.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjeljiviS3URasponu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Unesite donju granicu: ");
            a=int.Parse(Console.ReadLine());
            Console.Write("Unesite gornju granicu: ");
            b=int.Parse(Console.ReadLine());

            if (a > b)
            {
                int pom = a;
                a = b;
                b = pom;
            }

            for(int i=a;i<=b;i++)
            {
                if(i%3==0) Console.WriteLine(i);
            }
        }
    }
}
