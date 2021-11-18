using System;
using Xunit;

namespace _01_ReverseArray.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 5, 4, 7, 3, 6 }, new int[] { 6, 3, 7, 4, 5, 5, 4, 3, 2, 1, })]

        //[InlineData("25,23,,26,12,45,65,58,24,27,13", "13 27 24 58 65 45 12 26 23 25")]}
        public void TheoryTest(int[] inputInts, int[] expectedOutputInts)
        {
            var returnedValue = ReverseArrayHelper.ReverseValues(inputInts);
            Assert.Equal(expectedOutputInts, returnedValue);
        }
    }
}
