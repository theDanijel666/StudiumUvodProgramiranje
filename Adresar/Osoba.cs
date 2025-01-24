using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adresar
{
    public class Osoba
    {
        string ime;
        string prezime;
        string adresa;
        string mobitel;

        public string Ime 
        {
            get {return ime;}
            set {ime = value;}
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }

        public string Mobitel
        {
            get { return mobitel; }
            set { mobitel = value; }
        }
        public Osoba() { }

        public Osoba(string podaci)
        {
            var pojedinacni = podaci.Split(';');
            if(pojedinacni.Length!=4)
            {
                throw new ArgumentException("Neispravan format podataka!");
            }
            this.ime = pojedinacni[0];
            this.prezime = pojedinacni[1];
            this.adresa = pojedinacni[2];
            this.mobitel = pojedinacni[3];
        }

        public override string ToString()
        {
            return ime+";"+prezime+";"+adresa+";"+mobitel;
        }
    }
}
