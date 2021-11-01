using Xunit;

namespace _3_NumberToStringFormat.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("fifty four", NumberToStringFormatter.Format(54));
        }

        [Theory]
        [InlineData(1, "one")]
        [InlineData(4, "four")]
        [InlineData(10, "ten")]
        [InlineData(20, "twenty")]
        [InlineData(30, "thirty")]
        [InlineData(21, "twenty one")]
        public void Test(int number, string numberStringFormat)
        {
            var result = NumberToStringFormatter.Format(number);
            Assert.Equal(numberStringFormat, result);
        }
    }
}
