/*
 * Za uneseni radius, izračunati opseg i površinu, no prikazati rezultat u float, double i int
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreopterecivanjeKrug
{
    internal class Program
    {
        static double Povrsina(double r)
        {
            return r * r * Math.PI;
        }

        static float Povrsina(float r)
        {
            return (float)Povrsina((double)r);
        }

        static int Povrsina(int r)
        {
            return (int)Povrsina((double)r);
        }

        static double Opseg(double r)
        {
            return 2 * r * Math.PI;
        }

        static float Opseg(float r)
        {
            return (float)(Opseg((double)r));
        }

        static int Opseg(int r)
        {
            return (int)(Opseg((double)r));
        }

        static void Main(string[] args)
        {
            Console.Write("Unesite radius: ");
            double r=double.Parse(Console.ReadLine());

            Console.WriteLine("double povrsina: "+Povrsina(r));
            Console.WriteLine("float povrsina: "+Povrsina((float)r));
            Console.WriteLine("int povrsina: "+Povrsina((int)r));

        }
    }
}
