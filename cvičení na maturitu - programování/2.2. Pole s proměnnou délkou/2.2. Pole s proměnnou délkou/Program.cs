using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2._2.Pole_s_proměnnou_délkou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pole s proměnnou délkou. Napište program pro výpočet průměru zadaných čísel.
            Console.WriteLine("zadej déklu pole = počet členů");
            int delka = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[delka]; //nové pole o délce jakou zadá uživatel
            Random rnd = new Random();
            int celkem = 0; //ze začátku je součet nula
            for (int i = 0; i < delka; i++)
            {
                array[i] = rnd.Next(1, 50);
                celkem += array[i];
            }
            for (int i = 0; i < delka; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();
            double prumer;
            prumer = celkem / delka;
            Console.WriteLine(prumer); //nevím proč ale tady ten průměr se mi zaokrouhluje
            Console.WriteLine(array.Average());

            Console.ReadKey();
        }
    }
}
