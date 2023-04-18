using System;
using Xunit;

namespace _38_NextPrime.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(120, 127)]
        [InlineData(43, 43)]
        [InlineData(321, 331)]
        [InlineData(4433, 4441)]
        public void Test1(int originalNumber, int expectedNextPrime)
        {
            int number = originalNumber;
            var result = number.getNextPrime();
            Assert.Equal(expectedNextPrime, result);

        }
    }
}
