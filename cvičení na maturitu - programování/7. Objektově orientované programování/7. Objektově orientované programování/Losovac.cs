using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Objektově_orientované_programování
{
    internal class Losovac
    {
        //inicializace toho co budu používat
        private Random rnd;
        private List<int> numberList;
        public Losovac() 
        {
            rnd = new Random();
            numberList = new List<int>();
        }
        public int Los()
        {
            int number = rnd.Next(1, 101);
            numberList.Add(number);
            return number;
        }
        public string Vypis()
        {
            string s = "";
            numberList.Sort();
            foreach (int i in numberList)
            {
                //s += i + " ";
                s += i.ToString() + " ";
            }
            return s;
        }
    }
}
