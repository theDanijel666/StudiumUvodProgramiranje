using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokusajUnosa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj;
            Console.Write("Unesite broj: ");
            //broj=int.Parse(Console.ReadLine());
            if (int.TryParse(Console.ReadLine(), out broj))
            {
                Console.WriteLine("Uspješno ste unijeli broj " + broj);
            }
            else
            {
                Console.WriteLine("Neznam kako to pretvoriti u broj!");
                //broj = -1;
            }

            Console.WriteLine(broj);
        }
    }
}
