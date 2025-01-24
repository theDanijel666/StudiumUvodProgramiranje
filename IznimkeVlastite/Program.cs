using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznimkeVlastite
{
    public class MojaIznimka : Exception
    {
        public string Dioprograma {  get; set; }
        public MojaIznimka() : base() { }
        public MojaIznimka(string message) : base(message) { 
            Dioprograma= message+" "+base.StackTrace;
        }
        public MojaIznimka(string message, Exception innerException) : base(message, innerException) { }

    }

    internal class Program
    {
        public static void TestThrow()
        {
            throw new MojaIznimka("Testing 1, 2, 3...");
        }

        static void Main(string[] args)
        {
            try
            {
                TestThrow();
            }
            catch (MojaIznimka ex)
            {
                Console.WriteLine("Uhvatio MojaIznimka");
                Console.WriteLine(ex.Dioprograma);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
