/* Ovdje stavljamo generalne informacije o datoteci
 * Mogu biti logovi, upute ili nešta slično
 * U nastavi bude tekst zadatka koji treba napraviti
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvaAplikacija
{
    /// <summary>
    /// 
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Šturi opis metode 
        /// </summary>
        /// <param name="args">Parametar koji se inače predaje preko konzole pozivom</param>
        static void Main(string[] args)
        {
            //linijski komentar
            Console.WriteLine("Pozdrav svima :)"); //način ispisa poruke na konzoli
            Console.WriteLine("Nova linija");
            //Napraviti glavni dio programa.

            int broj_prvi = 42;
            int hb = 0x2A;
            byte bb = 0b_0010_1010;

            double d = 3D;
            d = 3.956_345;

            float f = 3.12f;

            decimal g = 3.54M;

            d = 0.34e2;
            d = 1.43e9;

            bool izraz=true;

            char c1 = 'j';
            char c2 = '\u006A';
            char c3 = '\x006A';
            char c4 = (char)106;

            Console.WriteLine(c1+" "+c2+" "+c3 + " "+c4);

            Console.WriteLine("\"č itat\"");
            
            Console.WriteLine("Novi red\n\tDrugi red");

            double r = 3, pi=3.13, O, P;

            P = r * r * pi;

            int h = 3, j = 2;
            Console.WriteLine(h/j);
            Console.WriteLine((float)h / j);
            int k = 200000000;
            Console.WriteLine(k*k);

            long l = k;
            Console.WriteLine(l*l);

            Console.ReadLine();  //Čeka pritisak entera za kraj programa
            
        }
    }
}
