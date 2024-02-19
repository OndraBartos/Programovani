using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Procvicovani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine(); //načtu první číslo od uživatele
            int num1 = int.Parse(a);

            string b = Console.ReadLine(); //načtu druhé číslo od uživatele
            int num2 = int.Parse(b);

            Console.WriteLine($"tvoje čísla: {num1}, {num2}"); //vypsání do konzole

            int sum = num1 + num2;
            Console.WriteLine(sum);
            int sub = num1 - num2;
            Console.WriteLine(sub);
            int multiply = num2 * num1;
            Console.WriteLine(multiply);
            float divide = (float)num1 / (float)num2;
            Console.WriteLine(divide);

            //Console.WriteLine($"{sum}, {sub}, {multiply}, {divide}");

            float exp = (float)Math.Exp(divide);
            float sqrt = (float)Math.Sqrt(divide);

            Console.WriteLine($"{exp}, {sqrt}");

            if (sum >= 0)
            {
                Console.WriteLine("suma je kladná");
            }
            else
            {
                Console.WriteLine("suma je záporná");
            }

            if (sub > multiply)
            {
                Console.WriteLine("rozdíl je větší než násobek");
            }
            else
            {
                Console.WriteLine("rozdíl je menší než násobek");
            }

            if (sum > sub && multiply > divide)
            {
                Console.WriteLine("sum je větší než sub + multiply je větší než divide");
            }
            else
            {
                Console.WriteLine("třetí if neplatí");
            }

            Console.WriteLine("zadej velikost pole");
            string width = Console.ReadLine();
            int x = int.Parse(width);
            int[] numArray = new int[x]; //vytvořím nové pole o velikosti 100 
            int indexOfArray = 0; //nastavím počáteční index pole na nulu
            char[] charArray = new char[x - 1]; //velikost char array je o jedno menší než velikost pole čísel
            int charIndex = 0;

            Console.WriteLine("nyní můžete psát čísla, pro ukončení napište stop");

            while (true)
            {               
                string command = Console.ReadLine(); //máme jak pro čísla tak pro stop

                if (command == "stop") //ukončí cyklus pokud napíše stop
                { 
                    break;
                }
                if (indexOfArray >= numArray.Length) //ukončí cyklus pokud už máme hodně čísel a nestačí nám pole
                {
                    Console.WriteLine("Pole je plné, nelze zadat více čísel.");
                    break;
                }
                
                if (int.TryParse(command, out int cislo))//pokud uživatel zadal číslo, převedeme ho na integer a uložíme do pole
                {
                    numArray[indexOfArray] = cislo;
                    indexOfArray++;
                }
                else //pokud nezadá číslo nebo stop
                {
                    Console.WriteLine("Neplatný vstup, zadej platné číslo nebo 'stop'.");
                }
            }
            Console.WriteLine("Zadána čísla:");
            for (int i = 0; i < indexOfArray; i++)
            {
                Console.Write(numArray[i] + " ");
            }

            while (true)
            {
                string vstup = Console.ReadLine();

                // Pokud je pole operací plné, informujeme uživatele a ukončíme cyklus
                if (charIndex >= charArray.Length)
                {
                    Console.WriteLine("Pole operací je plné, nelze zadat více operací.");
                    break;
                }

                // Pokud uživatel zadal platnou operaci (+ nebo -), uložíme ji do pole operací
                if (vstup == "+" || vstup == "-")
                {
                    charArray[charIndex] = vstup[0]; // Ukládáme jen první znak
                    charIndex++;
                }
            }

            // Pokud byla zadána chybná kombinace čísel a operací, ukončíme program
            if (indexOfArray != charIndex + 1)
            {
                Console.WriteLine("Chybná kombinace čísel a operací.");
                return;
            }

            int vysledek = numArray[0];
            for (int i = 0; i < charIndex; i++)
            {
                if (charArray[i] == '+')
                {
                    vysledek += numArray[i + 1];
                }
                else if (charArray[i] == '-')
                {
                    vysledek -= numArray[i + 1];
                }
            }

            Console.WriteLine("Výsledek: " + vysledek);



            Console.ReadKey();
        }
    }
}
