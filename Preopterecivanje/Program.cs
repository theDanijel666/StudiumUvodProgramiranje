using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preopterecivanje
{
    internal class Program
    {
        static int Max(int a,int b)
        {
            if (a > b) return a;
            return b;
        }

        static float Max(float a,float b)
        {
            if (a > b) return a;
            return b;
        }

        static double Max(double c,double d)
        {
            if (c > d) return c;
            return d;
        }

        static char Max(char a,char b)
        {
            if (a > b) return a;
            return b;
        }

        static int Max(char a,char b,char c)
        {
            return Max(Max(a, b), c);
        }

        static void Main(string[] args)
        {
            Max(3, 6);
            Max(3.4f, 5.2f);
            Max('4', '3', '6');
        }
    }
}
