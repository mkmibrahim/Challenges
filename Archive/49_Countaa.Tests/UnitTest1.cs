using System;
using Xunit;

namespace _49_Countaa.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("bbaaccaag",2)]
        [InlineData("jjkiaaasew",2)]
        [InlineData("JSaaakoiaa",3)]
        public void Test1(string inputString, int expectedOutput)
        {
            var str = inputString;
            var result = str.Countaa();
            Assert.Equal(expectedOutput, result);
        }
    }
}
