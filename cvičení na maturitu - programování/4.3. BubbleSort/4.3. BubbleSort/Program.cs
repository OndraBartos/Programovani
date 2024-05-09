using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3.BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[15];
            Random rnd = new Random();
            Console.WriteLine("Počáteční pole:");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rnd.Next(1, 21);
                Console.Write(myArray[i] + " ");
            }

            int[] sortedArray = myArray;
            for (int i = 0; i < sortedArray.Length - 1; i++)
            {
                for (int j = 0; j < sortedArray.Length - 1; j++)
                {
                    //porovnávám člen[j] se členem [j + 1]
                    int temp = sortedArray[j]; //do temp si uložim ten první kdybych je prohazoval
                    if (sortedArray[j] > sortedArray[j + 1])// Prohození prvků
                    {
                        sortedArray[j] = sortedArray[j + 1];
                        sortedArray[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Setříděné pole:");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
