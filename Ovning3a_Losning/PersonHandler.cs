using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3a_Losning
{
    public class PersonHandler
    {
        private List<Person> persons;

        public PersonHandler()
        {
            persons = new List<Person>();
        }

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public Person CreatePerson(string fname, string lname, int age)
        {
            var person = new Person(fname, lname);
            SetAge(person, age);
            persons.Add(person);
            return person;
        }

        public void PrintAllPersons()
        {
            foreach (var person in persons)
            {
                Console.WriteLine(person.PrintPersonInfo());
            }
        }

        public void SeedPeople()
        {
            CreatePerson("Tor", "Hermansson", 32);
            CreatePerson("Beatrice", "Mansson", 22);
            CreatePerson("Per", "Berg", 36);
        }
    }
}
