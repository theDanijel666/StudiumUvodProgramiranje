using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Text.StringBuilder sb=new System.Text.StringBuilder("Zmija: idealni ljubimac");
            Console.WriteLine(sb.ToString());

            sb[4] = 'e';
            sb[sb.Length-1] = 'i';
            sb[sb.Length - 2] = 'c';
            Console.WriteLine(sb.ToString());

            var sb2 = new System.Text.StringBuilder();
            for(int i = 0; i < 10; i++)
            {
                sb2.Append(i.ToString());
            }
            Console.WriteLine(sb2.ToString());

            sb2[0] = sb2[8];
            Console.WriteLine(sb2.ToString());

            sb2.Insert(4, sb2[0]);
            Console.WriteLine(sb2.ToString());
        }
    }
}
