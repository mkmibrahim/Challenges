using System;
using Xunit;

namespace _63_SumTwoInts.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("3, 7", 10)]
        [InlineData("10, 11", 18)]
        [InlineData("10, 20", 18)]
        [InlineData("21, 220", 241)]
        public void Test1(string inputString, int expectedResult)
        {
            var str = inputString;
            int result = str.GetSpecialSum();
            Assert.Equal(expectedResult, result);
        }
    }
}
