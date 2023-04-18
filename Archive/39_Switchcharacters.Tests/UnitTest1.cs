using System;
using Xunit;

namespace _39_Switchcharacters.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("abcd", "dbca")]
        [InlineData("a", "a")]
        [InlineData("xy", "yx")]
        public void Test1(string inputString, string expectedOutputString)
        {
            var str = inputString;
            var output = str.getSwitch();
            Assert.Equal(expectedOutputString, output);
        }
    }
}
