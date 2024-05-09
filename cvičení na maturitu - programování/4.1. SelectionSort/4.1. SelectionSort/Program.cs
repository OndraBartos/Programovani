using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1.SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[15]; //vytvoříme si pole naplněné náhodnými čísly
            Random rnd = new Random();
            Console.WriteLine("Počáteční pole:");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rnd.Next(1, 21);
                Console.Write(myArray[i] + " ");
            }

            int[] sortedArray = myArray; //uděláme si kopii pole kterou budeme Třídit pro porovnání
            for (int i = 0; i < sortedArray.Length - 1; i++) //první for začíná od 0
            {
                int min = i; //minimum je můj počáteční index - 0
                for (int j = i + 1; j < sortedArray.Length; j++)
                { //druhý for začíná o jeden index výš jak jede ten první -> i + 1
                    if (sortedArray[j] < sortedArray[min]) 
                    {   //pokud je nějaký člen menší než můj člen na indexu min
                        //tak se index min přepíše na nový index jehož člen má novou nejnižší hodnotu
                        min = j;
                    }                    
                }
                //potom co projede celý cyklus tak máme nový nejmenší index = min
                //nyní prohodíme prvky
                int temp = sortedArray[min];
                sortedArray[min] = sortedArray[i];
                sortedArray[i] = temp;
            }

            Console.WriteLine(); //a konečně vypíšeme pole
            Console.WriteLine("Setříděné pole:");
            for (int i = 0;i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
