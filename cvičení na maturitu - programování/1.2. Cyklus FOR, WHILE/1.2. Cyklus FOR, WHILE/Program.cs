using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2.Cyklus_FOR__WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //JENOM ZJISTÍ ZDA JE DANÉ ČÍSLO PRVOČÍSLO
            //Console.WriteLine("Vítejte v maturitním programu na oveřování prvočísel");
            //while (true) 
            //{
            //    Console.WriteLine("zadejte číslo které chcete ověřit");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    int result = 0;

            //    for (int i = 2; i < x; i++)
            //    {
            //        int delitel = i;
            //        if ((x % delitel) == 0)
            //        {
            //            Console.WriteLine($"číslo {x} je dělitelné {delitel} beze zbytku, tím pádem není prvočíslo");
            //            result = result + 1;
            //            break;

            //        }
            //    }
            //    if (result == 0)
            //    {
            //        Console.WriteLine("číslo není dělitelné žádným z předešlích dělitelů," +
            //                "tím pádem je dělitelné pouze samosebou a je prvočíslo");
            //    }
            //    Console.WriteLine("Chcete pokračovat s dalším číslem? ano/ne");
            //    string again = Console.ReadLine();
            //    if (again == "ne")
            //    {
            //        break;
            //    }
            //}

            //POKUD DANÉ ČÍSLO NENÍ PRVOČÍSLO VYPÍŠE JEHO DĚLITELE A NEJBLIŽŠÍ NIŽŠÍ PRVOČÍSLO
            Console.WriteLine("Vítejte v maturitním programu na oveřování prvočísel");
            while (true)
            {
                Console.WriteLine("zadejte číslo které chcete ověřit");
                int x = Convert.ToInt32(Console.ReadLine());
                int result = 0;

                for (int i = 2; i < x; i++)
                {
                    int delitel = i;
                    if ((x % delitel) == 0)
                    {
                        Console.WriteLine($"číslo {x} je dělitelné {delitel} beze zbytku, tím pádem není prvočíslo");
                        result = result + 1;
                        Console.WriteLine($"Dělitel: {delitel}");
                        //break;
                    }
                }
                if (result == 0)
                {
                    Console.WriteLine("číslo není dělitelné žádným z předešlích dělitelů," +
                            "tím pádem je dělitelné pouze samosebou a je prvočíslo");
                }
                else if (result != 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("hledáme nejbližší nižší prvočíslo:");

                    int newResult = 0;
                    for (int i = x - 1; i >= 2; i--)
                    {
                        for (int j = 2; j < i; j++)
                        {
                            int delitel = j;
                            if ((i % delitel) == 0)
                            {
                                Console.WriteLine($"číslo {i} je dělitelné {delitel} beze zbytku, tím pádem není prvočíslo");
                                newResult = newResult + 1;
                                break;
                            }
                        }
                        if (newResult == 0)
                        {
                            Console.WriteLine($"Nové číslo {i} není dělitelné žádným z předešlích dělitelů," +
                                    "tím pádem je dělitelné pouze samosebou a je prvočíslo");
                            Console.ReadKey();
                            break;
                        }
                    }
                    
                }
                Console.WriteLine("Chcete pokračovat s dalším číslem? ano/ne");
                string again = Console.ReadLine();
                if (again == "ne")
                {
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
