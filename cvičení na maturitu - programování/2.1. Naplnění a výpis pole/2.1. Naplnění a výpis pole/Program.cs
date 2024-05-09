using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1.Naplnění_a_výpis_pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10]; //nové pole s názvem array o velikosti 10
            Random rnd = new Random(); //musím to dát sem, ne do toho cyklu!!!
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 21); //náhodná čísla od 1 do 20
            }
            for(int i = 0;i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Array.Sort(array); //!!! Array.Sort(názevPole) - setřídí pole, na čísla i stringy !!!
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }

            Console.ReadKey();
        }
    }
}
