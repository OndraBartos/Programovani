using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalclass
{
    internal class Program
    {
        class Animal
        {
            public string name;
            public int averageMaxAge;
            public int endangerent;

            public virtual void animalNoise()
            {
                Console.WriteLine("zvířecí zvuky");
            }
        }
        class Dog : Animal
        {
            public int numberOfPuppies;
            public string race;

            public override void animalNoise()
            {
                Console.WriteLine("haf haf");
            }

        }
        class Cat : Animal
        {
            public bool lovesMilk;
            public string furColor;

            public override void animalNoise()
            {
                Console.WriteLine("mňau mňau nigga");
            }
        }

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.name = "Fido";
            dog.race = "buldog";
            Console.WriteLine($"{dog.name} je rasou {dog.race}");
            //dog.Bark();

            Cat cat = new Cat();
            cat.name = "Míca";

            Console.Write("\n");
            cat.animalNoise();
            dog.animalNoise();

            Console.ReadKey();
        }
    }
}
