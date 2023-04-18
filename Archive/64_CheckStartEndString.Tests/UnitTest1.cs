using System;
using Xunit;

namespace _64_CheckStartEndString.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("FizzBuzz", "Fizz")]
        [InlineData("Fizz", "Fizz")]
        [InlineData("Buzz", "Buzz")]
        [InlineData("Founder", "Fizz")]
        [InlineData("FittiB", "FizzBuzz")]
        public void Test1(string inputString, string expectedOutput)
        {
            var str = inputString;
            var result = str.CheckStartEndString();
            Assert.Equal(expectedOutput, result);
        }
    }
}
