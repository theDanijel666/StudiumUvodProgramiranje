using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileKlasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File f = new File();
            string putanja = @"C:\work\StudiumUvodProgramiranje\Adresar\bin\Debug\adresar";
            File.AppendAllLines("Append.txt", new string[] {"Linija dodana novim pokretanjem"});
            File.AppendAllText("Append.txt", "Sadržaj all texta");
            var sw = File.AppendText("Append.txt");
            sw.WriteLine("Pisanje preko streamWritera");
            sw.Flush();
            sw.Close();

            string ps=putanja;
            string pd="adresar.txt";

            //File.Copy(ps, pd); //nakon prvog pokretanja baca exeption!
            File.Copy(ps, pd, true);
            File.Delete(pd);
            FileStream fs=File.Create("stvori.txt");
            File.Encrypt("Append.txt");
            File.Decrypt("Append.txt");

            if(File.Exists(pd)) File.Delete(pd);

            var att=File.GetAttributes("Append.txt");

            var stvoren=File.GetCreationTime("Append.txt");
            Console.WriteLine("Stvoreno "+stvoren.ToString());
            Console.WriteLine("Zadnji pristup "+File.GetLastAccessTime("Append.txt").ToString());
            File.SetCreationTime("Append.txt", new DateTime(2030, 8, 12));
            
        }
    }
}
