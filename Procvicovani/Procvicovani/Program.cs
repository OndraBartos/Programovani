using System;
using System.Collections.Generic;
using System.Linq;
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
                Console.WriteLine("rozdílje větší než násobek");
            }
            else
            {
                Console.WriteLine("rozdílje menší než násobek");
            }

            if (sum > sub && multiply > divide)
            {
                Console.WriteLine("sum je větší než sub + multiply je větší než divide");
            }
            else
            {
                Console.WriteLine("třetí if neplatí");
            }



            Console.ReadKey();
        }
    }
}
