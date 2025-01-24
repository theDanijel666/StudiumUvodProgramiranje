using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    public class Oblik
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Visina { get; set; }
        public int Sirina { get; set; }

        public virtual void Nacrtaj()
        {
            Console.WriteLine("Crtanje iz bazne klase");
        }
    }

    public class Krug : Oblik
    {
        public override void Nacrtaj()
        {
            Console.WriteLine("Crtanje kruga");
            //base.Nacrtaj();
        }
    }

    public class Kvadrat : Oblik
    {
        public override void Nacrtaj()
        {
            Console.WriteLine("Crtanje kvadrata");
        }
    }

    public class Trokut : Oblik
    {
        public override void Nacrtaj()
        {
            Console.WriteLine("Crtanje trokuta");
        }

        public void NekaMetoda()
        {

        }
    }

    public class Peterokut : Oblik { }

    internal class Program
    {
        static void Main(string[] args)
        {
            Oblik[] oblici = {
                new Krug(),
                new Kvadrat(),
                new Trokut(),
                new Trokut(),
                new Oblik(),
                new Krug(),
                new Peterokut()
            };

            foreach (var oblik in oblici)
            {
                oblik.Nacrtaj();
            }

            Oblik t = new Trokut();
            //t.NekaMetoda();
            Trokut t2=new Trokut();
            t2.NekaMetoda();
        }
    }
}
