using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt.Data;
using ToDoIt.Model;

namespace ToDoIt.Tests.Model
{
    public class TodoIt
    {
        [Fact]
        public void DescriptionIsString()
        {

            //Arrange
            int todoId = 1;
            string description = "work";
            bool done = false;
            Person assignee = new Person(6, "Haris", "Pontus");

            //Act
            Todo todo = new Todo(todoId, description);

            //Assert
            Assert.Equal(todoId, todo.TodoId);
            Assert.Equal(description, todo.Description);
            Assert.Equal(done, todo.Done);

        }

        [Fact]
        public void Test()
        {
            //Arrange
            int todoId = 1;
            string description = "Work";
            bool done = true;
            Person assignee = new Person(6, "Haris", "Pontus");

            //Act
            Todo todo = new Todo(todoId, description);
            todo.Description = null;
            //Assert
            Assert.Equal(description, todo.Description);
        }
        [Fact]
        public void Getnull()//om man uppdaterar description till Empty ska den behålla sitt ursprungsvärde
        {
            //Arrange
            int todoId = 1;
            string description = "Work";// behåll detta 
            bool done = true;
            Person assignee = new Person(6, "Haris", "Pontus");

            //Act
            Todo todo = new Todo(todoId, description);
            todo.Description = string.Empty;// Försöker byta ut Work mot Empty! 
            //Assert
            Assert.Equal(description, todo.Description);
        }
        [Fact]
        public void BoolIsFalse()
        {
            //Arrange
            int todoId = 1;
            string description = "Work";
            bool done = false;
            Person assignee = new Person(6, "Haris", "Pontus");

            //Act
            Todo todo = new Todo(todoId, description);

            //Assert
            Assert.Equal(done, todo.Done);
        }

    }
}


