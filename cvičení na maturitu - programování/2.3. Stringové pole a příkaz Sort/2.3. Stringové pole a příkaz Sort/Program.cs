using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3.Stringové_pole_a_příkaz_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Naplňte pole jmény a setřiďte je podle abecedy.
            Console.WriteLine("Zadej velikost pole jmen - počet jmen");
            int pocet = Convert.ToInt32(Console.ReadLine());
            string[] poleJmen = new string[pocet];
            for (int i = 0; i < pocet; i++)
            {
                Console.WriteLine("Zadej jméno");
                poleJmen[i] = Console.ReadLine();
            }
            Console.WriteLine();
            for (int i = 0;i < pocet; i++)
            {
                Console.Write(poleJmen[i] + ", ");
            }
            Array.Sort(poleJmen); //!!! zapamatovat Array.Sort(jménoPole); !!!
            Console.WriteLine();
            for (int i = 0; i < pocet; i++)
            {
                Console.Write(poleJmen[i] + ", ");
            }

            Console.ReadKey();
        }
    }
}
