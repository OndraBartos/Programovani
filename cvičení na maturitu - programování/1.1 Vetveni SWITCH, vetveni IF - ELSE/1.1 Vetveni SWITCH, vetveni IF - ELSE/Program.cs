using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_Vetveni_SWITCH__vetveni_IF___ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //převádění desítkových čísel na binární - dvojkové soustavy
            int num = 5012;
            Console.WriteLine(Convert.ToString(num, 2));
            //převádění desítkových čísel na hexadecimální - šestrnáctkové soustavy
            int num2 = 5012;
            Console.WriteLine(Convert.ToString(num2, 16));



            Console.WriteLine("Vítejte v maturitním rogramu Kalkulačka");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("zadejte první číslo");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("zadejte druhé číslo");
                double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("vyberte početní operaci:");
                Console.WriteLine("+.............sčítání");
                Console.WriteLine("-.............odčítání");
                Console.WriteLine("/.............dělení");
                Console.WriteLine("*.............násobení");
                Console.WriteLine("M.............mocnina prvního čísla na druhé čísló");

                char operace = Convert.ToChar(Console.ReadLine()); 
                double vysledek = 0; //tím že to mám v charu tak mi to vezme cokoliv - písmena, znaky, čísla...
                switch (operace)
                {
                    case '+':
                        vysledek = x + y;
                        break;

                    case '-':
                        vysledek = y - x;
                        break;

                    case '/':
                        vysledek = x / y;
                        break;

                    case '*':
                        vysledek = x * y;
                        break;

                    case 'M':
                        vysledek = Math.Pow(x, y);
                        break; 
                }
                Console.WriteLine($"Váš výsldek je: {vysledek}.");
                Console.WriteLine('\n');
                Console.WriteLine("přejete si pokračovat dál v počítání? (odpověď: ano/ne)");
                string opakovat = Console.ReadLine();
                if( opakovat == "ne")
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Děkujeme za používání naší kalkulačky, program ukončíte stiskem jakékoli klávesy.");


            Console.ReadKey();
        }
    }
}
