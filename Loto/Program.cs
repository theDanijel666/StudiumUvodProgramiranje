using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Izvlačenje loto brojeva:");

            int broj = 7, od = 39;

            int[] brojevi = new int[broj];

            Random random = new Random();

            for(int i = 0; i < broj; i++)
            {
                brojevi[i] = random.Next(1,od+1);
                for(int j = 0; j < i; j++)
                {
                    if (brojevi[i] == brojevi[j])
                    {
                        i--;
                        break;
                    }
                }
            }

            for (int i = 0; i < brojevi.Length; i++)
            {
                Console.Write(brojevi[i]+"\t");
            }
        }
    }
}
