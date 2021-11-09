using System;

namespace Inheritance
{
    class Program
    {
        private static string desert;

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
            var cardinal = new Bird() { CanFly = true, IsAlive = true, DoMigrate = true, LaysEggs = true, };



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

                var rattlesnake = new Reptile()
                { IsColdBlooded = true,
                    IsScaly = true,
                    Habitat = "desert",
                    CanGrowTail = true
                };

            
            Bird penguin = new Bird() { Age = 10, CanFly = false, DoMigrate = true, HasFeathers = true, IsAlive = true,};
            penguin.PrintDetails();
            
        }
    }
}
