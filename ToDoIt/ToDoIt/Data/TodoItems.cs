using System;
using System.Collections.Generic;
using System.Text;
using ToDoIt.Data;
using ToDoIt.Model;

namespace ToDoIt.Data
{
    public class TodoItems
    {

        static Todo[] todoItems = new Todo[0];
        public  int Size()
        {
            return todoItems.Length;
        }
        public  Todo[] FindAll()
        {
            return todoItems;
        }
        public  Todo FindById(int Id)
        {

            foreach (Todo aTodo in todoItems)
            {
                if (aTodo.TodoId == Id)
                {
                    return aTodo;
                }
                
            }
            return null;
            
        }
        public Todo Newtodo(string description)
        {
            Todo todo = new Todo(TodoSeqencer.nextTodoId(), description);

            Array.Resize(ref todoItems, todoItems.Length + 1);
            todoItems[todoItems.Length - 1] = todo;//index -1 för man använder 0.
           

            return todo;


        }
        public  void  Clear()//Dont work!!!!!! 
        {
            Array.Resize(ref todoItems, 0);
            //Array.Clear(todoItems, 0, todoItems.Length - 1);
        }
        public Todo [] FindByDoneStatus (bool doneStatus)
        {
            Todo[] completed = new Todo[0];

            foreach (Todo todo in todoItems)
            {
                if (todo.Done == true)
                {
                    Array.Resize(ref completed, completed.Length + 1);
                    completed[completed.Length - 1] = todo;
                }
            }
            return completed;
        }
        public Todo [] FindByAssignee(int personId)
        {
            Todo[] assignee = new Todo[0];
            foreach (Todo todo in todoItems)
            {
                if (todo.Assignee.PersonID == personId)
                {
                    Array.Resize(ref assignee, assignee.Length + 1);
                    assignee[assignee.Length - 1] = todo;
                }
               
                  
            }
            return assignee;
        }
        public Todo[] FindByPersonId(Person assignee)
        {
            Todo[] assigned = new Todo[0];
            foreach (Todo todo in todoItems)
            {
                if (todo.Assignee == assignee)
                {
                    Array.Resize(ref assigned, assigned.Length + 1);
                    assigned[assigned.Length - 1] = todo;
                }
            }
            return assigned;

        }
        public Todo [] FindUnassignedTodoItems()
        {
            Todo[] unAssigneed = new Todo[0];

            foreach (Todo todo in todoItems)
            {
                if (todo.Assignee == null)
                {
                    Array.Resize(ref unAssigneed, unAssigneed.Length + 1);
                    unAssigneed[unAssigneed.Length - 1] = todo;
                }
            }
            return unAssigneed;
        }
        public void RemoveArrayElement (Todo todo)
        {
            int index = 0;

            for (int i =0; i<todoItems.Length; i++)
            {
                if (todoItems[i] == todo)
                {
                    index = i;
                    break;
                }
            }
            for (int i=index; i<todoItems.Length-1; i++)
            {
                todoItems[i] = todoItems[i + 1];
            }
            Array.Resize(ref todoItems, todoItems.Length - 1);
        }

    }
}


