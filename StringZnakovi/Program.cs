using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringZnakovi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Pisanje unatrag";

            for (int i = 0; i < s.Length; i++) { 
                Console.Write(s[i]);
            }
            Console.WriteLine();

            for(int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
            Console.WriteLine();

            string pitanje = "KAKO ćEmo RADITI s nepraVILNIM koriŠTEnjem caps lOCK tipke?";
            Console.WriteLine(pitanje);
            StringBuilder sb = new StringBuilder(pitanje);
            for(int i = 0; i < sb.Length; i++)
            {
                sb[i]=Char.ToLower(sb[i]);
            }

            string ispravljeno=sb.ToString();
            Console.WriteLine(ispravljeno);

            sb.AppendLine("Dodan novi red");
            sb.AppendLine("Još jedan...");
            Console.WriteLine(sb);
        }
    }
}
