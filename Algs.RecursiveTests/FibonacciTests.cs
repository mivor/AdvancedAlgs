using Algs.Recursive;
using Xunit;

namespace Algs.RecursiveTests
{
    public class FibonacciTests
    {
        private Fibonacci _sut;

        [Fact]
        public void WhenZero_ResultZero()
        {
            // Arrange
            _sut = new Fibonacci(0);

            // Act
            _sut.Execute();

            // Assert
            Assert.Equal(0, _sut.Result);

        }

        [Fact]
        public void WhenOne_ResultOne()
        {

            // Arrange
            _sut = new Fibonacci(1);

            // Act
            _sut.Execute();

            // Assert
            Assert.Equal(1, _sut.Result);

        }

        [Fact]
        public void WhenPositiveNumber_ResultFibonacci()
        {

            // Arrange
            _sut = new Fibonacci(10);

            // Act
            _sut.Execute();

            // Assert
            Assert.Equal(55, _sut.Result);
            

        }
    }  
}