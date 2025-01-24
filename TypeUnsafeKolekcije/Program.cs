using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TypeUnsafeKolekcije
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();

            lista.Add(1);
            lista.Add("neka rečenica");
            lista.Add(null);
            lista.Add(3.14);

            foreach(var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Broj elemenata liste: "+lista.Count);

            if (lista.Contains(1)) Console.WriteLine("sadrži jedan!");
            else Console.WriteLine("Nema jedinice!");

            lista.Clear();

            if (lista.Contains(1)) Console.WriteLine("sadrži jedan!");
            else Console.WriteLine("Nema jedinice!");

            lista.Add(6);
            lista.Insert(0, "stavljen na početak :)");

            lista.Remove(1);
            lista.RemoveAt(1);

            lista.Add(9);
            lista.Add(13);
            Console.WriteLine("Original lista: ");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            lista.Reverse();
            Console.WriteLine("Obrnuta: ");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sortirana lista: ");

            //lista.Sort(); //radi samo kad su u listi usporedivi podatkovni tipovi!
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Kapacitet liste: "+lista.Capacity);
            Console.WriteLine("Broj elemenata liste: " + lista.Count);

            Console.WriteLine( lista.IndexOf(6));
            Console.WriteLine(lista.IndexOf(13));

            lista.Add("novi string");
            lista.Add(3.14);
            lista.Add('a');

            foreach (var item in lista)
            {
                Console.WriteLine(item.GetType().Name);
                if(item.GetType().Name == "String")
                {
                    Console.WriteLine("radim s stringovima");
                }
            }

            
        }
    }
}
