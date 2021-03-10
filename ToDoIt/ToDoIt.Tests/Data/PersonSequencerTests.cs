using System;
using System.Collections.Generic;
using System.Text;
namespace ToDoit.Tests
{
    class PersonSequencerTests
    {

        [Fact]
        public void NewIDIsOne()
        {
            //Arrange
            //TodoSeqencer Idcounter = new TodoSeqencer();
            //Act
            int newid = PersonSequencer.nextPersonID();//Körulle + nästa nummer.
                                                       //Assert
            Assert.Equal(1, newid);
        }
        [Fact]
        public void IDisTwo()
        {
            //Arrange
            //TodoSeqencer Idcounter = new TodoSeqencer();
            //Act
            int newid = PersonSequencer.nextPersonID();
            newid = PersonSequencer.nextPersonID();
            //Assert
            Assert.Equal(2, newid);
        }
        [Fact]
        public void TryToResetID()
        {
            //Arrange
            //TodoSeqencer Idcounter = new TodoSeqencer();
            //Act
            int newid = PersonSequencer.nextPersonID();//retunera 1
            newid = PersonSequencer.nextPersonID();//retunera 2
            PersonSequencer.reset();//sätter den till 0
            newid = PersonSequencer.nextPersonID();// Börjar om på 0. får siffran 1.
                                                   //Assert
            Assert.Equal(1, newid);
        }
        [Fact]
        public void TryToResetIDAddNew()
        {
            //Arrange
            //TodoSeqencer Idcounter = new TodoSeqencer();
            //Act
            int newid = PersonSequencer.nextPersonID();//retunera 1
            newid = PersonSequencer.nextPersonID();//retunera 2
            PersonSequencer.reset();//sätter den till 0
            newid = PersonSequencer.nextPersonID();// Börjar om på 0. får siffran 1.
            newid = PersonSequencer.nextPersonID();
            newid = PersonSequencer.nextPersonID();
            newid = PersonSequencer.nextPersonID();
            //Assert
            Assert.Equal(4, newid);
        }
        [Fact]
        public void ResetReset()
        {
            //Arrange
            //TodoSeqencer Idcounter = new TodoSeqencer();
            //Act
            int newid = PersonSequencer.nextPersonID();//retunera 1
            newid = PersonSequencer.nextPersonID();//retunera 2
            PersonSequencer.reset();//sätter den till 0
            PersonSequencer.reset();
            newid = PersonSequencer.nextPersonID();
            //Assert
            Assert.Equal(1, newid);
        }
    }
}