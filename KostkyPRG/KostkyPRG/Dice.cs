using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KostkyPRG
{
    internal class Dice
    {
        public int diceCount;
        public Random rnd;
        public int sum;
        public Dice(int diceCount)
        {
            this.diceCount = diceCount;
            rnd = new Random();     //chat gtp mi poradil jak udělat správně ten Random, mně to nefungovalo,
                                    //protože jsem to psall všechno dohromady do toho for cyklu a pak mi dával řadu stejnejch čísel  
        }
        public void diceThrow()
        {
            for (int i = 0; i <= diceCount - 1; i++)
            {
                int number = rnd.Next(1, 7); //7 aby tam byla zahrnutá i šestka
                Console.Write($"{number} ");
                sum += number;               
            }
            Console.Write('\n');
            Console.WriteLine($"Calkový suočet hodnot všech kostek je: {sum}");
            //Random rnd = new Random();
            //int number = rnd.Next(1, 7);
            //Console.Write(number);
        }

    }
}
