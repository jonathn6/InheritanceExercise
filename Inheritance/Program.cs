using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird birdObject = new Bird()
            {
                Species = "toucan",
                Name = "Sam",
                Legs = 2,
                OwnersName = "Kellogg's",
                Beak = true,
                Feathers = true,
                Fly = true,
                LiveInTree = true,
            };


            Console.WriteLine("Here is the bird we just created:");
            Console.WriteLine($"{birdObject.Name} is a {birdObject.Species} owned by {birdObject.OwnersName}.");
            Console.WriteLine($"Does {birdObject.Name} have a beak, have feathers, flies, and lives in a tree?");
            Console.WriteLine($"{birdObject.Beak}, {birdObject.Feathers}, {birdObject.Fly}, and {birdObject.LiveInTree}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile reptileObject = new Reptile()
            {
                Species = "Crocodile",
                Name = "Pam",
                Legs = 4,
                OwnersName = "The Bronx Zoo",
                IsColdBlooded = true,
                HasScales = true,
                Environment = "swamp",
                Defense = "sharp teeth",
            };


            Console.WriteLine("Here is the reptile we just created:");
            Console.WriteLine($"{reptileObject.Name} is a {reptileObject.Species} owned by {reptileObject.OwnersName}.");
            Console.WriteLine($"{reptileObject.Name} lives in a {reptileObject.Environment} and uses {reptileObject.Defense} for defense");
            Console.WriteLine($"Are {reptileObject.Species}s cold blooded? {reptileObject.IsColdBlooded}");
            Console.WriteLine($"Do {reptileObject.Species} have scales? {reptileObject.HasScales}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("");
        }
    }
}
