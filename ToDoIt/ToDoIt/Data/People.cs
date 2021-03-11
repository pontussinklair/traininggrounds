using ToDoIt.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Data
{
    public class People

    {

        private static Person[] personList = new Person[0];

        public int Size()
        {
            return personList.Length;
        }
        public Person[] FindAll()
        {
            return personList;
        }
        public Person FindById(int ID)
        {
            //personList är en kö av person
            foreach (Person aPersonInTheArray in personList)  //för varje person i kön
            {
                if (aPersonInTheArray.PersonID == ID) //om personen har id= personID , returnera personen
                {
                    return aPersonInTheArray;
                }

            }
            return null;
        }
        public Person NewPerson(string firstName, string lastName)
        {
           Person person = new Person(PersonSequencer.nextPersonID(), firstName, lastName);
         
            Array.Resize(ref personList, personList.Length + 1);
            personList[personList.Length - 1] = person;

                return person;
        }
    

        public void ClearPerson()
        {
            Array.Clear(personList, 0, personList.Length - 1); //Vilken Array, vart ska det börja, vart ska det sluta.
        }
        public void RemoveArrayElement(Person person)
        {

        }
     
    }
}