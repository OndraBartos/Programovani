using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KostkyPRG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine('\n');
            ASCII_ARt newArt = new ASCII_ARt();  //třída na art...
            newArt.welcome();  //nápis welcome v konzoli
            Console.WriteLine('\n');
            Console.WriteLine("Toto je hra Kostky od Ondřeje Bartoše, užijte si hraní" +
                "       (pro start stiskněte jakoukoli klávesu)");
            Console.ReadKey();
            Console.Clear();

            Game game = new Game();
            game.firstRound(); //první kolo hry
            game.RunGame(); //dá na výběr pokračovat nebo ne 

            
            Console.ReadKey();
        }
    }
}
