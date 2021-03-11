using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt.Data;
using ToDoIt.Model;
using ToDoIt.Tests.Model;

namespace ToDoIt.Tests.Data
{

    public class TodoitemsTests
    {
        [Fact]
        public void SizeOfArray()
        {

            //Arrange
            TodoItems todoItems = new TodoItems();


            //Act
            int startsize = todoItems.Size();
            todoItems.Newtodo("Work");
            todoItems.Newtodo("Run");
            int resultsize = todoItems.Size();

            //Assert
            Assert.True((startsize + 2) == resultsize);
        }
        [Fact]
        public void SizeOfArrayNotZero()
        {

            //Arrange
            TodoItems todoItems = new TodoItems();

            //Act
            int startsize = todoItems.Size();

            int resultsize = todoItems.Size();

            //Assert
            Assert.True((startsize) == resultsize);

        }

        [Fact]
        public void SizeOfArrayMoreTodo()
        {

            //Arrange
            TodoItems todoItems = new TodoItems();
            todoItems.Clear();
            //Act
            int startsize = todoItems.Size();
            todoItems.Newtodo("run");
            todoItems.Newtodo("work");
            todoItems.Newtodo("sleep");
            todoItems.Newtodo("jump");
            todoItems.Newtodo("read");
            int resultsize = todoItems.Size();

            //Assert
            Assert.Equal(5, resultsize);

        }
        [Fact]
        public void FindbyId()
        {
            Todo todo;
            TodoItems todoItems = new TodoItems();


            //Arrange
            todoItems.Newtodo("run");
            todoItems.Newtodo("work");
            todoItems.Newtodo("eat");


            //Act
            todo = todoItems.FindById(1);

            //Assert
            Assert.Equal("run", todo.Description);
            Assert.Equal(1, todo.TodoId);

            todo = todoItems.FindById(2);
            Assert.Equal("work", todo.Description);
            Assert.Equal(2, todo.TodoId);

        }
        [Fact]
        public void Findall()
        {

            TodoItems todoItems = new TodoItems();
            todoItems.Clear();

            todoItems.Newtodo("run");
            todoItems.Newtodo("work");
            todoItems.Newtodo("eat");

            Todo[] allTodoItems = todoItems.FindAll();
            Assert.Equal(3, allTodoItems.Length);

            Assert.Equal("run", allTodoItems[0].Description);
            Assert.Equal(1, allTodoItems[0].TodoId);

            Assert.Equal("work", allTodoItems[1].Description);
            Assert.Equal(2, allTodoItems[1].TodoId);

            Assert.Equal("eat", allTodoItems[2].Description);
            Assert.Equal(3, allTodoItems[2].TodoId);


        }
        [Fact]
        public void ClearTest()
        {
            TodoItems todoItems = new TodoItems();


            todoItems.Newtodo("run");
            todoItems.Newtodo("work");
            todoItems.Newtodo("eat");


            todoItems.Clear();



            Assert.Equal(0, todoItems.Size());
        }
        [Fact]
        public void ClearFromPersonArray()
        {
            string todo_1_description = " run ";
            string todo_2_description = " work ";

            int expected = 0;

            TodoSeqencer.reset();
            TodoItems todoItems = new TodoItems();
            Todo todo_1 = todoItems.Newtodo(todo_1_description);
            Todo todo_2 = todoItems.Newtodo(todo_2_description);

            todoItems.Clear();

            Assert.Equal(expected, todoItems.Size());
        }

        [Fact]
        public void FindByDone()
        {
            string todo_1_description = " run ";
            bool todo_1_status = true;

            string todo_2_description = " work ";
            bool todo_2_status = false;

            string todo_3_description = " eat ";
            bool todo_3_status = true;

            TodoSeqencer.reset();

            TodoItems todoitems = new TodoItems();

            Todo todo_1 = todoitems.Newtodo(todo_1_description);
            todo_1.Done = todo_1_status;
            Todo todo_2 = todoitems.Newtodo(todo_2_description);
            todo_2.Done = todo_2_status;
            Todo todo_3 = todoitems.Newtodo(todo_3_description);
            todo_3.Done = todo_3_status;

            Todo[] expected = { todo_1, todo_3 };
            Todo[] result = todoitems.FindByDoneStatus(true);

            Assert.Equal(expected, result);
        }
    
    
        [Fact]
        public void Remove()
        {
            string todo_1_description = " run ";
            string todo_2_description = " work ";
            string todo_3_description = " eat";

            TodoSeqencer.reset();
            TodoItems todoItems = new TodoItems();

            Todo todo_1 = todoItems.Newtodo(todo_1_description);
            Todo todo_2 = todoItems.Newtodo(todo_2_description);
            Todo todo_3 = todoItems.Newtodo(todo_3_description);

            Todo[] result = { todo_1,todo_3 };

            todoItems.Remove(todo_2);

            Assert.Equal(result, todoItems.FindAll());

        }
        [Fact]
        public void FindById()
        {
            Todo todo;
            TodoItems todoItems = new TodoItems();
            todoItems.Clear();
            TodoSeqencer.reset();

            todoItems.Newtodo("Run");
            todoItems.Newtodo("Eat");
            todoItems.Newtodo("Sleep");

            todo = todoItems.FindById(1);
            Assert.Equal("Run", todo.Description);
            Assert.Equal(1, todo.TodoId);

            todo = todoItems.FindById(2);
            Assert.Equal("Eat", todo.Description);
            Assert.Equal(2, todo.TodoId);

            todo = todoItems.FindById(3);
            Assert.Equal("Sleep", todo.Description);
            Assert.Equal(3, todo.TodoId);


        }
        [Fact]
        public void FindByAssignee()
        {
            TodoItems todoItems = new TodoItems();
            todoItems.Clear();
            TodoSeqencer.reset();

            todoItems.Newtodo("Run");
            todoItems.Newtodo("Eat");
            todoItems.Newtodo("Sleep");
            todoItems.Newtodo("work");

            Person person1 = new Person(1, "Haris", "Gusinac");
            Person person2 = new Person(2, "Pontus", "Eriksson");

            todoItems.FindById(1).Assignee = person1;
            todoItems.FindById(2).Assignee = person2;
            todoItems.FindById(4).Assignee = person2;

            Todo[] todoAssigneePerson2 = todoItems.FindByAssignee(person2);

            Assert.Equal(2, todoAssigneePerson2.Length);

        }
        [Fact]
        public void FindUnssignedTodoItems()
        {
            TodoItems todoItems = new TodoItems();
            todoItems.Clear();
            TodoSeqencer.reset();

            todoItems.Newtodo("Run");
            todoItems.Newtodo("Eat");
            todoItems.Newtodo("Sleep");
            todoItems.Newtodo("work");

            Person person1 = new Person(1, "Ulf", "Bengtsson");
            Person person2 = new Person(1, "Peter", "Svensson");

            todoItems.FindById(2).Assignee = person1;
            todoItems.FindById(3).Assignee = person2;

            Todo[] unassignedTodo = todoItems.FindUnassignedTodoItems();

            Assert.Equal(2, unassignedTodo.Length);

        }
    }
}
