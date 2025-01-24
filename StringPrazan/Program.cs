using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrazan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "pozdrav";
            string nullstr = null;
            string prazanstr = String.Empty;

            Console.WriteLine(str.Length);
            //Console.WriteLine(nullstr.Length);
            Console.WriteLine(prazanstr.Length);
            Console.WriteLine(nullstr);

            string tempstr = str + nullstr;
            Console.WriteLine(tempstr);

            Console.WriteLine(prazanstr==nullstr);
            Console.WriteLine(prazanstr=="");

            string s1 = "\x0" + "abc";
            string s2 = "abc" + "\x0";

            Console.WriteLine("*" + s1 + "*");
            Console.WriteLine("*" + s2 + "*");

            Console.WriteLine(s2.Length);
        }
    }
}
