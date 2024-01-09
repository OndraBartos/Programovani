using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KostkyPRG
{
    internal class Player //nová clása player pro vytvoření mého hráčského účtu a následující moje sázky
    {
        public string playerName;
        public int balance;
        public int choice;
        public Player(string playerName, int balance) //vytvořený stejně jako v ClassPlayground
        {
            this.playerName = playerName;
            this.balance = balance;

            Console.WriteLine($"Vložen nový hráč, jménem: {playerName} s počátečním kapitálem: {balance}");
        }
        public void myBet(int myBetValue) //funkce pro výši sázky
        {
            //Console.WriteLine("Zadej svou sázku pro další kolo");
            //string x = Console.ReadLine();
            //int myBetValue = int.Parse(x);
            Console.WriteLine($"Sázka {myBetValue} uložena");
            balance = balance - myBetValue;
            Console.WriteLine($"Váš aktuální zůstatek je {balance}");
        }
        public int getBalance()
        {
            return balance;
        }
        public void myChoice()  //funkce pro sázku na číslo
        {
            Console.WriteLine("Napište na jaké číslo si chcete vsdadit");
            string a = Console.ReadLine();
            int choice = int.Parse(a);
            Console.WriteLine($"Sázíte na číslo {choice}"); //zase na zkoušku         
        }
        public int ChoiceValue()
        {
            return choice;
        }

    }
}
