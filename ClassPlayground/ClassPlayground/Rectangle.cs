using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    //1) Vytvoř třídu Rectangle, kterou budeme reprezentovat obecný obdélník
    //Přidej třídě Rectangle dvě proměnné - width a height(datový typ nechám na tobě)
    //Přidej třídě Rectangle tři funkce - CalculateArea, která spočítá obsah plochy obdélníka
    //                                  - CalculateAspectRatio, která spočítá poměr stran.Využij spočítaný poměr k určení toho, jestli je obdélník široký, vysoký, nebo je to čtverec
    //                                  - ContainsPoint, která jako vstupní parametr přijme souřadnice x, y nějakého bodu a určí, jestli se daný bod nachází v obdélníku, nebo ne,
    //                                  a podle toho vrátí true/false                                       
    //Přidej třídě Rectangle konstruktor, který bude přijímat dva parametry - šířku a výšku, a při jeho zavolání je správně nastaví

    internal class Rectangle
    {
        public int height;
        public int width;

        public Rectangle(int width, int height)
        {
            this.height = height;
            this.width = width;
        }

        public void CalculateArea()
        {
            int area = height * width;
            Console.WriteLine($"Plocha obdelníku je: {area}");
        }

        public void CalculateAspectRatio()
        {
            float aspectRatio = width / height;
            if ( aspectRatio > 1 )
            {
                Console.WriteLine("obdelník je široký");
            }
            if ( aspectRatio < 1 )
            {
                Console.WriteLine("obdelník je vysoký");
            }
            if (aspectRatio == 1)
            {
                Console.WriteLine("čtverec");
            }
        }

        public bool CalculatePoint(int x, int y)
        {
            if ( x < 0 || y < 0) //podmínky kdy leží mimo
            {
                return false;
            }
            if (x > width || y > height) //podmínky kdy leží mimo
            {
                return false;
            }
            else //pokud nejsou splněny podmínky kdy leží mimo znamená to že leží uvnitř = true
            {
                return true;
            }
        }


    }
}
