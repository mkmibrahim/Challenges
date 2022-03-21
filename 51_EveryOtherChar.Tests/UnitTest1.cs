using System;
using Xunit;

namespace _51_EveryOtherChar.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Python", "Pto")]
        [InlineData("PHP", "PP")]
        [InlineData("JS", "J")]
        public void Test1(string inputString, string expectedOutputString)
        {
            var str = inputString;
            var result = str.EveryOtherChar();
            Assert.Equal(expectedOutputString, result);

        }
    }
}
