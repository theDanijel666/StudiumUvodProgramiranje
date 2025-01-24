using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DogadjajUvodu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba o = new Osoba();

            o.PromjenaPrezimena += O_PromjenaPrezimena;
            o.Prezime = "Jelačić";
            o.Prezime = "Tesla";
            o.Prezime = "Šokčević";

            o.PromjenaPrezimena-=O_PromjenaPrezimena;
            o.Prezime = "Hotvat";

            o.PromjenaPrezimena += O_PromjenaPrezimena;
            o.PromjenaPrezimena += O_PromjenaPrezimena1;
            o.PromjenaPrezimena += Promjena;
            o.Prezime = "Knežević";

        }

        public static void Promjena(object sender,EventArgs e)
        {

        }

        private static void O_PromjenaPrezimena1(object sender, EventArgs e)
        {
            Console.WriteLine("Druga metoda promjene!");
        }

        private static void O_PromjenaPrezimena(object sender, EventArgs e)
        {
            Console.WriteLine("Prezime promjenjeno!");
            Console.WriteLine("Novo prezime je "+((Osoba)sender).Prezime);
        }
    }
}
