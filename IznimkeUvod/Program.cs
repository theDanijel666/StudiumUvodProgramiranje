using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznimkeUvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Unesite cijeli broj: ");
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch {
                Console.WriteLine("Dogodila se greška, no nastavit ćemo normalno izvođenje :)");
            }

            try
            {
                Console.Write("Unesite broj opet: ");
                a = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Dogodila se greška:");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.InnerException);
                Console.WriteLine("Nastavljamo normalno izvođenje");
            }

            try
            {
                Console.Write("Unesite broj opet: ");
                a = int.Parse(Console.ReadLine());
            }
            catch (FormatException e) 
            {
                Console.WriteLine("Greška u formatu, jeste sigurni da ste unijeli samo broj?");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Broj je prevelik za spremiti u int varijablu!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Dogodila se greška: ");
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
