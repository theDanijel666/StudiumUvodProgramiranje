/*
 * Učitati 2 broja, prvi podijeliti s drugim, no paziti 
 * da ne dođe nigdje do greška koja bi srušila program!
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznimkeMatematika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Unesite 1. broj: ");
        pocetaka:
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch 
            {
                Console.Write("Neispravan unos, pokušaj ponovno: ");
                goto pocetaka;
            }

            Console.Write("Unesite 2. broj: ");
        pocetakb:
            try
            {
                b = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("Neispravan unos, pokušaj ponovno: ");
                goto pocetakb;
            }

            try
            {
                Console.WriteLine(a+" / "+b+" = "+ a/b);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(a + " / " + b + " = beskonačno!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Dogodila se nepoznata greška:");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Hvala na korištenju programa :)");
            }
        }
    }
}
