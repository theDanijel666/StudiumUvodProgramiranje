using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> brojevi=new Queue<string>();

            brojevi.Enqueue("jedan");
            brojevi.Enqueue("dva");
            brojevi.Enqueue("tri");
            brojevi.Enqueue("četiri");
            brojevi.Enqueue("pet");

            foreach(string broj in brojevi)
            {
                Console.WriteLine(broj);
            }
            Console.WriteLine();

            Console.WriteLine("Obrađujem element "+brojevi.Dequeue());
            Console.WriteLine("Sljedeći element za obradu je " + brojevi.Peek());

            foreach (string broj in brojevi)
            {
                Console.WriteLine(broj);
            }
            Console.WriteLine();

            
        }
    }
}
