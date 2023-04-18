using System;
using Xunit;

namespace _24_SumOfTheDigits.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(131083, 7)]
        [InlineData(12052014, 6)]
        public void Test1(int date, int expectedLuckNumber)
        {
            var result = SumCalculator.Calculate(date);
            Assert.Equal(expectedLuckNumber, result);
        }
    }
}
