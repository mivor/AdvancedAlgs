using Algs.Recursive;
using Xunit;

namespace Algs.RecursiveTests
{
    public class CmmdcTests
    {
        private Cmmdc _sut;

        [Fact]
        public void WhenZero_ResultX()
        {
            // Arrange
            var x = 10;
            var y = 0;
            _sut = new Cmmdc(x, y);

            // Act
            _sut.Execute();

            // Assert
            Assert.Equal(x, _sut.Result);
        }

        [Fact]
        public void WhenPositiveNumbers_ResultCMMDC()
        {

            // Arrange
            var x = 12;
            var y = 18;
            _sut = new Cmmdc(x, y);

            // Act
            _sut.Execute();

            // Assert
            Assert.Equal(6, _sut.Result);
        }
    }
}