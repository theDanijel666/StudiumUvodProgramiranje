using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogadjajUvodu
{
    public class Osoba
    {
        //delegat
        public delegate void PromjenaPrezimenaDelegat(object sender, EventArgs e);

        //događaj
        public event PromjenaPrezimenaDelegat PromjenaPrezimena;
        
        private string prezime;
        public string Prezime
        {
            get { return prezime; }
            set {
                prezime = value;
                if (PromjenaPrezimena != null)
                {
                    PromjenaPrezimena(this,new EventArgs());
                }
            }
        }
    }
}
