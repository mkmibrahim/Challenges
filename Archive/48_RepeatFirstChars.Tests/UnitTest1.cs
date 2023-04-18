using System;
using Xunit;

namespace _48_RepeatFirstChars.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("", 1, "")]
        [InlineData(null, 1, "")]
        [InlineData("", null, "")]
        [InlineData("Python", 2, "PytPyt")]
        [InlineData("JS", 3, "JSJSJS")]
        [InlineData("Python", 3, "PytPytPyt")]
        public void Test1(string inputString, int inputInt, string outputString)
        {
            var str = inputString;
            var result = str.RepeatFirstChars(inputInt);
            Assert.Equal(outputString, result);
        }
    }
}
