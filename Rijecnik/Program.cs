using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rijecnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> hrvatski= new Dictionary<string,string>();

            hrvatski.Add("menu", "izbornik");
            hrvatski.Add("copy", "kopiraj");
            hrvatski.Add("paste", "zalijepi");
            /*
             * foreach(var red in datoteka){
             *  rijecnik.Add(origninal,prijevod);
             * }
             */

            try
            {
                hrvatski.Add("menu", "glavnik izbornik");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            foreach(var rijec in hrvatski)
            {
                Console.WriteLine(rijec.Key+" = "+rijec.Value);
            }

            Console.WriteLine(hrvatski["paste"]);
            hrvatski["write"] = "zapiši";
            Console.WriteLine();

            foreach (var rijec in hrvatski)
            {
                Console.WriteLine(rijec.Key + " = " + rijec.Value);
            }
            hrvatski["write"] = "unesi";
            Console.WriteLine(hrvatski["write"]);

            Console.WriteLine();
            try
            {
                Console.WriteLine(hrvatski["read"]);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            string r="";
            if (!hrvatski.TryGetValue("read", out r))
            {
                hrvatski["read"] = "čitaj";
                r = "čitaj";
            }
            else
            {
                Console.WriteLine(r);
            }

            foreach (var rijec in hrvatski)
            {
                Console.WriteLine(rijec.Key + " = " + rijec.Value);
            }
            Console.WriteLine();

            hrvatski.Remove("čitaj");
            foreach (var rijec in hrvatski)
            {
                Console.WriteLine(rijec.Key + " = " + rijec.Value);
            }
            Console.WriteLine();

            hrvatski.Remove("read");
            foreach (var rijec in hrvatski)
            {
                Console.WriteLine(rijec.Key + " = " + rijec.Value);
            }
            Console.WriteLine();

            Console.WriteLine("Ključevi:");
            foreach(string k in hrvatski.Keys)
            {
                Console.WriteLine(k);
            }
        }
    }
}
