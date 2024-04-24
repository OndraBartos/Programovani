using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Procvic
{
    using System.Drawing;//!!!nutno vždycky dopsat!!!
    internal class Kruh
    {
        public int x, y;
        public int velikost; //budu používat na width a height
        public Pen myPen;

        public void Zvetsit()
        {
            velikost = velikost + 10;
        }
        public void Zmensit()
        {
            velikost = velikost - 10;
        }
    }
    class Potomek: Kruh //Potomek je podtřída Kruhu, umí to co kruh a navíc to co mu napíšu jenom jemu
    {
        public void doPrava()
        {
            x = x + 10;
        }
        public void doLeva()
        {
            x = x - 10;
        }
    }
}
