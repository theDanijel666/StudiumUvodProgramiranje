using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajvisePonavljanja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand=new Random();

            int[] brojevi = new int[100];

            for (int i = 0; i < brojevi.Length; i++) 
            {
                brojevi[i] = rand.Next(50);
            }

            for(int i = 0;i < brojevi.Length; i++)
            {
                Console.Write(brojevi[i]+"\t");
            }

            int broj=0,brojac=0;
            for(int i = 0;i< brojevi.Length; i++) 
            {
                int tempbrojac = 1;
                for(int j=i+1;j< brojevi.Length; j++)
                {
                    if (brojevi[i] == brojevi[j]) tempbrojac++;
                }
                if (tempbrojac > brojac) 
                {
                    brojac = tempbrojac;
                    broj = brojevi[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Najviše se ponavlja: "+broj);


        }
    }
}
