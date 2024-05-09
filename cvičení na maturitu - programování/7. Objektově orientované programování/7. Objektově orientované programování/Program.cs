using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Objektově_orientované_programování
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toto je program pro losováí čísel");            
            Console.WriteLine();
            Console.WriteLine("Chcete vylosovat první číslo -> zmáčkněte jakoukoliv klávesu");            
            Console.ReadKey();
            //vytvoření nové instance mojí třídy Losovac
            Losovac myLosovac = new Losovac();
            char volba = '0';
            // hlavní cyklus
            while (volba != '3')
            {
                // výpis možností
                Console.WriteLine("1 - Losovat další číslo");
                Console.WriteLine("2 - Vypsat čísla");
                Console.WriteLine("3 - Konec");
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                // reakce na volbu
                switch (volba)
                {
                    case '1':
                        Console.WriteLine($"Padlo číslo: {myLosovac.Los()}"); //celá ta třída je na tyhle dvě možnosti :)
                        break;
                    case '2':
                        Console.WriteLine($"Zatím padla čísla: {myLosovac.Vypis()}");
                        break;
                    case '3':
                        Console.WriteLine("Děkuji za použití programu");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, zadejte prosím znovu.");
                        break;
                }
            }
            Console.ReadKey();

            //ZVLÁDNU TO UDĚLAT ABSOLUTNĚ CELÝ SÁM BEZ JINÝ TŘÍDY, TA TO ZBYTEČNĚ ZKOMPLIKUJE...

            //Console.WriteLine("Toto je program pro losováí čísel");
            //List<int> numberList = new List<int>();
            //Random rnd = new Random();
            //Console.WriteLine();
            //Console.WriteLine("Chcete vylosovat první číslo -> zmáčkněte jakoukoliv klávesu");
            //Console.ReadKey();
            //while (true)
            //{
            //    int number = rnd.Next(1, 101);
            //    numberList.Add(number);
            //    Console.WriteLine($"přidal jsem {number} do našeho listu");
            //    Console.WriteLine("Chcete Losovat další kolo? ano/ne");
            //    string again = Console.ReadLine();
            //    if (again != "ano")
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("Děkujeme za losování našich čísel, zde jsou vypsaná:");
            //foreach (int n in numberList)
            //{
            //    Console.Write(n + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("A zde jsou seřazená podle velikosti:");
            //numberList.Sort();
            //foreach (int n in numberList)
            //{
            //    Console.Write(n + " ");
            //}
            //Console.ReadKey();
        }
    }
}
