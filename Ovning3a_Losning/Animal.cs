using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3a_Losning
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NrOfLegs { get; set; }

        public Animal(string name, int age, int nrOfLegs)
        {
            Name = name;
            Age = age;
            NrOfLegs = nrOfLegs;
        }

        public abstract void DoSound();

        public virtual string Stats()
        {
            return $"This animals name is {Name}. It is {Age} years old and has {NrOfLegs} number of legs.";
        }
    }

    public class Horse : Animal, IPerson
    {
        public string Breed { get; set; }
        public Horse(string name, int age, int nrOfLegs, string breed) : base(name, age, nrOfLegs)
        {
            Breed = breed;
        }
        public override void DoSound()
        {
            Console.WriteLine("*gnägg gnägg*");
        }

        public override string Stats()
        {
            return base.Stats() + $" The breed is: {Breed}.";
        }

        public void Talk()
        {
            Console.WriteLine("Jag är en kentaur!");
        }
    }

    public class Bird : Animal
    {
        public string Color { get; set; }

        public Bird(string name, int age, int nrOfLegs, string color) : base(name, age, nrOfLegs)
        {
            Color = color;
        }

        public override void DoSound()
        {
            Console.WriteLine("*kvitter kvitter*");
        }

        public override string Stats()
        {
            return base.Stats() + $" It has a beautiful {Color} color.";
        }

    }

    public class Pelican : Bird
    {
        public bool IsMale { get; set; }
        public Pelican(string name, int age, int nrOfLegs, string color, bool isMale) : base(name, age, nrOfLegs, color)
        {
            IsMale = isMale;
        }

        public override void DoSound()
        {
            Console.WriteLine("*pelikankvitter*");
        }

        public override string Stats()
        {
            return base.Stats() + $" is male? {IsMale}";
        }


    }

    public class Dog : Animal
    {
        public string Personality { get; set; }

        public Dog(string name, int age, int nrOfLegs, string personality) : base(name, age, nrOfLegs)
        {
            Personality = personality;
        }
        public override void DoSound()
        {
            Console.WriteLine("*voff voff*"); ;
        }

        public override string Stats()
        {
            return base.Stats() + $"Personality: {Personality}";
        }

        public void DoTrick()
        {
            Console.WriteLine("*rolls over*");
        }
    }

    public class Wolf : Animal
    {
        public bool IsLoneWolf { get; set; }

        public Wolf(string name, int age, int nrOfLegs, bool isLoneWolf) : base(name, age, nrOfLegs)
        {
            IsLoneWolf = isLoneWolf;
        }
        public override void DoSound()
        {
            Console.WriteLine("*howl*"); ;
        }

        public override string Stats()
        {
            return base.Stats() + $"Is loner? {IsLoneWolf}";
        }
    }


    public class WolfMan : Wolf, IPerson
    {

        public WolfMan(string name, int age, int nrOfLegs, bool isLoneWolf) : base(name, age, nrOfLegs, isLoneWolf)
        {
        }

        public void Talk()
        {
            Console.WriteLine("Hej jag kan också prata!");
        }
    }
}
