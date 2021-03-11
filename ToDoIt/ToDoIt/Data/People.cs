using System;
using ToDoIt.Model;

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
        /*Lägga till en metod som när ny person som adderas till -
               Array:en och sedan skickar tillbaka det skapade objektet från PersonSequencer - 
               för ett unikt ID*/

        /*public void ClearPersons()
        {
            Array.Clear(personList, 0, personList.Length - 1); //Vilken Array, vart ska det börja, vart ska det sluta.
        }*/

        public void ClearPersons()
        {
            personList = new Person[0];
        }

        /*public void Remove(int personId)
        {
            personList = personList.Where(person => person.PersonId != personId).ToArray();
        }*/


        public void RemoveObject(Person person)
        {
            int index = 0;

            for (int i = 0; i < personList.Length; i++)
            {
                if (personList[i].Equals(person))
                {
                    index = i;
                    break;
                }
            }

            for (int i = index; i < personList.Length - 1; i++)
            {
                personList[i] = personList[i + 1];
            }

            Array.Resize(ref personList, personList.Length - 1);

        }
    }
}












            /* Person p = person[personId];
             return p;
         }
         public static Person NewPerson()
         {
             //TODO: Test if last slot in array har personID.
             Person p = new Person();
             Array.Resize<Person>(ref person, person.Length + 1);
             person[person.Length - 1] = p;
             return p;
         }
         public static Person NewPerson(string firstName, string lastName)
         {
             //TODO: Test if last slot in array har personID.
             Person p = new Person(firstName, lastName);
             Array.Resize<Person>(ref person, person.Length + 1);
             person[person.Length - 1] = p;
             return p;
         }
         public static Person[] Clear()
         {
             Array.Resize<Person>(ref person, 0);
             PersonSequencer.Reset();
             return person;
         }*/
        
    