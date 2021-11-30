using System;
using Xunit;

namespace _26_NumberSequence.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, 12321)]
        [InlineData(4, 1234321)]
        public void Test1(int number, int sequence)
        {
            var result = NumberSequenceHelper.GetSequence(number);
            Assert.Equal(sequence, result);
        }
    }
}
