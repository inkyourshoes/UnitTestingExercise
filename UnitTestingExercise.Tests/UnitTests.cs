using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(5, 5, 5, 15)]

        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var test = new UnitTestMethods();
            // create a Calculator object
            //Act
            var actual = test.Add(num1, num2, num3);
            // call the Add method that is located in the Calculator class and store its result in a variable named actual
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,5,0)]
        [InlineData(5,10,-5)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var tester = new UnitTestMethods();

            //Act
            var actual = tester.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5,5,25)] 
        [InlineData(-3,4,-12)] 
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(20, 5, 4)] //Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        //create 2 methods that will utilize fact
        // var actual = EddiesMethod();
        [Fact]
        public void EddiesMethod()
        {
            //Arrange
            var expected = 'e';
            var actual = 'e';
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EddiesMethod2()
        {
            //Arrange
            var expected = 'r';
            var actual = 'r';
            Assert.Equal(expected, actual);
            
        }

    }
}
