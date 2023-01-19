using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA1_AnimalGroup
{
    abstract class Animal
    {
        //Private variables for the animal attributes
        private string name;
        private int age;
        private string noise;
        private int weight;

        //These are all used to access variables in the other classes
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Noise
        {
            get { return noise; }
            set { noise = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        //Function for printing all of the animal information
        public abstract void PrintInfo();
        public abstract string MakeNoise(string noise);
        public abstract int AgeUp(string name, int age);
        public abstract void UserInput(string animalName, int animalAge, int animalWeight);

    }
    class Cat : Animal
    {
        public override void PrintInfo()
        {
            Console.WriteLine("Animal: Cat");
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Age: " + Age);
                Console.WriteLine("Noise: " + Noise);
                Console.WriteLine("Weight: " + Weight + " lb");
        }
       
        public override string MakeNoise(string noise)
        {
            Console.WriteLine("Noise: " + Noise);
            return noise;
        }
        public override int AgeUp(string name, int age)
        {
            Console.WriteLine("Aged by 1 year");
            age++;
            return age;
        }
        public override void UserInput(string animalName, int animalAge, int animalWeight)
        {
            Name = animalName;
            Age = animalAge;
            Noise = "meow";
            Weight = animalWeight;
        }
    }

    class Cassowary
    {

    }
    class Fox
    {

    }
    class AnimalMain
    {
        static void Main(string[] args)
        {
            string userIn;
            Animal newAnimal;
            string nameIn;
            int ageIn;
            int weightIn;
            Console.WriteLine("1. Add a New Animal");
            Console.WriteLine("2. Make a Year Pass");
            Console.WriteLine("3. Print the Animal's Sound");
            Console.WriteLine("4. Print out a List of the Animals");
            Console.WriteLine("5. Exit");
            Console.Write("Make Your Selection Now: ");
            userIn = Console.ReadLine();
            Console.ReadKey();

            while (userIn != "5")
            {
                if (userIn == "1")
                {
                    string animalChoice;
                    Console.WriteLine("What animal do you want to add?");
                    Console.WriteLine("1. Cat, 2. Cassowary, 3. Fox");
                    if (animalChoice == "1") { newAnimal = new Cat(); }
                    //else if (animalChoice == "2") { newAnimal = new Cassowary(); }
                    //else if (animalChoice == "3") { newAnimal = new Fox(); }
                }
                if (userIn == "2")
                {

                }
                if (userIn == "3")
                {

                }
                if (userIn == "4")
                {

                }

            }



        }
    }
}
