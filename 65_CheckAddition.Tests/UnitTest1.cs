using System;
using Xunit;

namespace _65_CheckAddition.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1, 2, 3", true)]
        [InlineData("4, 5, 6", false)]
        [InlineData("-1, 1, 0", true)]
        public void Test1(string inputString, bool expectedResult)
        {
            var str = inputString;
            var result = str.CheckAddition();
            Assert.Equal(expectedResult, result);
        }
    }
}
