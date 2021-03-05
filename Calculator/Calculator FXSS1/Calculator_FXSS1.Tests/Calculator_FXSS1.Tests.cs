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
            double expected = 50;

            double actual = Program.Addition(25, 25);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AdditionOverloadTest()
        {
            double expected = 152;

            double actual = Program.Addition(new double[] { 25.50, 25.50, 50.50, 50.50 });

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AdditionWithSimpelNegativNumbers()
        {
           
            double expected = -1;
           
            double actual = Program.Addition(-3, 2);
            
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AdditionWithBigNumbers()
        {
            
            double expected = 6100000;
            
            double actual = Program.Addition(100000, 6000000);
            
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AdditionWithDoubleNumbers()
        {
            
            double expected = 50.30;
            
            double actual = Program.Addition(20.20, 30.10);
            
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SubtractionWithSimpleNumbers()
        {
            
            double expected = 5;
            
            double actual = Program.Subtraction(25, -20);
            
            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void SubtractionForOverload()
        {
            
            double expected = 25;
            
            double actual = Program.Subtraction(new double[] { 25, -20, 20 });
            
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SubtractionWithNegativeNumbers()
        {
            
            double expected = -300;
           
            double actual = Program.Subtraction(-100, -200);
            
            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void SubtractionWithDoubleNegativeNumbers()
        {
            
            double expected = -30.70;
            
            double actual = Program.Subtraction(-10.20, -20.50);
           
            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void MultiplicationWithSimpleNumbers()
        {
            double expected = 25;

            double actual = Program.Multiplication(5, 5);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DivisionWithSimpleNumbers()
        {
            double expected = 20;

            double actual = Program.Division(100, 5);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DivisionWithZeroNumbers()
        {
            double expected = double.PositiveInfinity;

            double actual = Program.Division(50, 0);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AdditionArray()
        {
            double expected = 31;

            double[] number = new double[5] { 1, 5, 6, 9, 10 };

            double actual = Program.Addition(number);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AdditionWithNegativeNumbersArray()
        {
            double expected = 19;

            double[] number = new double[5] { 1, 5, -6, 9, 10 };

            double actual = Program.Addition(number);

            Assert.Equal(expected, actual);
        }
    }
}


