using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
         
          /*Create an object of your Bird class
           give values to your members using the object of your Bird class
           Creatively display the class member values */

            Bird doveBird = new Bird()
            {
                Name = "ArialBek",
                HasWings = true,
                HasBackBone = true,
                HasFeathers = true,
                Type = "electric",
            };

            Console.WriteLine();
            Console.WriteLine($"{doveBird.Name} has {doveBird.Legs} legs! It has wings? {doveBird.HasWings}. It also has backbone? {doveBird.HasBackBone}.");


            /*Create an object of your Reptile class
             give values to your members using the object of your Bird class
             Creatively display the class member values */

            Reptile dragonFly = new Reptile() 
            {
                Name = "Angelfish",
                HasScales = true,
                IsColdBlooded = true,
                LayEggs = true,
         
            }; 

            Console.WriteLine();
            Console.WriteLine($"{dragonFly.Name} which is {dragonFly.Age } years old has no scales on its body, true or false? {dragonFly.HasScales} ! It's a cold blooded animal, true or false? {dragonFly.IsColdBlooded}.");
        } 
    }
} 

