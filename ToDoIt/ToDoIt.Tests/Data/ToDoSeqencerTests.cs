using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoit.Model;
using static ToDoIt.Data.ToDoSeqencer;

namespace ToDoit.Tests.Data
{
    public class TodoSeqencersTests
    {
        [Fact]
        public void NewIdIsOne()
        {
            //Arrange

            //Act
            int newid = TodoSeqencer.nextTodoId();//Körulle + nästa nummer.

            //Assert
            Assert.Equal(1, newid);
        }
        [Fact]
        public void IsisTwo()
        {
            //Arrange
            //TodoSeqencer Idcounter = new TodoSeqencer();
            //Act
            int newid = TodoSeqencer.nextTodoId();
            newid = TodoSeqencer.nextTodoId();
            //Assert
            Assert.Equal(2, newid);

        }
        [Fact]
        public void TryToResetId()
        {
            //Arrange
            //TodoSeqencer Idcounter = new TodoSeqencer();
            //Act
            int newid = TodoSeqencer.nextTodoId();//retunera 1
            newid = TodoSeqencer.nextTodoId();//retunera 2
            TodoSeqencer.reset();//sätter den till 0
            newid = TodoSeqencer.nextTodoId();// Börjar om på 0. får siffran 1.
            //Assert
            Assert.Equal(1, newid);

        }
        [Fact]
        public void TryToResetIdAddNew()
        {
            //Arrange
            //TodoSeqencer Idcounter = new TodoSeqencer();
            //Act
            int newid = TodoSeqencer.nextTodoId();//retunera 1
            newid = TodoSeqencer.nextTodoId();//retunera 2
            TodoSeqencer.reset();//sätter den till 0
            newid = TodoSeqencer.nextTodoId();// Börjar om på 0. får siffran 1.
            newid = TodoSeqencer.nextTodoId();
            newid = TodoSeqencer.nextTodoId();
            newid = TodoSeqencer.nextTodoId();
            //Assert
            Assert.Equal(4, newid);

        }
        [Fact]
        public void ResetReset()
        {
            //Arrange
            //TodoSeqencer Idcounter = new TodoSeqencer();
            //Act
            int newid = TodoSeqencer.nextTodoId();//retunera 1
            newid = TodoSeqencer.nextTodoId();//retunera 2
            TodoSeqencer.reset();//sätter den till 0
            TodoSeqencer.reset();
            newid = TodoSeqencer.nextTodoId();
            //Assert
            Assert.Equal(1, newid);

        }

    }
}
