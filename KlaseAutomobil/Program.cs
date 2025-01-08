using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KlaseAutomobil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automobil a1 = new Automobil("BMW");
            Automobil a2 = new Automobil("");

            Console.WriteLine(a1.Marka);
            Console.WriteLine(a2.Marka);

            Automobil a3 = new Automobil("Toyota")
            {
                Boja = "siva",
                Masa=1600,
                Duzina=392,
                SnagaKS=120,
                GodinaProizvodnje=DateTime.Now.Year
            };
            a3.Putuj(32467);
            Console.WriteLine(a3.Ispis());

            
        }
    }
}
