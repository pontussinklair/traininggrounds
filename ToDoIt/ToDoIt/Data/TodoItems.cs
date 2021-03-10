using System;
using System.Collections.Generic;
using System.Text;
using ToDoit;
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
            Todo todo = new Todo(TodoSeqencer.nextTodoId(),description);

            Array.Resize(ref todoItems, todoItems.Length + 1);
            todoItems[todoItems.Length-1] = todo;//index -1 för man använder 0.

            return todo;
        }
        public void Clear()
        {
            Array.Clear(todoItems, 0, todoItems.Length - 1);//Vilken array, vart ska man börja rensa,vart ska den sluta -1 length.
        }

    }
}


