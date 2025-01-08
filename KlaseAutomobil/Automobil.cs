using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseAutomobil
{
    public class Automobil
    {
        //članovi
        #region Members

        int masa;
        int duzina;
        int sirina;
        int visina;
        int snaga;
        int km;
        string marka;
        int godinaProizvodnje;
        string boja;

        #endregion

        //svojstva
        #region Properties
        public int Masa
        {
            get { return masa; }
            set { masa = value; }
        }

        public int MasaFunte
        {
            get { return Masa * 2; }
        }

        public int Duzina
        {
            get { return duzina; }
            set { duzina = value; }
        }

        public int Sirina
        {
            get { return sirina; }
            set { sirina = value; }
        }

        public int Visina
        {
            get { return visina; }
            set { visina = value; }
        }

        public int SnagaKW
        {
            get { return snaga; }
            set { snaga = value; }
        }

        public int SnagaKS
        {
            get { return (int)(snaga * 1.3); }
            set { snaga=(int)((double)value / 1.3); }
        }

        public int Km
        {
            get { return km; }
        }

        public string Marka
        {
            get { return marka; }
            private set {
                string vrijednost = value;
                if (string.IsNullOrEmpty(vrijednost)) marka = "Honda";
                else marka = vrijednost; 
            }
        }

        public int GodinaProizvodnje
        {
            get { return godinaProizvodnje; }
            set { godinaProizvodnje = value; }
        }

        public string Boja
        {
            get { return boja; }
            set { boja = value; }
        }

        #endregion

        //konstruktori
        public Automobil(string marka)
        {
            km = 0;
            Marka = marka;
        }

        //metode
        public void Putuj(uint prijedjeno_km)
        {
            km += (int)prijedjeno_km;
        }

        public string Ispis()
        {
            string rez = "";
            rez += marka + " " + boja + " boje, ima " + SnagaKW + "kW ";
            rez += ", s prijeđenih " + km / 1000 + " tisuća kilometara";
            return rez;
        }
    }
}
