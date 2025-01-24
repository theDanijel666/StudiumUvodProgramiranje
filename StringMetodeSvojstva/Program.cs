using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMetodeSvojstva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = new string('a', 54);
            Console.WriteLine(s1);

            string s2 = "neki string             ";
            Console.WriteLine(s2);

            Console.WriteLine(s2.Length);
            Console.WriteLine(s2[6]);

            string s = "Danas je lijepi dan";

            Console.WriteLine(s);

            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());

            Console.WriteLine(s.Substring(9));
            Console.WriteLine(s.Substring(9,6));

            string[] rijeci = s.Split(' ');
            foreach(string rijec in rijeci) { Console.WriteLine(rijec); }

            string s_klon = (string)s.Clone();

            Console.WriteLine(s.CompareTo(s2));
            Console.WriteLine(s.CompareTo("riječ"));
            Console.WriteLine(s.CompareTo(s));
            Console.WriteLine(s.CompareTo("zz top je jedan on najvoljih klasičnih rock bendova :)"));
            Console.WriteLine(s.CompareTo(s1));

            Console.WriteLine(s.EndsWith("dan"));
            Console.WriteLine(s.EndsWith("lijep"));

            Console.WriteLine(s.Insert(9,"jako "));

            Console.WriteLine("+"+s.PadLeft(60)+"+");
            Console.WriteLine("+"+s.PadRight(60)+"+");

            Console.WriteLine(s.Trim());
            Console.WriteLine(s.TrimEnd());

            Console.WriteLine(s.Remove(9,7));
            Console.WriteLine(s.Replace("lijepi ",""));
            Console.WriteLine(s.Replace("lijepi", "oblačan"));

            Console.WriteLine(s.Replace("dan","****").Replace("lijepi","****"));

            Console.WriteLine(String.Compare(s,s1));

        }
    }
}
