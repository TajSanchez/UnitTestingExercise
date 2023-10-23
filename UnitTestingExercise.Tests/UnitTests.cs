using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(8,8,8,24)]
        [InlineData (30,30,30,90)]
        [InlineData (30,0,2,32)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            
            //Start Step 3 here:

            //Arrange
            var calculator = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = calculator.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,5,5)] //Add test data <-------
        [InlineData(15,5,10)]
        [InlineData (30,10,20)]
        [InlineData(50,25,25)]
        
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Subtract(minuend,subtrhend);
            
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5,5,25)]//Add test data <-------
        [InlineData (5,6,30)]
        [InlineData(12,12,144)]
        [InlineData(4,-4,-16)]
        [InlineData(0,4,0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calulator = new Calculator();

            //Act
            var actual = calulator.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20,4,5)]//Add test data <-------
        [InlineData (9,3,3)]
        [InlineData (6,3,2)]
        [InlineData(14,7,2)]
        [InlineData(75,3,25)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Divide( num1, num2);
            //Assert
            Assert.Equal (expected, actual);
        }

    }
}
