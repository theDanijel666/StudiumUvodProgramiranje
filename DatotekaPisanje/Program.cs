using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DatotekaPisanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("otvori me.txt", FileMode.Create);

            StreamWriter sw= new StreamWriter(fs);

            sw.WriteLine("Pozdrav i hvala :)");

            sw.Flush();
            sw.Close();
            fs.Close();


            fs = new FileStream("otvori me.txt", FileMode.Open);

            StreamReader sr = new StreamReader(fs);
            string sadrzaj=sr.ReadToEnd();
            sr.Close();
            fs.Close();

            Console.WriteLine(sadrzaj);
        }
    }
}
