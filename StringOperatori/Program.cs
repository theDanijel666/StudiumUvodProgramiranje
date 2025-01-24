using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperatori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Ana";
            var s2 = "Marko";

            string s3 = s1 + " + " + s2;
            Console.WriteLine(s3);

            //string s4 = s1 * 3; //s1 - s2;
            //Console.WriteLine(s4);
            if("zmija"=="zmija") Console.WriteLine("obje su zmije :)");
            if("zmija"!="zmaj") Console.WriteLine("Nisu obje zmije");
            if("zmija"!="ZMIJA") Console.WriteLine("Različiti objekti!");
            if ("zmija" == "zmija") Console.WriteLine("obje su zmije :)");
        }
    }
}
