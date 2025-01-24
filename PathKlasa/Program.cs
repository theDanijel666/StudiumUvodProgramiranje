using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace PathKlasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C:\\work\\StudiumUvodProgramiranje\\Adresar\\bin\\Debug\\adresar
            string drive = "C:\\";
            string direktorij = "work\\StudiumUvodProgramiranje\\Adresar\\bin\\Debug";
            string datoteka = "adresar";

            string puna_putanja = Path.Combine(drive,direktorij, datoteka);
            Console.WriteLine(puna_putanja);

            var n1 = Path.ChangeExtension(puna_putanja, "docx");
            Console.WriteLine(n1);
            var n2 = Path.ChangeExtension(n1, "pdf");
            Console.WriteLine(n2);
            Console.WriteLine(Path.ChangeExtension(n2, null));
            Console.WriteLine(Path.ChangeExtension(n2, ""));

            Console.WriteLine(Path.GetDirectoryName(puna_putanja));
            Console.WriteLine(Path.GetExtension(n1));
            Console.WriteLine(Path.GetFileName(n1));
            Console.WriteLine(Path.GetFileNameWithoutExtension(n1));
            Console.WriteLine(Path.GetFullPath("..\\..\\App.config"));
            Console.WriteLine("Ne smijemo imazi ove znakove: ");
            foreach(var c in Path.GetInvalidFileNameChars())
            {
                Console.Write(c);
                Console.Write("   ");
            }
            Console.WriteLine();
            Console.WriteLine(Path.GetPathRoot(Path.GetFullPath("..\\..\\App.config")));
            Console.WriteLine(Path.GetRandomFileName());
            Console.WriteLine(Path.GetTempFileName());
            Console.WriteLine(Path.GetRandomFileName());


        }
    }
}
