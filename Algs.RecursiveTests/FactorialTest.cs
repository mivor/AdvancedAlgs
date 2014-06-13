using Algs.Recursive;
using Xunit;

namespace Algs.RecursiveTests
{
    public class FactorialTest
    {
        private Factorial _sut;

        [Fact]
        public void WhenZero_ResultOne()
        {
            // Arrange
            _sut = new Factorial(0);
            
            // Act
            _sut.Execute();

            // Assert
            Assert.Equal(1, _sut.Result);
        }
        
        [Fact]
        public void WhenPositiveNumber_ResultFactorial()
        {
            // Arrange
            _sut = new Factorial(5);
            
            // Act
            _sut.Execute();

            // Assert
            Assert.Equal(120, _sut.Result);
        }
    }
}