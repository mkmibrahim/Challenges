using System;
using Xunit;

namespace _41_CheckInts.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("11, 20, 12", true)]
        [InlineData("30, 30, 17", true)]
        [InlineData("25, 35, 50", true)]
        [InlineData("15, 12, 8", false)]
        public void Test1(string inputString, bool expectedOutput)
        {
            var str = inputString;
            var output = str.CheckInts();
            Assert.Equal(expectedOutput, output);
        }
    }
}
