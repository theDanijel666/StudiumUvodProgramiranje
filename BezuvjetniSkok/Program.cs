using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezuvjetniSkok
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            int o, sum=0, brojac = 0;

        pocetak:
            Console.Write("Unesite ocjenu: ");
            o=int.Parse(Console.ReadLine());
            if (o == 0) goto kraj;
            if (o < 1 || o > 5)
            {
                Console.WriteLine("Neispravan unos, ocjena mora biti od 1 do 5!");
                goto pocetak;
            }
            sum = sum + o;
            brojac++;
            goto pocetak;

        kraj:
            Console.WriteLine((float)sum / brojac);



            bool totalni_prekid = false;
            while (true)
            {
                do
                {
                    for (int i = 0; i < 100; i++)
                    {
                        //prekid iz svih petlji!
                        if (i == 43)
                        {
                            totalni_prekid = true;
                            break;
                        }
                    }
                    if (totalni_prekid) break;
                }while (true);
                if(totalni_prekid) break;
            }

            while (true)
            {
                do
                {
                    for (int i = 0; i < 100; i++)
                    {
                        //prekid iz svih petlji!
                        if (i == 43) goto totalni_kraj;
                    }
                } while (true);
            }

        totalni_kraj:
            Console.WriteLine();
        }
    }
}
