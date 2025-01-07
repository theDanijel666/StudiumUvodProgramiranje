using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcije
{
    internal class Program
    {
        static void Pozdrav()
        {
            Console.WriteLine("Pozdrav iz funkcije");
        }

        static int Zbroj(int a,int b)
        {
            return a + b;
        }

        static int Umnozak(int a,int b)
        {
            int c = a * b;
            return c;
        }

        /// <summary>
        /// Funkcija za ispitivanje da li je prosljeđeni broj prost.
        /// </summary>
        /// <param name="n">Cijeli broj koji ispitujemo da li je prost</param>
        /// <returns>Vraća bool je ili nije</returns>
        static bool Prost(int n)
        {
            //DONE: Implementirati!!!!
            for(int i = 2; i < n/2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        
        static void Main(string[] args)
        {
            Pozdrav();
            Pozdrav();
            Pozdrav();
            Console.WriteLine(Zbroj(4,7));
            int a = 4, d = 1;
            Console.WriteLine(Umnozak(a,d));
            if(Prost(31)) Console.WriteLine("31 je prost :)");
            else Console.WriteLine("Broj nije prost...");

            if (Prost(14)) Console.WriteLine("14 je prost :)");
            else Console.WriteLine("Broj nije prost...");

            if (Prost(65)) Console.WriteLine("65 je prost :)");
            else Console.WriteLine("Broj nije prost...");
        }
    }
}
