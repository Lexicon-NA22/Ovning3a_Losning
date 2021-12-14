using System;

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

            var animal1 = new Pelican("Pelle Pelikan", 3, 2, "Brun", true);
            Console.WriteLine(animal1.Stats());
        }
    }
}
