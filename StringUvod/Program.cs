using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string poruka1;

            string poruka2 = null;

            string poruka3 = System.String.Empty;
            string poruka3alt = "";

            string tekst = "Neki tekst";

            string putanja = "C:\\Program Files\\Microsoft Visual Studio 10.0";

            string putanja2 = @"C:\Program Files\Microsoft Visual Studio 10.0";

            var str = "string preko var deklaracije.";
            //var s;

            System.String pozdrav = "Pozdrav svima";

            const string zakon = "Ne možeš me mijenjati!";

            pozdrav = "Pozdrav svima, pa koliko vas ima :)";
            //zakon = "Nema promjene!";

            char[] slova = { 'P', 'o', 'r', 'u', 'k', 'a' };
            string poruka=new string(slova);
            
            //Console.WriteLine(poruka1);
            Console.WriteLine(poruka2);
            Console.WriteLine(poruka3);
            Console.WriteLine(poruka3alt);
            Console.WriteLine(tekst);
            Console.WriteLine(putanja);
            Console.WriteLine(putanja2);
            Console.WriteLine(str);
            Console.WriteLine(pozdrav);
            Console.WriteLine(zakon);
            Console.WriteLine(poruka);
            
            poruka = "Auto";
            string auto = poruka;
            Console.WriteLine(auto);

            string s1 = "String je više ";
            string s2 = "nego suma njegovih znakova";

            s1 += s2;

            Console.WriteLine(s1);
            //s1 = s1.Replace(s2, "");
            //Console.WriteLine(s1);s

            string str1 = "Pozdrav";
            string str2 = str1;
            str1 += " opet";
            Console.WriteLine(str2 + str1);


        }
    }
}