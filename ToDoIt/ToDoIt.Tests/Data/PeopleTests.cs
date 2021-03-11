using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDoIt.Data;
using ToDoIt.Model;

namespace ToDoIt.Tests
{
    public class PeopleTests
    {
        [Fact]
        public void SizeOfArray()
        {
            //Arrange
            People personList = new People();
            personList.ClearPersons();
            PersonSequencer.reset();
            //Act
            int startSize = personList.Size();
            personList.NewPerson("Aron", "Flam");
            personList.NewPerson("Jonathan", "Unge");
            int resultSize = personList.Size();

            Assert.True((startSize + 2) == resultSize);
        }
        [Fact]
        public void FindAllTest()
        {

            People personList = new People();
            personList.ClearPersons();
            PersonSequencer.reset();

            personList.NewPerson("Pelle", "Plätt");
            personList.NewPerson("Kenny", "Starfighter");
            Person Ebbot = personList.NewPerson("Ebbot", "Lavén");

            Person[] allPeople = personList.FindAll();

            Assert.Equal(3, allPeople.Length);

            Assert.Equal("Pelle", allPeople[0].FirstName);
            Assert.Equal("Plätt", allPeople[0].LastName);
            Assert.Equal(1, allPeople[0].PersonID);

            Assert.Equal("Kenny", allPeople[1].FirstName);
            Assert.Equal("Starfighter", allPeople[1].LastName);
            Assert.Equal(2, allPeople[1].PersonID);

            Assert.Contains(Ebbot, allPeople);
            Assert.Equal("Lavén", allPeople[2].LastName);
            Assert.Equal(3, allPeople[2].PersonID);
        }
        [Fact]
        public void FindByIdTest()
        {

            Person person;
            People personList = new People();

            personList.ClearPersons();
            PersonSequencer.reset();

            personList.NewPerson("Pelle", "Plätt");
            personList.NewPerson("Kenny", "Starfighter");
            personList.NewPerson("Ebbot", "Lavén");

            person = personList.FindById(1);
            Assert.Equal("Pelle", person.FirstName);
            Assert.Equal("Plätt", person.LastName);
            Assert.Equal(1, person.PersonID);

            person = personList.FindById(2);
            Assert.Equal("Kenny", person.FirstName);
            Assert.Equal("Starfighter", person.LastName);
            Assert.Equal(2, person.PersonID);

            person = personList.FindById(3);
            Assert.Equal("Ebbot", person.FirstName);
            Assert.Equal("Lavén", person.LastName);
            Assert.Equal(3, person.PersonID);


        }
        [Fact]
        public void ClearAfterAddTest()
        {
            People personList = new People();
            personList.ClearPersons();
            PersonSequencer.reset();

            personList.NewPerson("Ylva", "Gottfridsdottir");
            personList.NewPerson("Evert", "Taube");
            personList.NewPerson("Klas", "Holm");

            personList.ClearPersons();

            Assert.Equal(0, personList.Size());

        }
        [Fact]
        public void RemoveTest()
        {
            People personList = new People();


            Person sune = personList.NewPerson("Sune", "Kammamook");
            Person sven = personList.NewPerson("Sven", "Larsson");
            Person nils = personList.NewPerson("Nils", "K.Pyssling");

            personList.RemoveObject(sven);
            Person[] allPeople = personList.FindAll();

            Assert.Contains(sune, allPeople);
            Assert.Contains(nils, allPeople);
            Assert.DoesNotContain(sven, allPeople);
        }
        [Fact]
        public void DeleteObjectFromArrayTest()
        {
            People personList = new People();
            personList.ClearPersons();
            PersonSequencer.reset();
            //Arrange
            string person_1_Firstname = "Per";
            string person_1_Lastname = "Holknekt";
            string person_2_Firstname = "Joey";
            string person_2_Lastname = "Tribbiani";
            string person_3_Firstname = "Mr";
            string person_3_Lastname = "Bean";

            PersonSequencer.reset();
            People people = new People();

            Person person_1 = people.NewPerson(person_1_Firstname, person_1_Lastname);
            Person person_2 = people.NewPerson(person_2_Firstname, person_2_Lastname);
            Person person_3 = people.NewPerson(person_3_Firstname, person_3_Lastname);

            Person[] result = { person_1, person_3, };

            //Act
            people.RemoveObject(person_2);

            //Assert
            Assert.Equal(result, people.FindAll());
        }

    }
}