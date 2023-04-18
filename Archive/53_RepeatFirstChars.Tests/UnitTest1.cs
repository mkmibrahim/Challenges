using System;
using Xunit;

namespace _53_RepeatFirstChars.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("abcd", "aababcabcd")]
        [InlineData("abc", "aababc")]
        [InlineData("a","a")]
        public void Test1(string inputString, string expectedOutputString)
        {
            var str = inputString;
            var result = str.RepeatFirstChars();
            Assert.Equal(expectedOutputString, result);

        }
    }
}
