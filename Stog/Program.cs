using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> brojevi=new Stack<int>();
            brojevi.Push(1);
            brojevi.Push(2);
            brojevi.Push(3);
            brojevi.Push(4);
            brojevi.Push(5);

            foreach (int i in brojevi)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("U obradi: "+brojevi.Pop());
            Console.WriteLine("Sljedeći za obradu: " + brojevi.Peek());

            foreach (int i in brojevi)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
