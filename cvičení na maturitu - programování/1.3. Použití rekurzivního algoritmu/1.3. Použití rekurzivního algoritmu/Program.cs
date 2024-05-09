using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _1._3.Použití_rekurzivního_algoritmu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true) 
            {
                Console.WriteLine("Zadej číslo u kterého chceš vypočítat Faktoril" +
                    " a zjistit hodnotu jeho členu ve Fibonačiho posloupnosti");
                int n = Convert.ToInt32(Console.ReadLine());
                int result1 = Factorial(n);
                int result2 = FibonaciNeREK(n); //nerekurzivně
                int result3 = FibonaciREK(n); //rekurzivně
                Console.WriteLine($"z čísla {n} je Faktoriál: {result1}," +
                    $" a {n}tý člen Fibonaciho posloupnosti je: {result2} a {result3} na porovnání");


                Console.WriteLine("chcete pokračovat? ano/ne");
                string again = Console.ReadLine();
                if (again != "ano")
                {
                    break;
                }
            }
            Console.ReadKey();
        }
        static int Factorial(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("Nelze zadat nulu");
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                int factorialResult = n * Factorial(n - 1);
                return factorialResult;
            }
        }
        
        static int FibonaciREK(int n)
        {
            //rekurzivně:
            int fibonaciResult;
            //rekurze++; //kdybych chtěl potom vědět kolikrát jsem musel cyklus opakovat abych se dostal k výsledku
            if (n <= 1) //nulté a první fib. č.
            {
                fibonaciResult = n;
            }
            else
            {
                fibonaciResult = FibonaciREK(n - 1) + FibonaciREK(n - 2);
            }
            return fibonaciResult;

            //nejde zadat jenom takhle: fibonaciResult = FibonaciREK(n - 1) + FibonaciREK(n - 2);
            //musí tam být ten if, nevim proč                        
        }
        static int FibonaciNeREK(int n)
        {
            //nerekurzivně:
            int fibonaciResult;
            if (n <= 1) //nulté a první fib. č.
            {
                {
                    fibonaciResult = n;
                }

            }
            else
            {
                int a = 0; //nulté fib. č., dále pak představuje fib. č. (n-2)
                int b = 1; //první fib. č., dále pak představuje fib. č. (n-1)
                int c = 0; //pomocná proměnná, představuje fib. č. (n)
                for (int i = 1; i < n; i++)
                {
                    //rekurze++; //kdybych chtěl potom vědět kolikrát jsem musel cyklus opakovat abych se dostal k výsledku
                    c = b + a; //fib(n) = fib(n-1) + fib(n-2)           //pro další iteraci uděláme z ...
                    a = b; //...fib(n-1) -> fib(n-2)
                    b = c; //...fib(n) -> fib(n-1)
                    //... a pak se cyklus opakuje, dokud je to potřeba
                }
                fibonaciResult = c;
            }
            return fibonaciResult;
        }
    }
}
