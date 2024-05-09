using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4.Stringové_pole_a_příkaz_IndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik chceš zadat jmen - velikost pole");
            int velikost = Convert.ToInt32(Console.ReadLine());
            string[] poleJmen = new string[velikost];
            for (int i = 0; i < poleJmen.Length; i++)
            {
                Console.WriteLine("Zadej jméno");
                poleJmen[i] = Console.ReadLine();
            }
            Console.WriteLine();
            for (int i = 0;i < poleJmen.Length;i++)
            {
                Console.Write(poleJmen[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Zadej jméno co chceš najít:");
            string myName = Console.ReadLine();
            int poradi = Array.IndexOf(poleJmen, myName) + 1; 
            //Array.IndexOf(poleJmen, myName) - najde mi index, proto když chci pořadí musím + 1
            //!!! zapamatovat Array.IndexOF(názevPole, hledanýPrvek) !!!
            //obecně zapamatovat příkazy Array.něco !!!!!!!
            Console.WriteLine($"Vaše jméno je na {poradi}. místě");

            Console.ReadKey();
        }
    }
}
