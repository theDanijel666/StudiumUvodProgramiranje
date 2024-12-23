using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 2;

            Console.WriteLine("Aritmetički: ");
            Console.WriteLine(a + "+" + b + "=" + (a + b) );
            Console.WriteLine(a + "-" + b + "=" + (a - b));
            Console.WriteLine(a + "*" + b + "=" + (a * b));
            Console.WriteLine(a + "/" + b + "=" + (a / b));
            Console.WriteLine(a + "/" + b + "=" + ((float)a / b));
            Console.WriteLine(a + "%" + b + "=" + (a % b));

            Console.WriteLine(a+b/a-b);
            Console.WriteLine((a + b) / (a - b));
            Console.WriteLine(((float)a + b) / (a - b));

            b--;
            --b;
            Console.WriteLine(b);
            Console.WriteLine(b++);
            Console.WriteLine(b);
            Console.WriteLine(++b);
            Console.WriteLine(b);

            //Ovaj kod izbacuje grešku dijeljenja s 0!
            //b = 0;
            //Console.WriteLine(a/0);
            //Console.WriteLine(a/b);

            Console.WriteLine();
            Console.WriteLine("Relacijski operatori:");

            Console.WriteLine(a + "<" + b + "=" + (a < b));
            Console.WriteLine(a + "<=" + b + "=" + (a <= b));
            Console.WriteLine(a + ">" + b + "=" + (a > b));
            Console.WriteLine(a + ">=" + b + "=" + (a >= b));
            Console.WriteLine(a + "==" + b + "=" + (a == b));
            Console.WriteLine(a + "!=" + b + "=" + (a != b));

            Console.WriteLine();
            Console.WriteLine("Logički operatori: ");
            Console.WriteLine(!true);
            //Console.WriteLine(!b);
            Console.WriteLine(true || false); //Alt+W za okomite crte |
            Console.WriteLine(true && false); //Shift+6 za and &
            
        }
    }
}
