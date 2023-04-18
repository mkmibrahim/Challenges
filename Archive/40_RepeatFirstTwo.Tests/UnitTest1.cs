using System;
using Xunit;

namespace _40_RepeatFirstTwo.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("C Sharp", "C C C C ")]
        [InlineData("JS", "JSJSJSJS")]
        [InlineData("a", "a")]
        public void Test1(string inputString, string expectedOutputString)
        {
            var str = inputString;
            var output = str.RepeatFirstTwo();
            Assert.Equal(expectedOutputString, output);
        }
    }
}
