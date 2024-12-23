using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrananjeUgnjezdjeno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operating system chosing helper :)");
            Console.WriteLine("Are you an idiot? (y/n)");
            char odgovor = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if( odgovor == 'y')
            {
                Console.WriteLine("MAC");
            }
            else
            {
                Console.WriteLine("Do you have a life? (y/n)");
                odgovor = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if( odgovor =='y') Console.WriteLine("Windows");
                else Console.WriteLine("Linux");
            }
        }
    }
}
