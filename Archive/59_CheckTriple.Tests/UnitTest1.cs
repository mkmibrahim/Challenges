using System;
using Xunit;

namespace _59_CheckTriple.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{ 1, 1, 2, 2, 1 }", new int[] { 1, 1, 2, 2, 1 })]
        [InlineData("{ 1, 1, 2, 1, 2, 3 }", new int[] {1 ,1, 2, 1, 2, 3 })]
        [InlineData("{ 1, 1, 1, 2, 2, 2, 1 }", new int[] { 1, 1, 1, 2, 2, 2, 1 })]
        public void ToArrayTest(string inputString, int[] expectedArray)
        {
            var str = inputString;
            var result = str.ToArray();
            Assert.Equal(expectedArray, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 2, 2, 1 }, false)]
        [InlineData(new int[] { 1, 1, 2, 1, 2, 3 }, false)]
        [InlineData(new int[] { 1, 1, 1, 2, 2, 2, 1 }, true)]
        public void CheckTripleTest(int[] inputArray, bool expectedResult)
        {
            var array = inputArray;
            var result = array.CheckTriple();
            Assert.Equal(expectedResult, result);
        }
    }
}
