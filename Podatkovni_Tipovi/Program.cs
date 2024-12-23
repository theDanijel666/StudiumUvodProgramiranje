using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podatkovni_Tipovi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cijelobrojni tipovi: ");

            Console.WriteLine("byte");
            byte bajt = 5;
            Console.WriteLine(bajt);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            Console.WriteLine("short i ushort");
            short sh = -12;
            ushort ush = 4;
            Console.WriteLine(sh+" "+ush);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);

            Console.WriteLine("int i uint");
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(uint.MaxValue);

            Console.WriteLine();
            Console.WriteLine("decimalni tipovi");

            float decimalni = 4.7f;
            Console.WriteLine(decimalni);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.Epsilon);

            decimalni = decimalni + 0.000000000002f;
            Console.WriteLine(decimalni);

            double dupli = decimalni;
            Console.WriteLine(dupli);
            dupli = dupli + 0.000000000002;
            Console.WriteLine(dupli);

            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.Epsilon);

            Console.WriteLine();
            Console.WriteLine("Logički tip");

            bool log=true;
            Console.WriteLine(log);
            Console.WriteLine(false);
            Console.WriteLine(true);
        }
    }
}
