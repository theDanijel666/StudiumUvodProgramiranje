using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj;
            Console.Write("Unesite broj imena: ");
            broj=int.Parse(Console.ReadLine());

            string[] imena=new string[broj];

            for (int i = 0; i < imena.Length; i++)
            {
                Console.Write("Unesite {0}. ime: ", i + 1);
                imena[i] = Console.ReadLine();
            }
            Console.WriteLine();

            Console.WriteLine("Unijeli ste: ");
            for (int i = 0;i < imena.Length; i++) Console.Write(imena[i]+"\t");

            Console.WriteLine();
            Console.WriteLine();
            Array.Sort(imena);
            Console.WriteLine("Sortirana imena: ");
            for (int i = 0; i < imena.Length; i++) Console.Write(imena[i] + "\t");
        }
    }
}
