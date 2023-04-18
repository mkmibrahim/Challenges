using System;
using Xunit;

namespace _42_Findyt.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Python", "Phon")]
        [InlineData("ytade", "ytade")]
        [InlineData("jsues","jsues")]
        public void Test1(string inputString, string expectedOutputString)
        {
            var str = inputString;
            var result = str.Checkyt();
            Assert.Equal(expectedOutputString, result);
        }
    }
}
