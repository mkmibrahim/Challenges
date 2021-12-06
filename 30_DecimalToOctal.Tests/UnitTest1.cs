using System;
using Xunit;

namespace _30_DecimalToOctal.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(81,"121")]
        [InlineData(10, "12")]
        public void Test1(int decimalNumber, string expectedOctal)
        {
            var result = OctalHelper.Convert(decimalNumber);
            Assert.Equal(expectedOctal, result);
        }
    }
}
