using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznimkeWhen
{
    internal class Program
    {
        static int Ispis(int[] brojevi,int index)
        {
            int broj=0;
            try
            {
                broj = brojevi[index];
            }
            catch (Exception ex) when(logiraj(ex))
            { }
            catch (IndexOutOfRangeException e) when (index < 0)
            {
                throw new ArgumentException("Index ne smije biti manji od 0!", e);
            }
            catch (IndexOutOfRangeException e)
            {
                throw new ArgumentException("Index ne smije biti veći od 9!", e);
            }

            return broj;
        }

        static bool logiraj(Exception e)
        {
            Console.WriteLine("Unijeti u neku log datoteku!");
            Console.WriteLine(e.Message);
            return false;
        }

        static void Main(string[] args)
        {
            int[] brojevi = { 3, 56, 23, 654, 23, 5, 654, 433, 65, 13 };
            try
            {
                Console.WriteLine(Ispis(brojevi, 7));
                Console.WriteLine(Ispis(brojevi, -7));
            }
            catch (Exception e) when (logiraj(e)) { }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException.Message);
            }
            
        }
    }
}
