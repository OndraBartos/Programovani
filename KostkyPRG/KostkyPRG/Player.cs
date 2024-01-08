using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KostkyPRG
{
    internal class Player
    {
        public string playerName;
        public int balance;
        public Player(string playerName, int balance)
        {
            this.playerName = playerName;
            this.balance = balance;

            Console.WriteLine($"Vložen nový hráč, jménem: {playerName} s počátečním kapitálem: {balance}");
        }


    }
}
