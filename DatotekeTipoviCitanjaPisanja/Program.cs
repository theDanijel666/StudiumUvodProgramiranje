using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DatotekeTipoviCitanjaPisanja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pozdrav = "Pozdrav svima, tko god otvori da pročita :)";

            FileStream fs = new FileStream("binarnipodaci", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(12);
            bw.Write(63);
            bw.Write(44);
            bw.Flush();
            bw.Close();
            fs.Close();


            fs = new FileStream("binarnipodaci", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            while (br.PeekChar() != -1)
            {
                int broj=br.ReadInt32();
                Console.WriteLine(broj);
            }
            br.Close();
            fs.Close();


            fs = new FileStream("Artikli", FileMode.Create);
            bw=new BinaryWriter(fs);
            bw.Write(2);
            bw.Write("Artikl1");
            bw.Write(13.5f);
            bw.Write(4.2);
            bw.Write(25);
            bw.Write("A43");
            bw.Flush();
            bw.Close();
            fs.Close();

            fs = new FileStream("Artikli", FileMode.Open);
            br = new BinaryReader(fs);
            Console.WriteLine("Artikli:");
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadSingle());
            Console.WriteLine(br.ReadDouble());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
            br.Close();
            fs.Close();
        }
    }
}
