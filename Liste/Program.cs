using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> dinosauri= new List<string>();

            dinosauri.Add("Tyranosaur");
            dinosauri.Add("Brontosaur");
            dinosauri.Add("Triceritops");
            dinosauri.Add("Raptor");

            foreach (string s in dinosauri)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Kapacitet: "+dinosauri.Capacity);
            Console.WriteLine("Broj elemenata: "+dinosauri.Count);

            Console.WriteLine("Sadrži Brontosaura: "+dinosauri.Contains("Brontosaur"));

            dinosauri.Insert(2, "Pterodactyl");
            foreach (string s in dinosauri)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(dinosauri[4]);

            dinosauri.Remove("Raptor");
            dinosauri.RemoveAt(1);

            Console.WriteLine();
            foreach (string s in dinosauri)
            {
                Console.WriteLine(s);
            }

            dinosauri.RemoveAll(x => x.Contains("saur") && x.Length<2);
            Console.WriteLine();
            foreach (string s in dinosauri)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Console.WriteLine("Kapacitet: " + dinosauri.Capacity);
            Console.WriteLine("Broj elemenata: " + dinosauri.Count);
            dinosauri.TrimExcess();

            Console.WriteLine("Kapacitet: " + dinosauri.Capacity);
            Console.WriteLine("Broj elemenata: " + dinosauri.Count);

            dinosauri.Sort();
            Console.WriteLine();
            foreach (string s in dinosauri)
            {
                Console.WriteLine(s);
            }

        }
    }
}
