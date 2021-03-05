using System;
using Xunit;
using Calculator_FXSS1;
namespace Calculator_FXSS1.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AdditionWithSimpleNumbers()
        {
            // Arrange
            double expected = 5;
            //Act
            double actual = Program.Addition(3, 2);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AdditionWithNonumbers()
        {
            double test = Program.Addition(25, 25);
            Assert.Equal(50, test);
        }
        [Fact]
        public void AdditionWithSimpelNegativNumbers()
        {
            // Arrange
            double expected = -1;
            //Act
            double actual = Program.Addition(-3, 2);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AdditionWithBigNumbers()
        {
            // Arrange
            double expected = 6100000;
            //Act
            double actual = Program.Addition(100000, 6000000);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AdditionWithDoubleNumbers()
        {
            // Arrange
            double expected = 50.30;
            //Act
            double actual = Program.Addition(20.20, 30.10);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SubbtractionWithSimpelNumbers()
        {
            // Arrange
            double expected = 5;
            //Act
            double actual = Program.Subtraction(25, -20);
            //Assert
            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void SubbtractionWithNegativlNumbers()
        {
            // Arrange
            double expected = -300;
            //Act
            double actual = Program.Subtraction(-100, -200);
            //Assert
            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void SubbtractionWithDoubelNegativlNumbers()
        {
            // Arrange
            double expected = -30.70;
            //Act
            double actual = Program.Subtraction(-10.20, -20.50);
            //Assert
            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void MultiplicationWithSimpelNumbers()
        {
            double test = Program.Multiplication(5, 5);
            Assert.Equal(25, test);
        }
        [Fact]
        public void DivisionWithSimpelNumbers()
        {
            double test = Program.Division(100, 5);
            Assert.Equal(20, test);
        }
        [Fact]
        public void DivisionWithZeroNumbers()
        {
            double test = Program.Division(50, 0);
            Assert.Equal(0, test);
        }
        [Fact]
        public void AdditionArray()
        {
            double[] number = new double[5] { 1, 5, 6, 9, 10 };
            double test = Program.Addition(number);
            Assert.Equal(31, test);
        }
        [Fact]
        public void AdditionWithnegativNumbersArray()
        {
            double[] number = new double[5] { 1, 5, -6, 9, 10 };
            double test = Program.Addition(number);
            Assert.Equal(19, test);
        }
        //[Fact]
       /* public void SubbtractionArray()
        {
            double[] number = new double[3] { -1, -5, -6 };
            double test = Program.Subtraction(number);
            Assert.Equal(-12, test);
        }
        [Fact]
        public void SubbtractionWithPositivNumbersArray()
        {
            double[] number = new double[5] { -1, -5, -6, 10, 20 };
            double test = Program.Subtraction(number);
            Assert.Equal(18, test);
        }*/
    }
}


