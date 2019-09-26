using System;
using Xunit;
using Algorithms;

namespace Algorithms.Tests
{
    public class BinaryTests
    {
        [Fact]
        public void BinarySearchNumberDoesntExist()
        {
            int[] test = { 9, 4, 1, 7, 3, 6, 5 };
            Assert.False(Methods.BinarySearch(test, 14));
        }

        [Fact]
        public void BinarySearchNumberOutOfRange()
        {
            int[] test = { 9, 4, 1, 7, 3, 6, 5 };
            Assert.False(Methods.BinarySearch(test, 90));
        }

        [Fact]
        public void BinarySearchNumberDoesExist()
        {
            int[] test = { 9, 4, 1, 7, 3, 6, 5 };
            Assert.True(Methods.BinarySearch(test, 7));
        }

        [Fact]
        public void BinarySearchNumberHighest()
        {
            int[] test = { 9, 4, 1, 7, 3, 6, 5 };
            Assert.True(Methods.BinarySearch(test, 9));
        }

        [Fact]
        public void BinarySearchNumberLowest()
        {
            int[] test = { 9, 4, 1, 7, 3, 6, 5 };
            Assert.True(Methods.BinarySearch(test, 1));
        }

        [Fact]
        public void BinarySearchOneNumber()
        {
            int[] test = {9};
            Assert.True(Methods.BinarySearch(test, 9));
        }

        [Fact]
        public void BinarySearchOneNumberDoesntExist()
        {
            int[] test = { 9 };
            Assert.False(Methods.BinarySearch(test, 3));
        }
    }
}
