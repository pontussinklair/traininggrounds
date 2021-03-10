using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt.Data;

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

    }
}
