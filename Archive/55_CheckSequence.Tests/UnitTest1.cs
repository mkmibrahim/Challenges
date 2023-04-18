using System;
using Xunit;

namespace _55_CheckSequence.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{ 1,1,2,3,1}", true)]
        [InlineData("{ 1,1,2,4,1}", false)]
        [InlineData("{ 1,1,2,1,2,3}", true)]
        public void Test1(string inputString, bool expectedOutput)
        {
            var str = inputString;
            var result = str.CheckSequence();
            Assert.Equal(expectedOutput, result);

        }
    }
}
