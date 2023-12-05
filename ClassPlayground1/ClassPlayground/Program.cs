using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassPlayground
{
    internal class Program
    {
        class Human
        {
            private int age;
            public int height;
            public int weight;
            public string hairColour;
            public string eyeColour;
            public string name;

            public Human(int age, int height, int weight)
            {
                this.age = age;
                this.height = height;
                this.weight = weight; //když dám před to this, tak mu tím upřesním že chci aby bral tuhle height/weight... ne u někoho jiného
            }

            public Human(int age, int height, int weight, string hairColour, string eyeColour, string name)
            {
                this.age = age;
                this.height = height;
                this.weight = weight;
                this.hairColour = hairColour;
                this.eyeColour = eyeColour;
                this.name = name;
            }

            public void PrintCharasteristics()
            {
                string printedName = name;
                if (printedName == null)
                {
                    printedName = "Bezejmený člověk";
                }
                Console.WriteLine($"{printedName} je starý/á {age} let a měří {height}");
            }

            public float BMI()
            {
                float heightForCalculation = height / 100f;
                float bMI = weight / (heightForCalculation * heightForCalculation);
                return bMI;
            }

            public int GetAge()
            {
                return age;
            }

            public void SetAge(int age)
            {
                if (age < 0 || age > 120) // značka nebo || (pomocí Alt Gr + w)
                {
                    Console.WriteLine("Tento věk není možné zadat");
                }
                else
                {
                    this.age = age;
                }               
            }

            public void SetAge(string age)
            {
                bool isNumber = int.TryParse(age, out int ageNumber);
                if (isNumber)
                {
                    this.age = ageNumber;
                    Console.WriteLine($"Věk člověka {name} změněn na {ageNumber}");
                }
                else
                {
                    Console.WriteLine("zadej číslo");
                }
            }
        }
        static void Main(string[] args)
        {
            Human human1 = new Human(32, 168, 65, "brown", "blue", "Karel");
            //human1.age = 32;
            //human1.height = 168;
            //human1.weight = 65;
            //human1.hairColour = "Brown";
            //human1.eyeColour = "Blue";
            //human1.name = "Karel";
            //Console.WriteLine($"{human1.name} je starý/á {human1.age} let a měří {human1.height}");
            human1.PrintCharasteristics();
            float bmi = human1.BMI();
            Console.WriteLine($"{human1.name} má BMI: {bmi}");

            Human human2 = new Human(20, 205, 90);
            //human2.age = 20;
            //human2.height = 205;
            //human2.weight = 90;
            human2.PrintCharasteristics();

            Human human3 = new Human(10, 130, 80);
            Console.WriteLine($"Dítě má BMI: {human3.BMI()}");

            Console.WriteLine(human1.GetAge());

            human2.SetAge(50); //nastavím věk (číslem)
            Console.WriteLine(human2.GetAge()); //vypíše věk

            human2.SetAge(155);
            Console.WriteLine(human2.GetAge());

            human2.SetAge("2"); //můžu zadat i textově
            Console.WriteLine(human2.GetAge());

            Console.ReadKey();
        }
    }
}
