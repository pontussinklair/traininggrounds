using System;
using System.Collections.Generic;
using System.Text;


namespace ToDoIt.Model
{
    public class Todo
    {
        readonly int todoid;
        string description;
        bool done;
        Person assignee;
        

        public Todo(int todoId)//constructor
        {
            this.todoid = todoId;
        }
        public Todo(int todoId, string description)
            : this(todoId)
        {
            this.description = description;
            this.done = false;
        }

        public int TodoId
        {
            get
            {
                return todoid;
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    description = value;
                }

            }
        }

        public bool Done
        {
            get { return done; }
            set { done = value; }
        }
        public Person Assignee
        {
            get { return assignee; }
            set { assignee = value; }

        }
              
    }
}

