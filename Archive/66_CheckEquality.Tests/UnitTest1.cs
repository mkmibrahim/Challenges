using System;
using Xunit;

namespace _66_CheckEquality.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("1, 2, 3, false", true)]
        [InlineData("1, 2, 3, true", true )]
        [InlineData("10, 2, 30, false", false)]
        [InlineData("10, 10, 30, true", true)]
        public void Test1(string inputString, bool expectedResult)
        {
            string str = inputString;
            var result = str.CheckEquality();
            Assert.Equal(expectedResult, result);
        }
    }
}
