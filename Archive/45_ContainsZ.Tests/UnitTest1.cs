using System;
using Xunit;

namespace _45_ContainsZ.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("frizz", true)]
        [InlineData("zane", false)]
        [InlineData("Zazz", true)]
        [InlineData("false", false)]
        [InlineData("zzzz", true)]
        [InlineData("ZZZZ", false)]
        public void Test1(string inputString, bool expectedResult)
        {
            var str = inputString;
            var result = str.CheckZ();
            Assert.Equal(expectedResult, result);
        }
    }
}
