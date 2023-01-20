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
        public abstract void MakeNoise();
        public abstract void AgeUp();
        public abstract void UserInput(string animalName, int animalAge, int animalWeight);

    }
    class Cat : Animal
    {
        public override void PrintInfo()
        {
            
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Species: Cat");
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Noise: " + Noise);
            Console.WriteLine("Weight: " + Weight + " lb");
        }
       
        public override void MakeNoise()
        {
            Console.WriteLine(Name + " goes " + Noise);
        }
        public override void AgeUp()
        {
            Console.WriteLine("Happy Birthday " + Name);
            Console.WriteLine();
            Age++;
            Console.WriteLine(Name + " is now " + Age + " year(s) old!");
        }
        public override void UserInput(string animalName, int animalAge, int animalWeight)
        {
            Name = animalName;
            Age = animalAge;
            Noise = "meow";
            Weight = animalWeight;
        }
    }

    class Cassowary : Animal
    {
        public override void PrintInfo()
        {

            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Species: Cassowary");
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Noise: " + Noise);
            Console.WriteLine("Weight: " + Weight + " lb");
        }

        public override void MakeNoise()
        {
            Console.WriteLine(Name + " goes " + Noise);
        }
        public override void AgeUp()
        {
            Console.WriteLine("Happy Birthday " + Name);
            Console.WriteLine();
            Age++;
            Console.WriteLine(Name + " is now " + Age + " year(s) old!");
        }
        public override void UserInput(string animalName, int animalAge, int animalWeight)
        {
            Name = animalName;
            Age = animalAge;
            Noise = "Cassowary_Sound.wav";
            Weight = animalWeight;
        }
    }
    class Fox : Animal
    {
        public override void PrintInfo()
        {

            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Species: Fox");
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Noise: " + Noise);
            Console.WriteLine("Weight: " + Weight + " lb");
        }

        public override void MakeNoise()
        {
            Console.WriteLine(Name + " goes " + Noise);
        }
        public override void AgeUp()
        {
            Console.WriteLine("Happy Birthday " + Name);
            Console.WriteLine();
            Age++;
            Console.WriteLine(Name + " is now " + Age + " year(s) old!");
        }
        public override void UserInput(string animalName, int animalAge, int animalWeight)
        {
            Name = animalName;
            Age = animalAge;
            Noise = "Hehehehehehe";
            Weight = animalWeight;
        }
    }
    //World Object
    class AnimalMain
    {
        static void Main(string[] args)
        {
            string userIn;
            string nameIn;
            int ageIn;
            int weightIn;

            Console.WriteLine("1. Add a New Animal");
            Console.WriteLine("2. Find an Animal's Bio");
            Console.WriteLine("3. Print the Animal's Sound");
            Console.WriteLine("4. Leap 1 year into the future");
            Console.WriteLine("5. Exit");
            Console.Write("Make Your Selection Now: ");
            userIn = Console.ReadLine();
            Console.ReadKey();

            Animal newAnimal = null;
            List<Animal> Roster = new List<Animal>();

            while (userIn != "5")
            {
                if (userIn == "1")
                {
                    string animalChoice;
                    Console.WriteLine("What animal do you want to add?");
                    Console.WriteLine("1. Cat, 2. Cassowary, 3. Fox");
                    Console.Write("Make Your Selection Now: ");
                    animalChoice = Console.ReadLine();

                    
                    if (animalChoice == "1") { newAnimal = new Cat(); }
                    else if (animalChoice == "2") { newAnimal = new Cassowary(); }
                    else if (animalChoice == "3") { newAnimal = new Fox(); }
                    else
                    {
                        Console.WriteLine("ERROR: Not an Option");
                    }

                    if (animalChoice == "1" || animalChoice == "2" || animalChoice == "3")
                    {
                        Console.Write("Enter the Animal's Name: ");
                        nameIn = Console.ReadLine();
                        Console.Write("Enter the Animal's Age: ");
                        ageIn = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the Animal's Weight: ");
                        weightIn = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("Adding " + nameIn + " to the Roster");
                        newAnimal.UserInput(nameIn, ageIn, weightIn);
                        Roster.Add(newAnimal);
                        Console.WriteLine(nameIn + " is now in the Roster!");
                        Console.WriteLine();
                    }

                }
                if (userIn == "2")
                {
                    string nameSearch;
                    Console.Write("Enter the Animal's Name: ");
                    nameSearch = Console.ReadLine();

                    Animal animalBio = Roster.Find(n => n.Name == nameSearch);

                    Console.WriteLine();
                    if (nameSearch != null)
                    {
                        animalBio.PrintInfo();
                    }
                    Console.WriteLine();
                }
                if (userIn == "3")
                {
                    string nameSearch;
                    Console.Write("Enter the Animal's Name: ");
                    nameSearch = Console.ReadLine();

                    Animal animalSound = Roster.Find(n => n.Name == nameSearch);

                    Console.WriteLine();
                    if (nameSearch != null)
                    {
                        animalSound.MakeNoise();
                    }
                    Console.WriteLine();
                }
                if (userIn == "4")
                {
                    string nameSearch;
                    Console.Write("Enter the Animal's Name: ");
                    nameSearch = Console.ReadLine();

                    Animal animalAge = Roster.Find(n => n.Name == nameSearch);

                    Console.WriteLine();
                    if (nameSearch != null)
                    {
                        animalAge.AgeUp();
                    }
                    Console.WriteLine();
                }
                Console.Write("Make Another Selection: ");
                userIn = Console.ReadLine();
                Console.ReadKey();
            }
        }
    }
}
