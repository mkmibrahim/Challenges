using System;
using Xunit;

namespace _58_CountTwoFives.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{ 5, 5, 2 }", new int[] {5, 5,2})]
        [InlineData("{ 5, 5, 2, 5, 5 }", new int[] {5, 5, 2, 5, 5})]
        [InlineData("{ 5, 6, 2, 9}", new int[] {5, 6, 2, 9})]
        public void Test1(string inputString, int[] expectedArray)
        {
            var str  = inputString;
            var result = str.ToArray();
            Assert.Equal(expectedArray, result);
        }


        [Theory]
        [InlineData(new int[] { 5, 5, 2 }, 1)]
        [InlineData(new int[] { 5, 5, 2, 5,5}, 2)]
        [InlineData(new int[] { 5, 6, 2, 9 }, 1)]
        public void Test2(int[] inputArray, int expectedResult)
        {
            var array = inputArray;
            var result = inputArray.CountFives();
            Assert.Equal(expectedResult, result);
        }
    }
}

