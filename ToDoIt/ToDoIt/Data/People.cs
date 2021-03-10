using Person.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Data
{
    public class People
   
    {
        
        private static Person[] person = new Person[0];
         
        public static int Size()
        {
            return person.Length;
        }
        public static Person[] FindAll()
        {
            return person;
        }
        public static Person FindById(int personId)
        {
            return;//????????
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
        }
    }