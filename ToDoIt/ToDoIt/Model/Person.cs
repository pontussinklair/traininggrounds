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

    

        public Person(int personID, string firstName, string lastName)//Constructor
        {
            this.personID = personID;
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
                if (string.IsNullOrEmpty(value))
                {
                    firstName = "No firstname";
                }
                else
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
                if (string.IsNullOrEmpty(value))
                {
                    lastName = " No lastname";
                }
                else
                {
                    lastName = value;
                }
            }
        }

    }
}