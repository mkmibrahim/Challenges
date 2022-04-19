using System;
using Xunit;

namespace _62_Within2Multiple10.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("3", false)]
        [InlineData("7", false)]
        [InlineData("8", true)]
        [InlineData("21", true)]
        public void Test1(string inputString, bool expectedResult)
        {
            var str = inputString;
            var result = str.CheckWithin2Multiple10();
            Assert.Equal(expectedResult, result);
        }
    }
}
