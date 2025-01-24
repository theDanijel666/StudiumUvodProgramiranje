using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznimkeBacanje
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Exception">U slučaju da je broj, no neispravnog raspona</exception>
        /// <returns>ocjenu u int obliku</returns>
        static int ocjena()
        {
            int o;
            Console.Write("Unesite ocjenu: ");
            unos:
            try
            {
                o = int.Parse(Console.ReadLine());
            }
            catch {
                Console.Write("Neispravan unos, pokušajte ponovno unijeti ocjenu: ");
                goto unos;
            }

            if(o<1 || o > 5)
            {
                Exception e = new Exception("Ocjena mora biti u rasponu 1 do 5!");
                e.Source = "Statična metoda ocjena";
                throw e;
                //throw new Exception("");
            }

            return o;
        }

        static void Main(string[] args)
        {
            int o;
            pocetak:
            try
            {
                o = ocjena();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto pocetak;
            }
        }
    }
}
