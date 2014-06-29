using Algs.Simple;
using Xunit;

namespace Algs.RecursiveTests
{
    public class SortTests
    {
        [Fact]
        public void Bubble_WhenArray_ResultSorted()
        {

            // Arrange
            var array = new[] {4, 3, 7, 5, 8, 2};
            var expected = new[] {2, 3, 4, 5, 7, 8};

            // Act
            Sort.Bubble(array);

            // Assert
            Assert.Equal(expected, array);
        }

        [Fact]
        public void Insertion_WhenArray_ResultSorted()
        {

            // Arrange
            var array = new[] { 4, 3, 7, 5, 8, 2 };
            var expected = new[] { 2, 3, 4, 5, 7, 8 };

            // Act
            Sort.Insertion(array);

            // Assert
            Assert.Equal(expected, array);
        }

        [Fact]
        public void InsertionRecursive_WhenArray_ResultSorted()
        {

            // Arrange
            var array = new[] { 4, 3, 7, 5, 8, 2 };
            var expected = new[] { 2, 3, 4, 5, 7, 8 };

            // Act
            Sort.InsertionRecursive(array);

            // Assert
            Assert.Equal(expected, array);
        }

        [Fact]
        public void Selection_WhenArray_ResultSorted()
        {

            // Arrange
            var array = new[] { 4, 3, 7, 5, 8, 2 };
            var expected = new[] { 2, 3, 4, 5, 7, 8 };

            // Act
            Sort.Selection(array);

            // Assert
            Assert.Equal(expected, array);
        }

        [Fact]
        public void Merge_WhenArrayEven_ResultSorted()
        {

            // Arrange
            var array = new[] { 4, 3, 7, 5, 8, 2 };
            var expected = new[] { 2, 3, 4, 5, 7, 8 };

            // Act
            Sort.Merge(array);

            // Assert
            Assert.Equal(expected, array);
        }

        [Fact]
        public void Merge_WhenArrayOdd_ResultSorted()
        {

            // Arrange
            var array = new[] { 4, 3, 7, 5, 2};
            var expected = new[] { 2, 3, 4, 5, 7};

            // Act
            Sort.Merge(array);

            // Assert
            Assert.Equal(expected, array);
        } 
    }
}