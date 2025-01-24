using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatiranje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var jh = (ime: "Jupiter", prezime: "Hammon", godRodjenja: 1711, izdano: 1761);

            string izjava = $"{jh.ime} {jh.prezime} bio je pjesnik rođen {jh.godRodjenja}. godine";
            Console.WriteLine(izjava);
            string izjavap = jh.ime + " " + jh.prezime + " je bio pjesnik rođen " + jh.godRodjenja.ToString() + ". godine";
            Console.WriteLine(izjavap);

            string izjava2 = $"Prvu publikaciju imao je {jh.izdano}. u svojoj {jh.izdano-jh.godRodjenja}. godini starosti";
            Console.WriteLine(izjava2);

            string izjava3 = $"Bio bi preko {Math.Round((DateTime.Now.Year - jh.godRodjenja)/100d)*100d} godina star danas";
            Console.WriteLine(izjava3);


        }
    }
}
