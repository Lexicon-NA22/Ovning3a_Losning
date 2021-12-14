using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3a_Losning
{
    public class Person
    {
       
            private int age;
            private string firstName, lastName;


            public int Age
            {
                get { return age; }
                set
                {
                    if (value < 1)
                    {
                        throw new ArgumentException("Person must be at least one year old!");
                    }
                    age = value;
                }
            }

            public string FirstName
            {
                get { return firstName; }
                set
                {
                    if (value.Length < 2 || value.Length > 10)
                    {
                        throw new ArgumentException("First name must be between 2 and 10 characters!");
                    }
                    firstName = value;
                }
            }

            public string LastName
            {
                get { return lastName; }
                set
                {
                    if (value.Length < 3 || value.Length > 15)
                    {
                        throw new ArgumentException("Last name must be between 3 and 15 characters!");
                    }
                    lastName = value;
                }
            }

            public Person(string fname, string lname)
            {
                firstName = fname;
                lastName = lname;
            }

            public void PrintPersonInfo()
            {
                Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}.");
            }


        
    }
}
