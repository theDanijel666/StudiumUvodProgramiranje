using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryKlasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var di=Directory.CreateDirectory("Novi dir");
            if(Directory.Exists("Novi dir") && 
                    Directory.GetDirectories("Novi dir").Length==0 &&
                    Directory.GetFiles("Novi dir").Length==0) Directory.Delete("Novi dir");

            Console.WriteLine("Direktoriji: ");
            var dirovi=Directory.GetDirectories("..\\..\\");
            foreach (var dir in dirovi) {
                Console.WriteLine(dir);
            }

            Console.WriteLine("Datoteke: ");
            var datoteke = Directory.GetFiles("..\\..\\");
            foreach(var file in datoteke) { 
                Console.WriteLine(file); 
                //File.Delete(file); ne brisati bezveze!
            }

            Console.WriteLine("Struktura: ");
            var stuktura=Directory.GetFileSystemEntries("..\\..\\");
            foreach (var file in stuktura)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine("Particije: ");
            var drives=Directory.GetLogicalDrives();
            foreach (var drive in drives)
            {
                Console.WriteLine(drive);
            }

            Console.WriteLine(Directory.GetCurrentDirectory());

            Directory.SetCurrentDirectory("C:\\Windows");

            Console.WriteLine(Directory.GetCurrentDirectory());

            Console.WriteLine("Datoteke: ");
            datoteke = Directory.GetFiles(".");
            foreach (var file in datoteke)
            {
                Console.WriteLine(file);
                //File.Delete(file); ne brisati bezveze!
            }
        }
    }
}
