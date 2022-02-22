using System;
using Xunit;

namespace _46_CheckLastDigit.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(123, 456, false)]
        [InlineData(12, 512, true)]
        [InlineData(7, 87, true)]
        [InlineData(12, 45, false)]
        public void Test1(int firstInt, int secondInt, bool expectedResult)
        {
            var result = Helper.CheckLastDigits(firstInt, secondInt);
            Assert.Equal(expectedResult, result);
        }
    }
}
