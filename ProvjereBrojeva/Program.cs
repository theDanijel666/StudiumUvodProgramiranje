/*
 * Program provjerava da li je uneseni broj prost, savršen i da li je dio fibonachijeg niza
 * Sve provjere napraviti u funkciji, ispis u glavnom dijelu programa.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvjereBrojeva
{
    internal class Program
    {
        static bool Prost(int n)
        {
            if(n<1) return false;
            for(int i=2; i<n/2+1;i++) if(n%i==0) return false;
            return true;
        }

        static bool Savrsen(int n)
        {
            if(n<1) return false;
            int zbroj = 1;
            for(int i=2;i<n;i++)
            {
                if (n % i == 0) zbroj = zbroj + i;
            }
            if (zbroj == n) return true;

            return false;
        }

        static bool FibbonacchijevBroj(int n)
        {
            if(n<1) return false;
            int trenutni = 1, prethodni = 1, predprethodni = 1;
            while (trenutni <= n)
            {
                if(trenutni==n) return true;
                trenutni = prethodni + predprethodni;
                predprethodni = prethodni;
                prethodni = trenutni;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.Write("Unesite broj: ");
            int broj=int.Parse(Console.ReadLine());
            if (Prost(broj)) Console.WriteLine("Broj je prost");
            if (Savrsen(broj)) Console.WriteLine("Broj je savršen");
            if (FibbonacchijevBroj(broj)) Console.WriteLine("Broj je dio Fibbonacchijevog niza.");

            for(int i = 1; i < 100; i++)
            {
                Console.WriteLine(i+":");
                if (Prost(i)) Console.WriteLine("Broj je prost");
                if (Savrsen(i)) Console.WriteLine("Broj je savršen");
                if (FibbonacchijevBroj(i)) Console.WriteLine("Broj je dio Fibbonacchijevog niza.");
            }

            
        }
    }
}
