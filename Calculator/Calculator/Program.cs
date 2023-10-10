using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace Calculator
{
    internal class Program
    {



        static void Main(string[] args)
        {
            /*
             * Pokud se budes chtit na neco zeptat a zrovna budu pomahat jinde, zkus se zeptat ChatGPT ;) - https://chat.openai.com/
             * 
             * ZADANI
             * Vytvor program ktery bude fungovat jako kalkulacka. Kroky programu budou nasledujici:
             * 1) Nacte vstup pro prvni cislo od uzivatele (vyuzijte metodu Console.ReadLine() - https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=netframework-4.8.
             * 2) Zkonvertuje vstup od uzivatele ze stringu do integeru - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number.
             * 3) Nacte vstup pro druhe cislo od uzivatele a zkonvertuje ho do integeru. (zopakovani kroku 1 a 2 pro druhe cislo)
             * 4) Nacte vstup pro ciselnou operaci. Rozmysli si, jak operace nazves. Muze to byt "soucet", "rozdil" atd. nebo napr "+", "-", nebo jakkoliv jinak.
             * 5) Nadefinuj integerovou promennou result a prirad ji prozatimne hodnotu 0.
             * 6) Vytvor podminky (if statement), podle kterych urcis, co se bude s cisly dit podle zadane operace
             *    a proved danou operaci - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements.
             * 7) Vypis promennou result do konzole
             * 
             * Mozna rozsireni programu pro rychliky / na doma (na poradi nezalezi):
             * 1) Vypis do konzole pred nactenim kazdeho uzivatelova vstupu co po nem chces
             * 2) a) Kontroluj, ze uzivatel do vstupu zadal, co mel (cisla, popr. ciselnou operaci). Pokud zadal neco jineho, napis mu, co ma priste zadat a program ukoncete.
             * 2) b) To same, co a) ale misto ukonceni programu opakovane cti vstup, dokud uzivatel nezada to, co ma
             *       - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
             * 3) Umozni uzivateli zadavat i desetinna cisla, tedy prekopej kalkulacku tak, aby umela pracovat s floaty
             */




            //zadám integery (původně před úpravou na desetiná čísla - stačilo mi změnit int na double, ToInt32 na ToDouble a int result na double result)
            //int a;
            //int b;

            //nyní nově zadám double
            double a;
            double b;

            //na úvod přivítám uživatele kalkulačky
            Console.WriteLine("Konzolová kalkulačka - Ondra Bartoš 4.D");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.WriteLine("                                       ");

            //napíšu uživateli kalkulačky že má zadat číslo plus upravím doubly je tak ať je program přečte jako číslo a ne pouze jako znak (udělám to dvakrát - pro obě proměné)
            Console.WriteLine("Vlož první číslo:");
            string prvnicislo = Console.ReadLine();
            //a = int .Parse(prvnicislo); (jedna možnost jak upravit formát, mně se víc líbilo Convert.ToInt32 protože si lehce vybavuju že jsme to používali na IVT dva roky zpázky)
            //a = Convert.ToDouble(prvnicislo);  musel jsem dát toto do lomítek aby fungoval příkaz while (to samé dole u b)
            //zároveň nevím proč jsem to tak musel udělat ale přišel jsem na to když mi to řeklo visual studio že tam je asi něco špatně

            //program nyní uživateli kalkulačky řekne když zadává špatné číslo
            while (!double.TryParse(prvnicislo, out a))
            {
                Console.WriteLine("Nesprávný formát čísla, zkuste znovu:");
                prvnicislo = Console.ReadLine();
            }

            Console.WriteLine("Vlož druhé číslo:");
            string druhecislo = Console.ReadLine();
            //b = int.Parse(druhecislo);
            //b = Convert.ToDouble(druhecislo);

            //zkopíruju horní kód a akorát přepíšu a na b plus taky prvnicislo na druhecislo
            while (!double.TryParse(druhecislo, out b))
            {
                Console.WriteLine("Nesprávný formát čísla, zkuste znovu:");
                druhecislo = Console.ReadLine();
            }

            //dám možnost výběru matematické operace
            Console.WriteLine("ZADEJTE POČETNÍ OPERACI:");
            Console.WriteLine("       + pro sčítání");
            Console.WriteLine("       - pro odčítání");
            Console.WriteLine("       * pro násobení");
            Console.WriteLine("       / pro dělení");
            Console.WriteLine("       Zaokr pro zaokrouhlení prvního čísla (počet desetinných míst určuje druhé číslo 1-15)");
            Console.WriteLine("       Abs pro absolutní hodnotu prvního čísla");
            Console.WriteLine("       Odmoc pro odmocnění prvního čísla");
            Console.WriteLine("       Log pro logaritmus prvního čísla");
            Console.WriteLine("       Log10 pro logaritmus 10ti prvního čísla");
            Console.WriteLine("       < pro určení menšího ze dvou čísel");
            Console.WriteLine("       > pro určení většího ze dvou čísel");
            Console.WriteLine("       Sin pro vrácení sinusu zadaného úhlu (v Radiánech)");
            Console.WriteLine("       Sin-1 pro vrácení úhlu zadaného sinusu (v Radiánech)");
            Console.WriteLine("       Cos pro vrácení cosinusu zadaného úhlu (v Radiánech)");
            Console.WriteLine("       Cos-1 pro vrácení úhlu zadaného cosinusu (v Radiánech)");
            Console.WriteLine("       Tg pro vrácení tangencu zadaného úhlu (v Radiánech)");
            Console.WriteLine("       Tg-1 pro vrácení úhlu zadaného tangencu (v Radiánech)");

            //podobným způsobem jako předtím u čísel teď zavedu aby to uživateli napsalo když zadá špatnou početní operaci
            string operace = Console.ReadLine();      // == znamená rovná se; != zamená nerovná se; && znamená AND/a (něco takovýho)
            while (operace != "+" && operace != "-" && operace != "*" && operace != "/" 
                && operace != "Zaokr" && operace != "Abs" && operace != "Odmoc" && operace != "Log" 
                && operace != "Log10" && operace != "<" && operace != ">" && operace != "Sin" 
                && operace != "Sin-1" && operace != "Cos" && operace != "Cos-1" && operace != "Tg" && operace != "Tg-1")
            {
                Console.WriteLine("Nesprávná početní operace, zkuste znovu:");
                operace = Console.ReadLine();
            }

            //pomocí funkce switch vypočítá kalkulačka příklad
            double result;
            switch (operace)
            {
                case "+":
                    result = a+b;
                    Console.WriteLine("Váš výsledek je = " + result);
                    break;

                case "-":
                    result = a-b;
                    Console.WriteLine("Váš výsledek je = " + result);
                    break;

                case "*":
                    result = a * b;
                    Console.WriteLine("Váš výsledek je = " + result);
                    break;

                case "/":
                    if (b != 0)
                    {
                        result = a / b;
                        Console.WriteLine("Váš výsledek je = " + result);  
                    }
                    else
                    {
                        Console.WriteLine("nelze dělit nulou");                        
                    }
                    break;

                case "Abs":
                    result = Math.Abs(a);
                    Console.WriteLine("Váš výsledek je = " + result);
                    break;

                case "Zaokr":
                    //musím změnit double b na nový int v aby mi fungovalo určování počtu desetiných míst
                    int v = (int) b;
                    result = Math.Round(a, v);
                    Console.WriteLine("Váš výsledek je = " + result);
                    break;

                case "Odmoc":
                    result = Math.Sqrt(a);
                    Console.WriteLine("Váš výsledek je = " + result);
                    break;

                case "Log":
                    result = Math.Log(a);
                    Console.WriteLine("Váš výsledek je = " + result);
                    break;

                case "Log10":
                    result = Math.Log10(a);
                    Console.WriteLine("Váš výsledek je = " + result);
                    break;

                case "<":
                    result = Math.Min(a, b);
                    Console.WriteLine("Váš výsledek je = " + result);
                    break;

                case ">":
                    result = Math.Max(a, b);
                    Console.WriteLine("Váš výsledek je = " + result);
                    break;

                case "Sin":
                    result = Math.Sin(a);
                    Console.WriteLine("Váš výsledek je = " + result);
                    break;

                case "Sin-1":
                    result = Math.Asin(a);
                    Console.WriteLine("Váš výsledek je = " + result);
                    break;

                case "Cos":
                    result = Math.Cos(a);
                    Console.WriteLine("Váš výsledek je = " + result);
                    break;

                case "Cos-1":
                    result = Math.Acos(a);
                    Console.WriteLine("Váš výsledek je = " + result);
                    break;

                case "Tan":
                    result = Math.Tan(a);
                    Console.WriteLine("Váš výsledek je = " + result);
                    break;

                case "Tan-1":
                    result = Math.Atan(a);
                    Console.WriteLine("Váš výsledek je = " + result);
                    break;


            }

            //snažil jsem se kód upravit tak abych tam měl ten "Console.WriteLine("Váš výsledek je = " + result);" pouze jednou nakonci,
            //ale pak mi to negerovalo žádný výsledek a i když vše fungovalo nic mi to nepsalo,
            //zkoušel jsem to na několik způsobů a nakonec jsem na to bohužel nepřišel

            Console.ReadKey(); //Toto nech jako posledni radek, aby se program neukoncil ihned, ale cekal na stisk klavesy od uzivatele.

        }
    }
}
