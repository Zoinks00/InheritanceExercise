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
            var penguin = new Bird();

            {
                penguin.Arms = 0;
                penguin.Lips = false;
                penguin.Beak = "Short beak";
                penguin.Feathers = true;
                penguin.Eyes = 2;
                penguin.Legs = 2;
                penguin.Flight = false;
                penguin.Wings = 2;
            };

            Console.WriteLine($"I have {penguin.Arms} arms but I have {penguin.Wings} wings.");
            Console.WriteLine($"I have lips? {penguin.Lips}.");
            Console.WriteLine($"I have a {penguin.Beak}."); 
            Console.WriteLine($"I have {penguin.Legs} legs and {penguin.Eyes} eyes.");
            Console.WriteLine($"I have feathers? {penguin.Feathers}.");
            Console.WriteLine($"I can fly? {penguin.Flight}.");
            Console.WriteLine("I must be a Penguin.\n\n\n");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var gecko = new Reptile();
            {
                gecko.Arms = 0;
                gecko.Claws = true;
                gecko.Tongue = true;
                gecko.Lips = true;
                gecko.Scales = true;
                gecko.Legs = 4;
                gecko.Tail = true;
                gecko.Eyes = 2;
            };

            Console.WriteLine($"I have {gecko.Arms} arms but I have {gecko.Legs} legs.");
            Console.WriteLine($"My legs have claws? {gecko.Claws}.");
            Console.WriteLine($"I have lips? {gecko.Lips}.");
            Console.WriteLine($"I have a tongue to lick my lips and {gecko.Eyes} eyes with? {gecko.Tongue}.");
            Console.WriteLine($"I have scales? {gecko.Scales}.");
            Console.WriteLine($"I have a tail? {gecko.Tail}.");
            Console.WriteLine("I must be a Gecko.");
        }
    }
}
