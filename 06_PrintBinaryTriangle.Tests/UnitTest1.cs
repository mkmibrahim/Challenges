using _06_PrintBinaryTriangle;
using Xunit;

namespace _06_PrintBinaryTriangle.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test0()
        {
            var result = BinaryConverter.BinaryString(1);
            Assert.Equal("1", result);
        }

        [Fact]
        public void Test1()
        {
            var result = BinaryConverter.BinaryString(3);
            Assert.Equal("010", result);
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "01")]
        [InlineData(3, "010")]
        [InlineData(4, "1010")]
        [InlineData(5, "10101")]
        public void Test(int number, string binaryStringFormat)
        {
            var result = BinaryConverter.BinaryString(number);
            Assert.Equal(binaryStringFormat, result);
        }
    }
}
