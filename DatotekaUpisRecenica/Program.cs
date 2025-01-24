using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatotekaUpisRecenica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite ime datoteke: ");
            string datoteka=Console.ReadLine();

            FileStream fs;
            try
            {
                fs = new FileStream(datoteka, FileMode.Create);
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Neuspjelo otvaranje datoteke!");
                Console.WriteLine(ex.Message);
                return;
            }

            //pisanje:
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(fs);
                do
                {
                    Console.WriteLine("Unesite rečenicu za upisati u datoteku (Upišite \"kraj\" za prekid):");
                    string rec=Console.ReadLine();
                    if (rec == "kraj") break;
                    sw.WriteLine(rec);
                } while (true);
                sw.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška s pisanjem u datoteku!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(sw!=null) sw.Close();
            }

            if(fs!=null) fs.Close();


            //čitanje:
            try
            {
                fs = new FileStream(datoteka, FileMode.Open);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Neuspjelo otvaranje datoteke!");
                Console.WriteLine(ex.Message);
                return;
            }

            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fs);
                string sadrzaj = sr.ReadToEnd();
                Console.WriteLine("----Sadržaj datoteke----");
                Console.WriteLine(sadrzaj);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška prilikom čitanja iz datoteke!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(sr!=null) sr.Close();
                if(fs!=null) fs.Close();
            }
        }
    }
}
