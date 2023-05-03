using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(3, 4, 3, 10)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var addition = new Method();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = addition.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(20, 10, 10)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var subtraction = new Method();

            //Act
            int actual = subtraction.Subtract(minuend, subtrhend, expected);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 5, 25)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var multiplication = new Method();

            //Act
            var actual = multiplication.Multiplication(num1, num2, expected);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 10, 2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var division = new Method();

            //Act

            var actual = division.Division(num1, num2, expected);

            //Assert

            Assert.Equal(expected, actual);

        }

    }


}

