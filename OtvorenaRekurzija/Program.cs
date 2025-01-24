using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtvorenaRekurzija
{
    public class Radnik
    {
        private string alias;
        private string ime;

        public Radnik(string ime,string alias)
        {
            this.ime = ime;
            this.alias = alias;
        }
    }

    public class Vozac : Radnik
    {
        private class Vozilo {
            public int Snaga;
        }
        Vozilo v;
        public Vozac(string ime, string alias) : base(ime, alias) 
        {
            v=new Vozilo();
            v.Snaga = 100;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
