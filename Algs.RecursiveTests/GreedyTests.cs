using System;
using System.Collections.Generic;
using System.Windows.Documents;
using Algs.Simple;
using Xunit;

namespace Algs.RecursiveTests
{
    public class GreedyTests
    {
        [Fact]
        public void Spectactole_Corect()
        {

            // Arrange
            var spect = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(1, 4),
                new Tuple<int, int>(4, 7),
                new Tuple<int, int>(3, 5),
                new Tuple<int, int>(8, 9),
                new Tuple<int, int>(6, 7),
            };

            // Act
            var result = Greedy.Spectacole(spect);

            // Assert
            Assert.Equal(3, result);

        } 
    }
}