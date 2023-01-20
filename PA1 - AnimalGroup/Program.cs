//Logan Walsh
//1/20/2023
//This program allows the user to create a list of animals and their attributes

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

        //These are all used to access and assign variables in the other classes
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
        //Returns the noise that the animal makes
        public abstract void MakeNoise();
        //Increases the age of an animal by 1 year
        public abstract void AgeUp();
        //Used when adding new animals to the list
        //animalName -> the name of the animal
        //animalAge -> The age
        //animalWeight -> The weight
        public abstract void UserInput(string animalName, int animalAge, int animalWeight);

    }
    //Concrete class for cats
    class Cat : Animal
    {
        //Overrides functions in abstract class
        public override void PrintInfo()
        {
            //Prints out all of the animal attributes
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Animal: Cat");
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
            //Noise is automatically assigned to any entries in the cat class
            Noise = "meow";
            Weight = animalWeight;
        }
    }
    //Concrete class for Cassowary
    class Cassowary : Animal
    {
        //Functions about the same as the cat one with some slight changes
        public override void PrintInfo()
        {

            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Animal: Cassowary");
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
    //Additional concrete class for foxes
    class Fox : Animal
    {
        //Same as other two classes, aside from minor differences
        public override void PrintInfo()
        {

            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Animal: Fox");
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
    class World
    {
        static void Main(string[] args)
        {
            //Used for the user's selection
            string userIn;
            //The user input for the animal's name
            string nameIn;
            //The user input for the animal's name
            int ageIn;
            //The user input for the animal's name
            int weightIn;

            //Prints a menu listing every choice
            Console.WriteLine("1. Add a New Animal");
            Console.WriteLine("2. Find an Animal's Bio");
            Console.WriteLine("3. Print the Animal's Sound");
            Console.WriteLine("4. Leap 1 year into the future");
            Console.WriteLine("5. Exit");
            //Prompts the user to make a choice
            Console.Write("Make Your Selection Now: ");
            userIn = Console.ReadLine();
            Console.ReadKey();

            //Used for creating a new animal or checking to see if their in the list
            Animal newAnimal = null;
            //The list containing every animal and which class they belong too
            List<Animal> Roster = new List<Animal>();

            while (userIn != "5")
            {
                if (userIn == "1")
                {
                    //Used for picking which type of animal to add
                    string animalChoice;
                    //Prompts the user to make their selection
                    Console.WriteLine("What animal do you want to add?");
                    Console.WriteLine("1. Cat, 2. Cassowary, 3. Fox");
                    Console.Write("Make Your Selection Now: ");
                    animalChoice = Console.ReadLine();

                    //Creates a new animal based on the user's choice
                    if (animalChoice == "1") { newAnimal = new Cat(); }
                    else if (animalChoice == "2") { newAnimal = new Cassowary(); }
                    else if (animalChoice == "3") { newAnimal = new Fox(); }
                    //Lets the user know that you made a choice that wasn't in the list
                    else
                    {
                        Console.WriteLine("ERROR: Not an Option");
                    }

                    //Only works if the user inputted an existing animal choice
                    if (animalChoice == "1" || animalChoice == "2" || animalChoice == "3")
                    {
                        //User inputs the animal's name, age and weight
                        Console.Write("Enter the Animal's Name: ");
                        nameIn = Console.ReadLine();
                        Console.Write("Enter the Animal's Age: ");
                        //Integers have to be converted from strings to work in C#
                        ageIn = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the Animal's Weight: ");
                        weightIn = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("Adding " + nameIn + " to the Roster");
                        //Calls the new animal function
                        newAnimal.UserInput(nameIn, ageIn, weightIn);
                        //New animal is added to the roster
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

                    //Finds the animal in the list
                    Animal animalBio = Roster.Find(x => x.Name == nameSearch);

                    Console.WriteLine();
                    //If the animal is in the list...
                    if (nameSearch != null)
                    {
                        //The animal's bio gets printed
                        animalBio.PrintInfo();
                    }
                    Console.WriteLine();
                }
                if (userIn == "3")
                {
                    string nameSearch;
                    Console.Write("Enter the Animal's Name: ");
                    nameSearch = Console.ReadLine();

                    //Finds the animal in the list
                    Animal animalSound = Roster.Find(x => x.Name == nameSearch);

                    Console.WriteLine();
                    if (nameSearch != null)
                    {
                        //A message gets printed saying what sound the animal makes
                        animalSound.MakeNoise();
                    }
                    Console.WriteLine();
                }
                if (userIn == "4")
                {
                    string nameSearch;
                    Console.Write("Enter the Animal's Name: ");
                    nameSearch = Console.ReadLine();

                    Animal animalAge = Roster.Find(x => x.Name == nameSearch);

                    Console.WriteLine();
                    if (nameSearch != null)
                    {
                        //Animal's age is increased by 1 year
                        animalAge.AgeUp();
                    }
                    Console.WriteLine();
                }
                //Prompts the user to make another selection in the menu
                Console.Write("Make Another Selection: ");
                userIn = Console.ReadLine();
                Console.ReadKey();
            }
        }
    }
}
