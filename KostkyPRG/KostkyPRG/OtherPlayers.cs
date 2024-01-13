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
        public List<Player> EnemyPlayerList; //založení seznamu
        public int initialBalance;
        public Random rnd; //opět jako minule musím dát random mimo for cyklus a dát  poblic random i sem
        public Player enemyPlayer; //enemyPlayer musí být definován v celé třídě abych s ním mohl pracovat ve více funkcích
        //public int randomBet;       nelze to ukládat jednoduše do jednoho int jako u uživatele, proto seznam
        //public List<int> randomBets; //nový seznam pro uložení sázek botů 
        public OtherPlayers(int playersCount, int botBalance)
        {
            //EnemyPlayerList = new List<Player>(); //seznamy jsem videl skoro prvně, takže umělá inteligence pomáhala sepsat správně do kódu a umístění :)
            GeneratePlayers(playersCount, botBalance);
            //randomBets = new List<int>(); // zavedení nového seznamu pro sázky
            //rnd = new Random();
        }
        public void GeneratePlayers(int playersCount, int botBalance) //funkce vezme číslo, který zadáme a podle toho vygeneruje počet botů
        {
            EnemyPlayerList = new List<Player>();
            for (int i = 1; i <= playersCount; i++) //for cyklus na tvoření nových botů
            {
                string name = $"EnemyPlayer{i}";  //zadám jméno a ůvodní kapitál - balance
                //initialBalance = botBalance;
                Player enemyPlayer = new Player(name, botBalance); //zavolám si funkci z jiné classy - Player, kterou jsem si předtím zapsal sebe jako hráče, a pomocí ní si vytvořím protihráče - boty
                EnemyPlayerList.Add(enemyPlayer); //nový člen seznamu se jménem enemyPlayer už je vytvořen, stačí mi ho přidat do seznamu
            }
        }
        //public int GetEnemyBalance()
        //{
        //    return enemyPlayer.balance;
        //}
        //public void 
        public void showPlayers() //nová funkce showPlayers mi vypíše seznam
        {
            Console.WriteLine("Aktuální stav ostatních hráčů:");
            foreach (Player enemyPlayer in EnemyPlayerList)
            {
                Console.WriteLine($"{enemyPlayer.playerName}- Balance = {enemyPlayer.balance}");
            }
        }
        public void enemyBet(int enemyBetValue) //výše sázky
        {
            Console.WriteLine("Ostatní hráči dorovnali sázky:");
            foreach (Player enemyPlayer in EnemyPlayerList.ToList()) //ToList() vytvoří kopii seznamu?                                                           
            {                                                   //díky tomuto může vyřazovat více botů najednou když jich víc nemá dostatečný balance
                if (enemyPlayer.balance >= enemyBetValue) //pokud na to má vsadí spolu s ostatními
                {   //funguje stejně jako u uživatele v třídě Player protože jsou boti tvořeni přes stejný konstruktor - Player "něco" = new Player
                    enemyPlayer.balance = enemyPlayer.balance - enemyBetValue;
                    //Console.WriteLine($"Sázka {enemyBetValue} od {enemyPlayer.playerName} uložena");
                    Console.WriteLine($"Nová balance účtu {enemyPlayer.playerName} je {enemyPlayer.balance}");
                }
                else //pokud na to nemá vypadává a vyřadí ho to
                {    //ostatní enemyPlayers stále hrají stejně a hra beží dál, jen jsme již odstranili prvního soupeře
                    Console.WriteLine($"{enemyPlayer.playerName} nemá dostatek peněz na sázku a byl vyřazen ze hry.");
                    EnemyPlayerList.Remove(enemyPlayer);
                }
            }
        }
        public void enemyBetOnNumber(int diceCount) //na jaké číslo sází
        {
            rnd = new Random();
            //randomBets.Clear(); //před každým kolem - vymaže předchozí hodnotu aby se mi nepřepisovali jako minule
            Console.WriteLine("Sázky od ostatních:");
            foreach (Player enemyPlayer in EnemyPlayerList)
            {
                //Random rnd = new Random(); //zase jsem psal random sem a pak mi to nefungovalo
                int randomBet = rnd.Next(diceCount, (diceCount * 6) + 1); // použijeme metodu diceThrowValue pro generování náhodné sázky
                           //diceCount je minimální hodnota
                           //diceCount * 6 to celý plus jedna je maximální hodnota
                           //- plus jedna ze stejnýho důvodu proč jsme u kostek psali 7 místo 6 - aby zahrnoval i nejvrchnější číslo jaké chceme
                enemyPlayer.choice = randomBet;  //uloží jejich sázky do randomBet abych s tím pak později mohl pracovat
                //randomBets.Add(randomBet); //přidá randomBet do seznamu
                Console.WriteLine($"{enemyPlayer.playerName}: {randomBet}");
            }
        }
        //public int enemyNumber()
        //{
        //    return randomBet;   - původní nefunkčí (čísla se přepisujou)
        //}

        //public int enemyNumber(int playerIndex)           - nový způsob, ale už ho nepotřebuju ://
        //{
        //    return randomBets[playerIndex]; //vrátí sázku pro konkrétního bota
        //}
    }
}
