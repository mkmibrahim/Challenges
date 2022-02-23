using System;
using Xunit;

namespace _47_ConvertLastThreeChars.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(null, "")]
        [InlineData("", "")]
        [InlineData("J", "J")]
        [InlineData("JS", "JS")]
        [InlineData("Python", "PytHON")]
        [InlineData("Javascript", "JavascrIPT")]
        [InlineData("PHP","PHP")]
        public void Test1(string inputString, string expectedOutput)
        {
            string str = inputString;
            string result = str.ConvertLastThreeChars();
            Assert.Equal(expectedOutput, result);
        }
    }
}
