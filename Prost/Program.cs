/*
 * Program traži unos broja i ispisuje da li je prost.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj: ");
            int broj=int.Parse(Console.ReadLine());

            DateTime poc=DateTime.Now;

            bool prost = true;
            for (int i = 2; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            if (prost) Console.WriteLine("Broj je prost.");
            else Console.WriteLine("Broj nije prost!");

            Console.WriteLine("Proslo je "+(DateTime.Now-poc).TotalSeconds+" sekundi");
        }
    }
}
