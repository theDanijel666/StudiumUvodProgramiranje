using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enkapsulacija
{
    public class Osoba
    {
        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public string ImePrezime
        {
            get { return ime + " " + prezime; }
        }

        public string ImePrezimeM()
        {
            return ime + " " + prezime;
        }

        public DateTime DatumRodjenja
        {
            get; set;
        }

        public int Dob
        {
            get { return (DateTime.Now - DatumRodjenja).Days / 365; }
            //set
            //{
            //    int godine = value;
            //    DatumRodjenja = DateTime.Now.AddYears(-godine);
            //}
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba o= new Osoba();
            o.Ime = "Nikola";
            o.Prezime = "Tesla";

            Console.WriteLine(o.ImePrezime);
            Console.WriteLine(o.ImePrezimeM());

            o.DatumRodjenja = DateTime.Parse("10.7.1856");
            Console.WriteLine(o.DatumRodjenja);

            Console.WriteLine(o.Dob);
            //o.Dob = 90;
            Console.WriteLine(o.DatumRodjenja);
        }
    }
}
