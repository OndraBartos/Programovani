using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace KostkyPRG
{
    internal class OtherPlayers
    {
        public List<Player> PlayerList; //založení seznamu
        public int initialBalance;
        
        public OtherPlayers(int playersCount, int botBalance)
        {
            PlayerList = new List<Player>(); //seznamy jsem videl skoro prvně, takže umělá inteligence pomáhala sepsat správně do kódu a umístění :)
            GeneratePlayers(playersCount, botBalance);
        }
        public void GeneratePlayers(int playersCount, int botBalance) //funkce vezme číslo, který zadáme a podle toho vygeneruje počet botů
        {
            for (int i = 1; i <= playersCount; i++) //for cyklus na tvoření nových botů
            {
                string name = $"EnemyPlayer{i}";  //zadám jméno
                initialBalance = botBalance;          //a ůvodní kapitál - balance
                Player enemyPlayer = new Player(name, botBalance); //zavolám si funkci z jiné classy - Player, kterou jsem si předtím zapsal sebe jako hráče a pomocí ní si vytvořím protihráče - boty
                PlayerList.Add(enemyPlayer); //nový člen seznamu se jménem enemyPlayer už je vytvořen, stačí mi ho přidat do seznamu
            }
        }
        public List<Player> showPlayers() //nová funkce showPlayers mi vypíše seznam
        {
            return PlayerList;
        }
        public void enemyBet(int enemyBetValue)
        {
            initialBalance = initialBalance - enemyBetValue;
            Console.WriteLine($"Sázka nepřítele {enemyBetValue} uložena");
            Console.WriteLine($"Nová balance účtu botů {initialBalance}");

        }
    }
}
