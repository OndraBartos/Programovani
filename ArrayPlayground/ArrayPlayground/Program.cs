using System;
using System.Linq;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti čísly.
            int[] myArray = { 0, 10, 20, 30, 40, 50 }; //kdybych chtěl jiná než celá čísla musím použít třeba float nebo double, ale musel bych to pak změnit úplně všude

            //TODO 2: Vypiš do konzole všechny prvky pole, zkus klasický for, kde i využiješ jako index v poli, a foreach (vysvětlíme si).
            for (int i = 0; i < 6; i++) //místo i < 5 jde použít i < myArray.Length (vidím dole) je to lepší při psaní složitějších polí/Array, abych nemusel psát
            {
                Console.WriteLine(myArray[i]);
            }

            //for (int i = 0;i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            foreach (int number in myArray) //mám seznam hodnot, a řeknu mu že v každý hodnotě chci ho uložit jako můj novej int number kterej mi to pak console.writeline vypíše
            {
                Console.WriteLine(number);
            }

            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            int sum = 0; // u každé mové int musím nejdřív zadat že je nula pro případ že s ní budu rovnou počítat (aby měla nějakou hodnotu)
            for (int i = 0; i < myArray.Length; i++)
            {
                //sum = sum + myArray[i]; dělá úplně to samé do dolní řádek
                sum += myArray[i]; // += znamená k sum přičti myArray[i]
                                   // můžu měnit znaménka -->  /= *= -=
            }
            Console.WriteLine("Suma je " + sum);

            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            int average = 0;
            average = sum / myArray.Length; // průměr je suma děleno délkou pole/array - počet členů
            Console.WriteLine("Průměr je " + average);

            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max = 0;
            max = myArray.Max();
            Console.WriteLine("Maximum je " + max);

            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.   //můžu to udělat úplně stejně jako max
            int min = int.MaxValue; // musím nastavit něco jiného než nulu pro případ že v poli bude nějaké číslo menší než nula
            //min = myArray.Min();
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                }
            }
            Console.WriteLine("Minimum je " + min);

            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            int usernumber = int.Parse(Console.ReadLine()); //toto dělá vstup uživateli že může zadat číslo a ono ho to přečte
            bool foundnumber = false;
            for (int i = 0; i <= myArray.Length; i++)
            {
                if (usernumber == myArray[i])
                {
                    foundnumber = true;
                    Console.WriteLine($"Našel jsem číslo {usernumber} je na indexu {i}");
                    break; // dám tady break aby mi zbytečně nekontroloval jestli je číslo v seznamu, aby to bylo rychlejší a u delšího seznamu je to potřeba
                }
            }
            if (foundnumber = false)
            {
                Console.WriteLine($"Hledané číslo {usernumber} se v poli/seznamu nevyskytuje");
            }

            //TODO 8: Změň tvorbu integerového pole tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9. Vytvoř si na to proměnnou typu Random.
            Random rng = new Random();
            myArray = new int[100];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rng.Next(0, 10);
                Console.WriteLine($"Na indexi {i} je číslo {myArray[i]}");
            }

            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];
            foreach (int number in myArray)
            {
                counts[number]++;
            }

            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine($"Číslo {i} se vyskytuje {counts[i]} krát");
            }

            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.
            int[] mySecondArray = new int[100];
            for (int i = mySecondArray.Length - 1; i >= 0; i--)
            {
                mySecondArray[i] = myArray[99 - 1];
            }
            Console.WriteLine("První pole");
            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }  

            //tomuhle nerozumim ani hovno

            Console.ReadKey();
        }
    }
}
