using System;
using System.Collections.Generic;

namespace Ovning3a_Losning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PersonHandler ph = new();
            //var ph = new PersonHandler();

            //try
            //{
            //    ph.CreatePerson("Kristina", "Österman", 0);
            //}
            //catch (Exception error)
            //{
            //    Console.WriteLine(error.Message); ;
            //}


            //ph.SeedPeople();
            //ph.PrintAllPersons();

            //------------------------------

            var animals = new List<Animal>
            {
                new Pelican("Pelle Pelikan", 3, 2, "Brun", true),
                new Horse("Polle", 5, 4, "Shire"),
                new Bird("Molly", 2, 2, "Gul"),
                new Dog("Fido", 5, 4, "Tried"),
                new Wolf("Wolverine", 3, 4, true),
                new WolfMan("Wolfie", 40, 2, false)
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());
                animal.DoSound();

                if (animal is Dog)
                {
                    var dog = (Dog)animal;
                    dog.DoTrick();
                }

                //if (animal is WolfMan)
                //{
                //    var wolfman = (WolfMan)animal;
                //    wolfman.Talk();
                //}
                
                if (animal is IPerson)
                {
                    var hybrid = (IPerson)animal;
                    hybrid.Talk();
                }
            }

            var errorList = new List<UserError>
            {
                new TextInputError(),
                new AnotherError()
            };

            foreach (var error in errorList)
            {
                Console.WriteLine(error.UEMessage());
            }
            
        }
    }
}
