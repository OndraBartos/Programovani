using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KostkyPRG
{
    internal class Game
    {
        private Player myPlayer;
        private Dice myDice;
        private OtherPlayers otherPlayers;
        private int playersCount;
        public Game() 
        {
            InitializeGame();
        }
        private void InitializeGame()
        {
            myPlayer = null;  //zařazení proměnných
            myDice = null;
            otherPlayers = null;
        }
        public void firstRound()
        {
            Console.WriteLine("Nejdříve si nahrajte vašeho hráče");
            Console.WriteLine("Zadejte jméno, (ENTER) a pak počáteční vklad peněz");
            string name = Console.ReadLine();
            string a = Console.ReadLine();
            int balance = int.Parse(a);
            myPlayer = new Player(name, balance); //nahrání "účtu" uživatele

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Zadejte počet kostek s jakým budete chtít hrát.");
            string b = Console.ReadLine();
            int diceCount = int.Parse(b);
            myDice = new Dice(diceCount); //nahrání počtu kostek
                        
            Console.Clear();
            Console.WriteLine("Zvolte počet botů, proti kterým budete hrát");
            string c = Console.ReadLine();
            playersCount = int.Parse(c);
            int botBalance = myPlayer.getBalance() / 2; //počáteční peníze botů budou polovina peněz uživatele

            otherPlayers = new OtherPlayers(playersCount, botBalance);
            //otherPlayers.showPlayers(); //vypsání ostatních hráčů

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Kolik chceš vsadit pro další kolo");
            string d = Console.ReadLine();
            int myBetValue = int.Parse(d);
            myPlayer.myBet(myBetValue);//moje výška sázky
            otherPlayers.enemyBet(myBetValue);//sázka ostatních stejná jako moje

            Console.ReadKey();
            Console.Clear();
            //jaké vsadím já číslo
            myPlayer.myChoice();
            int myNumberToBet = myPlayer.myNumber();
            //Console.WriteLine($"funguje mi myNumberToBet? {myNumberToBet}");
            //boti vsadí číslo
            otherPlayers.enemyBetOnNumber(diceCount); //sází v rozhraní kostek, ale záleží na počtu kostek proto diceCount


            //foreach( Player enemyPlayer in otherPlayers.EnemyPlayerList)     - původní nefunkčí (čísla se přepisujou)
            //{
            //    int randomBet = otherPlayers.enemyNumber();
            //    Console.WriteLine($"vypsání randomBet od {enemyPlayer.playerName}: {randomBet}");
            //}
            //for (int i = 0; i < otherPlayers.EnemyPlayerList.Count; i++)
            //{
            //    int randomBet = otherPlayers.enemyNumber(i);
            //    Console.WriteLine($"vypsání randomBet od {otherPlayers.EnemyPlayerList[i].playerName}: {randomBet}");
            //}
            //tady nahoře jsem se strašně dlouho snažil vypsat ty čísla co vsadí boti a pak mi došlo že to nepotřebuju
            //takže můžu zase ten druhej seznam zakomentovat

            Console.ReadKey();
            Console.Clear();
            //potom co dáme výši sázky a vsadíme si na svoje čísla hází počítač kostkou/kostkama
            myDice.diceThrow();
            int diceResult = myDice.diceThrowValue();   //zavolám si public int z classy Dice abych mohl hodnotu sum používat zde jako diceresult
            Console.WriteLine($"Výherní číslo je: {diceResult}");

            int myDifference = Math.Abs(diceResult - myNumberToBet); //moje odchylka od správného čísla
            Console.WriteLine($"Můj rozdíl je: {myDifference}");
            Console.Write('\n');

            int closestEnemyDifference = int.MaxValue; //nepřátelská odchylka od správného čísla
            foreach (Player enemyPlayer in otherPlayers.EnemyPlayerList)
            {       //ve foreach cyklu postupně projede všechny boty a zjistí která je nejblíž vítěznému číslu                    
                int enemyDifference = Math.Abs(diceResult - enemyPlayer.choice);
                Console.WriteLine($"Rozdíl od {enemyPlayer.playerName}: {enemyDifference}");

                if (enemyDifference < closestEnemyDifference) //když je některý blíž než ten předchozí, tak je přepíše
                {
                    closestEnemyDifference = enemyDifference;
                }
            }
            Console.WriteLine($"Nejbližší odchylka od vítězného čísla u protihráčů: {closestEnemyDifference}");

            Console.ReadKey();
            Console.Clear();
            //konečně se dozvíme kdo vyhrál
            if (myDifference < closestEnemyDifference) //pokud mám menší rozdíl jak boti vyhrávám já
            {
                myPlayer.balance += myBetValue * (playersCount + 1); //přičtou se mi na účet peníze - výhra = výška sázky hrát počet hráčů (boti + já)
                Console.WriteLine("Vyhráli jste gratulace, jen ať se peníze točí dál");
                Console.WriteLine($"Nový stav vašeho účtu je: {myPlayer.balance}");
            }
            else if (myDifference == closestEnemyDifference) //pokud máme stejný rozdíl tak nevyhrál nikdo a všíchni máme smůlu
            {
                Console.WriteLine("Smůla, trefil jsi stejný číslo jako protihráč = nevyhrává nikdo. Zkus to znovu a nezapomeň, kdo nehraje nevyhraje!");
            }
            else //pokud nevyhraju já nebo nemáme stejný výherní čísla tak vyhrávaj boti
            {
                Console.WriteLine("Smůla, prohrál si. Zkus to znovu a nezapomeň, kdo nehraje nevyhraje!");
                Player winningBot = null; //s pomocí AI
                foreach (Player enemyPlayer in otherPlayers.EnemyPlayerList)
                {
                    int enemyDifference = Math.Abs(diceResult - enemyPlayer.choice);
                    //znovu počítám enemyDifference, protože to jsou dva různé foreach cykly
                    if (winningBot == null || enemyDifference < Math.Abs(diceResult - winningBot.choice))
                    {
                        winningBot = enemyPlayer;
                    }
                }
                if (winningBot != null) //přičtení výhry tomu, kdo měl nejmenší rozdíl
                {
                    winningBot.balance += myBetValue * (playersCount + 1);
                    Console.WriteLine($"Výhra pro {winningBot.playerName}! Nový stav jeho účtu je: {winningBot.balance}");
                }
            }
            Console.WriteLine($"Uživatel {myPlayer.playerName} má aktuální kapitál: {myPlayer.balance}");
            otherPlayers.showPlayers(); //vypsání ostatních hráčů
            Console.ReadKey();


            //bool continuePlaying = true;
            //while (continuePlaying)
            //{
            //    nextRound(); //volání funkce pro další kolo
            //    Console.WriteLine("Chcete hrát další kolo? (ano/ne)");
            //    string answer = Console.ReadLine();

            //    if (answer.ToLower() != "ano")
            //    {
            //        continuePlaying = false;
            //    }
            //}
        }
        public void nextRound()
        {
            Console.Clear();
            Console.WriteLine("Kolik chceš vsadit pro další kolo");
            string d = Console.ReadLine();
            int myBetValue = int.Parse(d);
            myPlayer.myBet(myBetValue);//moje výška sázky
            otherPlayers.enemyBet(myBetValue);//sázka ostatních stejná jako moje

            Console.ReadKey();
            Console.Clear();
            //jaké vsadím já číslo
            myPlayer.myChoice();
            int myNumberToBet = myPlayer.myNumber();
            //Console.WriteLine($"funguje mi myNumberToBet? {myNumberToBet}");
            //boti vsadí číslo
            otherPlayers.enemyBetOnNumber(myDice.diceCount); //sází v rozhraní kostek, ale záleží na počtu kostek proto diceCount

            Console.ReadKey();
            Console.Clear();
            //potom co dáme výši sázky a vsadíme si na svoje čísla hází počítač kostkou/kostkama
            myDice.diceThrow();
            int diceResult = myDice.diceThrowValue();   //zavolám si public int z classy Dice abych mohl hodnotu sum používat zde jako diceresult
            Console.WriteLine($"Výherní číslo je: {diceResult}");

            int myDifference = Math.Abs(diceResult - myNumberToBet); //moje odchylka od správného čísla
            Console.WriteLine($"Můj rozdíl je: {myDifference}");
            Console.Write('\n');

            int closestEnemyDifference = int.MaxValue; //nepřátelská odchylka od správného čísla
            foreach (Player enemyPlayer in otherPlayers.EnemyPlayerList)
            {       //ve foreach cyklu postupně projede všechny boty a zjistí která je nejblíž vítěznému číslu                    
                int enemyDifference = Math.Abs(diceResult - enemyPlayer.choice);
                Console.WriteLine($"Rozdíl od {enemyPlayer.playerName}: {enemyDifference}");

                if (enemyDifference < closestEnemyDifference) //když je některý blíž než ten předchozí, tak je přepíše
                {
                    closestEnemyDifference = enemyDifference;
                }
            }
            Console.WriteLine($"Nejbližší odchylka od vítězného čísla u protihráčů: {closestEnemyDifference}");

            Console.ReadKey();
            Console.Clear();
            //konečně se dozvíme kdo vyhrál
            if (myDifference < closestEnemyDifference) //pokud mám menší rozdíl jak boti vyhrávám já
            {
                myPlayer.balance += myBetValue * (playersCount + 1); //přičtou se mi na účet peníze - výhra = výška sázky hrát počet hráčů (boti + já)
                Console.WriteLine("Vyhráli jste gratulace, jen ať se peníze točí dál");
                Console.WriteLine($"Nový stav vašeho účtu je: {myPlayer.balance}");
            }
            else if (myDifference == closestEnemyDifference) //pokud máme stejný rozdíl tak nevyhrál nikdo a všíchni máme smůlu
            {
                Console.WriteLine("Smůla, trefil jsi stejný číslo jako protihráč = nevyhrává nikdo. Zkus to znovu a nezapomeň, kdo nehraje nevyhraje!");
            }
            else //pokud nevyhraju já nebo nemáme stejný výherní čísla tak vyhrávaj boti
            {
                Console.WriteLine("Smůla, prohrál si. Zkus to znovu a nezapomeň, kdo nehraje nevyhraje!");
                Player winningBot = null; //s pomocí AI
                foreach (Player enemyPlayer in otherPlayers.EnemyPlayerList)
                {
                    int enemyDifference = Math.Abs(diceResult - enemyPlayer.choice);
                    //znovu počítám enemyDifference, protože to jsou dva různé foreach cykly
                    if (winningBot == null || enemyDifference < Math.Abs(diceResult - winningBot.choice))
                    {
                        winningBot = enemyPlayer;
                    }
                }
                if (winningBot != null) //přičtení výhry tomu, kdo měl nejmenší rozdíl
                {
                    winningBot.balance += myBetValue * (playersCount + 1);
                    Console.WriteLine($"Výhra pro {winningBot.playerName}! Nový stav jeho účtu je: {winningBot.balance}");
                }
            }
            Console.WriteLine($"Uživatel {myPlayer.playerName} má aktuální kapitál: {myPlayer.balance}");
            otherPlayers.showPlayers(); //vypsání ostatních hráčů
            Console.ReadKey();
        }
        public void RunGame()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Chcete hrát další kolo? (ano/ne)");
                string response = Console.ReadLine(); //.ToLower(); - kdyby uživatel napsal odpověď velkýma písmenama
                                                      //tak je převede na malá aby to mohl if uznat jako právnou odpověď
                if (response != "ano") //pokud nenapíše ano hra se ukončí
                {
                    Console.WriteLine("Konec hry. Děkuji za hraní!");
                    break;  // Ukončí smyčku
                }

                nextRound();
            }
        }
    }
}
