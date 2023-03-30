using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(7, 5, 3, 15)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object

            var adder = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            var actual = adder.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 3, 6)]
        [InlineData(5, 2, 3)]//Add test data <-------
        public void SubtractTest(int num1, int num2, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var subtracter = new Calculator();

            //Act

            var actual = subtracter.Subtract(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(6, 3, 18)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            var multiplier = new Calculator();

            //Act

           var actual = multiplier.Multiply(num1, num2);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(6, 2, 3)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange

            var divider = new Calculator();

            //Act

            var actual = divider.Divide(num1, num2);

            //Assert

            Assert.Equal(expected, actual);

        }

    }
}
