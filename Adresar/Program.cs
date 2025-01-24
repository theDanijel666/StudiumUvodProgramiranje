using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adresar
{
    internal class Program
    {
        static void Main(string[] args)
        {
        pocetak:
            Console.Clear();
            Console.WriteLine("***********Adresar***********");
            Console.WriteLine("1. Popis kontakata");
            Console.WriteLine("2. Unos novoga");
            Console.WriteLine();
            Console.Write("Unesite svoj odabir: ");
            int odabir;
            try
            {
                odabir=int.Parse(Console.ReadLine());
                if (odabir < 1 || odabir > 2) 
                    throw new Exception("Mora biti odabrana jedna od opcija!");
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Došlo je do greške: ");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ponovite odabir!");
                System.Threading.Thread.Sleep(3000);
                goto pocetak;
            }

            FileStream fs;

            if (odabir == 1)
            {
                Console.Clear();
                try
                {
                    //fs = new FileStream("C:\\work\\StudiumUvodProgramiranje\\Adresar\\bin\\Debug\\adresar", FileMode.Open);
                    fs = new FileStream("adresar", FileMode.Open);
                    BinaryReader br = new BinaryReader(fs);
                    while (br.PeekChar() != -1)
                    {
                        string procitano = br.ReadString();
                        Console.WriteLine(procitano);
                        Osoba o = new Osoba(procitano);
                        Console.WriteLine(o.Ime + " " + o.Prezime);
                    }
                    br.Close();
                    fs.Close();
                    Console.WriteLine();
                    Console.WriteLine("Pritisnite enter za povratak u glavni izbornik");
                    Console.ReadLine();
                    goto pocetak;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("došlo je do greške:");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Pritisnite enter za povratak u glavni izbornik");
                    Console.ReadLine();
                    goto pocetak;
                }
                
            }

            if (odabir == 2)
            {
                Console.Clear();
                Osoba o = new Osoba();
                Console.Write("Unesite ime osobe: ");
                o.Ime = Console.ReadLine();
                Console.Write("Unesite prezime osobe: ");
                o.Prezime = Console.ReadLine();
                Console.Write("Unesite adresu osobe: ");
                o.Adresa = Console.ReadLine();
                Console.Write("Unesite broj mobitela osobe: ");
                o.Mobitel = Console.ReadLine();

                try
                {
                    fs = new FileStream("adresar", FileMode.Append);
                    //DONE: dovršiti program, staviti pisanje u datoteku!
                    BinaryWriter bw= new BinaryWriter(fs);
                    bw.Write(o.ToString());
                    bw.Flush();
                    bw.Close();
                    fs.Close();
                    goto pocetak;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("došlo je do greške:");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Pritisnite enter za povratak u glavni izbornik");
                    Console.ReadLine();
                    goto pocetak;
                }

            }

        }
    }
}
