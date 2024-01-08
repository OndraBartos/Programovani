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
        public List<Player> PlayerList;
        public OtherPlayers(int playersCount)
        {
            PlayerList = new List<Player>();
            GeneratePlayers(playersCount);
        }
        public void GeneratePlayers(int playersCount)
        {
            for (int i = 1; i <= playersCount; i++)
            {
                string name = $"Player{i}";
                int initialBalace = 100;
                Player player = new Player(name, initialBalace);
                PlayerList.Add(player);
            }
        }
        public List<Player> showPlayers()
        {
            return PlayerList;
        }
    }
}
