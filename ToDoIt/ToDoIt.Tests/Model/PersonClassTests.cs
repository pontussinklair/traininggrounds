using System;
using Xunit;
namespace ToDoIt.Tests
{
    public class PersonClassTests
    {
        [Fact]
        public void TestingPersonInit()
        {
            //Arrange
            int personID = 1;
            string firstName = "Alf";
            string lastName = "Svensson";
            //Act
            Person person = new Person(personID, firstName, lastName);

            //Assert
            Assert.Equal(personID, person.PersonID);
            Assert.Equal(firstName, person.FirstName);
            Assert.Equal(lastName, person.LastName);
        }

        [Fact]
        public void TestingPersonEmptyNull()
        {
            //Arrange
            int personID = 1;
            string firstName = null;
            string lastName = string.Empty;
            //Assert
            Person person = new Person(personID, firstName, lastName);
            //Assembly
            Assert.Equal(personID, person.PersonID);
            Assert.Equal(firstName, person.FirstName);
            Assert.Equal(lastName, person.LastName);
        }
    }
}
