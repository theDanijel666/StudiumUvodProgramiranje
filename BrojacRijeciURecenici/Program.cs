/*
 * Program traži unos rečenice, kao riješenje ispisuje koliko rečenica ima riječi
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrojacRijeciURecenici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite rečenicu: ");
            string recenica=Console.ReadLine();

            char[] interpunkcijski = { '.',',','(',')',',',':',';',' ' };
            //foreach(char c in interpunkcijski)
            //{
            //    recenica=recenica.Replace(c, ' ');
            //}
            //Console.WriteLine(recenica);
            var rijeci = recenica.Split(interpunkcijski);
            int brojac = 0;
            foreach (var rijec in rijeci)
            {
                if (rijec.Length > 0) brojac++;
            }
            Console.WriteLine($"Rečenica ima {brojac} riječi");
        }
    }
}
