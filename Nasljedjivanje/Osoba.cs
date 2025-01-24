using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedjivanje
{
    public class Osoba
    {
        string prezime;
        string ime;
        DateTime datumRodjenja;

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public string Ime
        { 
            get { return ime; } 
            set { ime = value; } 
        }

        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value; }
        }

        public Osoba() { }

        public Osoba(string prezime,string ime, DateTime datumRodjenja)
        {
            Prezime = prezime;
            Ime = ime;
            DatumRodjenja=datumRodjenja;
        }

        public string PunoIme()
        {
            return ime + " " + prezime;
        }
    }
}
