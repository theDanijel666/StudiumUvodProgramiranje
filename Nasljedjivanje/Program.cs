using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucenik u=new Ucenik();

            u.Ime = "Nikola";
            u.Prezime = "Tesla";
            u.Matematika = 5;

            Console.WriteLine(u.PunoIme());

            Ucenik[] ucenici = new Ucenik[30];

            for (int i = 0; i < ucenici.Length; i++)
            {
                ucenici[i] = new Ucenik("prezime", "ime", new DateTime(2009, 1, 1));
            }

            Console.WriteLine(u);
        }
    }
}
