/*
 * Za unesen prosjek ocjena u brojčanom obliku, ispisati opći uspjeh s riječi.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcjeneIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prosjek ocjena: ");
            float ocjena=float.Parse(Console.ReadLine());

            //Klasičan način rada
            if (ocjena < 1.0) Console.WriteLine("Neispravan unos, ocjena mora biti u rasponu 1.0 do 5.0!");
            if (ocjena >= 1 && ocjena < 2.0) Console.WriteLine("Nedovoljno!");
            if (ocjena >= 2 && ocjena < 2.5) Console.WriteLine("Dovoljno :)");
            if (ocjena >= 2.5 && ocjena < 3.5) Console.WriteLine("Dobar");
            if (ocjena >= 3.5 && ocjena < 4.5) Console.WriteLine("Vrlo dobar");
            if (ocjena >= 4.5 && ocjena <= 5.0) Console.WriteLine("Odličan :D");
            if(ocjena >5.0) Console.WriteLine("Neispravan unos, ocjena mora biti u rasponu 1.0 do 5.0!");

            //Prošireni if..else
            if (ocjena < 1.0) Console.WriteLine("Neispravan unos, ne smije biti manja od 1.0!");
            else if (ocjena < 2.0) Console.WriteLine("Nedovoljno!");
            else if (ocjena < 2.5) Console.WriteLine("Dovoljno :)");
            else if (ocjena < 3.5) Console.WriteLine("Dobar");
            else if (ocjena < 4.5) Console.WriteLine("Vrlo dobar");
            else if (ocjena <= 5.0) Console.WriteLine("Odličan :)");
            else Console.WriteLine("Neispravan unos, ocjena mora biti u rasponu 1.0 do 5.0!");

        }
    }
}
// Linija komentara, da šef misli da nešta radim :)
// Linija komentara, da šef misli da nešta radim :)
// Linija komentara, da šef misli da nešta radim :)
// Linija komentara, da šef misli da nešta radim :)
// Linija komentara, da šef misli da nešta radim :)
// Linija komentara, da šef misli da nešta radim :)