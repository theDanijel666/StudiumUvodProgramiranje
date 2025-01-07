using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolneNaredbe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                break;
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                if (i == 3) break;
            }

            for (int i = 0; i < 100; i++)
            {
                if (i != 7) continue;
                Console.WriteLine(i);
            }

        }
    }
}
