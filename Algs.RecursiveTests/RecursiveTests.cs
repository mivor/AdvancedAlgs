using Algs.Simple;
using Xunit;

namespace Algs.RecursiveTests
{
    public class RecursiveTests
    {
        [Fact]
        public void Cmmdc_WhenZero_ResultX()
        {
            // Arrange
            const int x = 10;
            const int y = 0;

            // Act
            var result = Recursive.Cmmdc(x, y);

            // Assert
            Assert.Equal(x, result);
        }

        [Fact]
        public void Cmmdc_WhenPositiveNumbers_ResultCMMDC()
        {

            // Arrange
            const int x = 12;
            const int y = 18;

            // Act
            var result = Recursive.Cmmdc(x, y);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Fibonacci_WhenZero_ResultZero()
        {
            // Arrange

            // Act
            var result = Recursive.Fibonacci(0);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Fibonacci_WhenOne_ResultOne()
        {

            // Arrange

            // Act
            var result = Recursive.Fibonacci(1);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Fibonacci_WhenPositiveNumber_ResultFibonacci()
        {

            // Arrange

            // Act
            var result = Recursive.Fibonacci(10);

            // Assert
            Assert.Equal(55, result);
        }

        [Fact]
        public void Factorial_WhenZero_ResultOne()
        {
            // Arrange

            // Act
            var result = Recursive.Factorial(0);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Factorial_WhenPositiveNumber_ResultFactorial()
        {
            // Arrange

            // Act
            var result = Recursive.Factorial(5);

            // Assert
            Assert.Equal(120, result);
        }
    }
}