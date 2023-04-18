using System;
using Xunit;

namespace _67_CheckLastDigit.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("11, 21, 31", true)]
        [InlineData("11, 22, 31", false)]
        [InlineData("11, 22, 33", false)]
        public void Test1(string Input, bool expectedOutput)
        {
            var str = Input;
            var result = str.CheckLastDigit();
            Assert.Equal(expectedOutput, result);
        }
    }
}
