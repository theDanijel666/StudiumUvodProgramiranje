/*
 * Program za izračun faktorijela s rekurzivnom i ne rekurzivnom funkcijom
 * 1!=1
 * 2!=1*2
 * 3!=1*2*3
 * 4!=1*2*3*4
 * ..
 * n!=1*2*...*(n-1)*n
 * 
 * n!=(n-1)!*n
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekurzivnaFunkcija
{
    internal class Program
    {
        static long fakt(long n)
        {
            long f = 1;
            for (long i = 2; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }

        static long faktrek(long n)
        {
            if (n < 2) return 1;
            return faktrek(n - 1) * n;
        }

        static void Main(string[] args)
        {
            Console.Write("Unesite broj: ");
            long broj;
            if (long.TryParse(Console.ReadLine(), out broj))
            {
                Console.WriteLine(broj + "!=" + fakt(broj));
                Console.WriteLine(broj + "!=" + faktrek(broj));
            }
        }
    }
}
