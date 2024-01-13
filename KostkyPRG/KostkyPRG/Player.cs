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
            if (balance >= myBetValue) //pokud na to máme vsadíme
            {
                Console.WriteLine($"Sázka {myBetValue} uložena");
                balance = balance - myBetValue;
                Console.WriteLine($"Váš aktuální zůstatek je {balance}");
            }
            else //pokud na to nemáme znamená to, že jsme prohráli a hra tím končí
            {
                Console.WriteLine("Nedostatečný balance");
                Console.WriteLine("GAME OVER, PROHRÁL JSI  :((");
                //return true (nebo něco takovýho možná); musím vymyslet něco jak tady ukončit program jako prohru           
            }
        }
        public int getBalance()
        {
            return balance;
        }
        public void myChoice()  //funkce pro sázku na číslo
        {
            Console.WriteLine("Napište na jaké číslo si chcete vsadit");
            string a = Console.ReadLine();
            choice = int.Parse(a);
            Console.WriteLine($"Sázíte na číslo {choice}"); //zase na zkoušku         
        }
        public int myNumber() //tohle si můžu zavolat v jiné třídě abych mohl zjistit vítěze
        {
            return choice;
        }
                
    }
}
