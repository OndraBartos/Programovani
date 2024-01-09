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
            Console.WriteLine("Toto je hra Kostky od Ondřeje Bartoše, užijte si hraní  :)");
            Console.WriteLine('\n');

            Console.WriteLine("Nejdříve si nahrajte vašeho hráče");
            Console.WriteLine("Zadejte jméno, (ENTER) a pak počáteční vklad peněz");
            string name = Console.ReadLine();
            string a = Console.ReadLine();
            int balance = int.Parse(a);
            Player myPlayer = new Player(name, balance);

            Console.WriteLine("Zadejte počet kostek s jakým budete chtít hrát.");
            string b = Console.ReadLine();
            int diceCount = int.Parse(b);
            Dice myDice = new Dice(diceCount);
            myDice.diceThrow();

            Console.WriteLine("Zvolte počet botů, proti kterým budete hrát");
            string c = Console.ReadLine();
            int playersCount = int.Parse(c);
            int botBalance = myPlayer.getBalance()/2;

            OtherPlayers otherPlayers = new OtherPlayers(playersCount, botBalance);
            List<Player> PlayersList = otherPlayers.showPlayers();

            Console.WriteLine("Kolik chceš vsadit pro další kolo");
            string x = Console.ReadLine();
            int myBetValue = int.Parse(x);
            myPlayer.myBet(myBetValue);

            otherPlayers.enemyBet(myBetValue);

            int diceResult = myDice.diceThrowValue();   //zavolám si public int z classy Dice abych mohl hodnotu sum používat zde jako diceresult
            Console.WriteLine($"funguje mi diceThrowValue? {diceResult}");


            Console.ReadKey();
        }
    }
}
