using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //MOJE MUSÍM VŽDY DOPSAT KDYŽ POUŽÍVÁM KRESLENÍ - PEN, BRUSH...

namespace znovaOOP
{
    public class Circle
    {
        public int x; public int y;
        public int size;
        public Pen myPen;

        public void zvetsit()
        {
            size = size + 10;
        }
        public void zmensit()
        {
            size = size - 10;
        }
    }
    public class Potomek : Circle
    {
        public int x; public int y;
        public int x2; public int y2;
        public void doLeva()
        {
            x = x - 2;
        }
        public void doPrava()
        {
            x = x + 2;
        }
    }
}
