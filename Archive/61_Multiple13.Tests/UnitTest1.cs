using System;
using Xunit;

namespace _61_Multiple13.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(13, true)]
        [InlineData(14, true)]
        [InlineData(27, true)]
        [InlineData(41, false)]
        public void TestCheckMultiple13(int inputInt, bool expectedResult)
        {
            var number = inputInt;
            var result = number.CheckMultiple13();
            Assert.Equal(expectedResult, result);
        }
    }
}
