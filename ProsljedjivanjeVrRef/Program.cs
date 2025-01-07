using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsljedjivanjeVrRef
{
    internal class Program
    {
        static void povecaj(int broj)
        {
            broj++;
            Console.WriteLine("Broj u funkciji: "+broj); 
        }

        static void PovecajBrojeve(int[] brojevi)
        {
            Console.WriteLine("Brojevu u početku funkcije:");
            Ispis(brojevi);
            for(int i = 0; i < brojevi.Length; i++)
            {
                brojevi[i]++;
            }
            Console.WriteLine("Brojevi na kraju funkcije:");
            Ispis(brojevi);
        }

        static void Ispis(int[] brojevi)
        {
            foreach (int i in brojevi)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int broj = 3;
            povecaj(broj);
            Console.WriteLine("Broj van funkcije: "+broj);

            int[] brojevi = { 1, 5, 3, 7 };
            Console.WriteLine("Brojevi prije funkcije: ");
            Ispis(brojevi);
            PovecajBrojeve(brojevi);
            Console.WriteLine("Brojevi nakon funkcije: ");
            Ispis(brojevi);
        }
    }
}
