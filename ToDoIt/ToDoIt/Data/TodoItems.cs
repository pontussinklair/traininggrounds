using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt.Data
{
    public class TodoItems
    {

        static TodoItems[] todoitems = new TodoItems[0];
        public static int Size()
        {
            return todoitems.Length;
        }
        public static TodoItems[] FindAll()
        {
            return todoitems;
        }
        public static TodoItems FindById(int TodoId)
        {
            return
        }


    }
}
}

