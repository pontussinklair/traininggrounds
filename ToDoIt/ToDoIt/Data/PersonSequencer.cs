using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Data
{
    public class PersonSequencer
    {
        private static int personID = 0;

        public static int nextPersonID()
        {
            return ++personID;
        }
        public static int reset()
        {
            personID = 0;
            return personID;
        }


    }
}