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

    //1) BONUS - Až vytvoříš Rectangle, zkus vytvořit obdobnou třídu se stejnou funkcionalitou pro kruh nebo třeba trojúhelník.

    internal class Rectangle
    {
        public float height;
        public float width;

        public Rectangle(float width, float height)  //konstruktor
        {
            this.height = height;
            this.width = width;
        }
        public void CalculateArea()
        {
            float area = height * width;
            Console.WriteLine($"Plocha obdelníku je: {area}");
        }
        public void CalculateAspectRatio()
        {
            float aspectRatio = (float)width / height;
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
        public bool CalculatePoint(float x, float y)
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

    internal class Circle
    {
        public float radius;
        int CenterX;
        int CenterY;

        public Circle(float radius, int centerX, int centerY)  //konstruktor - zadám poloměr a souřadnice středu kruhu (na pozdější funkci CalculatePoint)
        {
            this.radius = radius;
            CenterX = centerX;
            CenterY = centerY;
        }
        public void CalculateArea()
        {
            float pi = (float)Math.PI;     //musím dát float i před tu hodnotu too pí jínak mi to píše "Cannot convert..."
            float area = radius * radius * pi;
            Console.WriteLine($"Plocha kruhu je: {area}");
        }
        //CalculateAspectRatio nejde protože nemá strany a není to obdélník
        public bool CalculatePoint(float m, float n)
        {
            //musím vypočítat vzdálenost dvou bodů (středu a zjišťovaného bodu) a pak ji porovnat s poloměrem
            float distanceFromCenter = (float)Math.Sqrt(Math.Pow((CenterX - m),2) + Math.Pow((CenterY - n),2));
            //Math.Sqrt je jednoduchá odmocnina - Math.Sqrt(číslo)
            //Math.Pow je mocnění a potřebuje napsat i číslo exponentu - Math.Pow(číslo, exponent)
            if (distanceFromCenter <= radius) //podmínky kdy leží uvnitř
            {                                 //pokud je distanc menší nebo rovno polomentru znamená to že je vevnitř nebo na kruhu
                return true;
            }
            else //pokud nejsou splněny podmínky kdy leží vně znamená to že leží mimo = false
            {
                return false;
            }

        }
    }
}
