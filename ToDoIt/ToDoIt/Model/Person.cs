using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Model
{
    public class Person//Fields
    {
        private readonly int personID;
        private string firstName;
        private string lastName;

        public Person(int personID)// Constructor med en input parameter
        {
            this.personID = personID;
        }

        public Person(int personID, string firstName, string lastName) : this(personID)//Constructor
        {

            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int PersonID
        {
            get { return personID; }
        }
        public string FirstName//Properties
        {
            get { return firstName; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    firstName = value;
                }
            }
        }
        public string LastName//Properties
        {
            get { return lastName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    lastName = value;
                }
            }
        }

    }
}