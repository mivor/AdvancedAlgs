using Algs.Simple;
using Xunit;

namespace Algs.RecursiveTests
{
    public class DivideTests
    {
        [Fact]
        public void Search_WhenExists_ReturnTrue()
        {
            // Arrange
            var array = new[] { 2, 3, 5, 8, 10, 12, 50, 100, 200, 201, 202 };

            // Act
            var result = Divide.Search(array, 100);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Search_WhenNotExists_ReturnFalse()
        {
            // Arrange
            var array = new[] { 2, 3, 5, 8, 10, 12, 50, 100, 200, 201, 202 };

            // Act
            var result = Divide.Search(array, 4);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Exp_WhenNumbers_ReturnCorect()
        {
            // Arrange

            // Act
            var result = Divide.Exp(7, 13);

            // Assert
            Assert.Equal(96889010407, result);
        }

        [Fact]
        public void Exp_WhenExpPerfectSquare_ReturnCorect()
        {
            // Arrange

            // Act
            var result = Divide.Exp(7, 16);

            // Assert
            Assert.Equal(33232930569601, result);
        }
    }
}