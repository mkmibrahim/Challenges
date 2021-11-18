using Xunit;

namespace _15_PerfectNumber.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(6, "given number is a perfect number")]
        [InlineData(5, "given number is not a perfect number")]
        public void Test1(int number, string expectedResult)
        {
            var result = PerfectNumber.Check(number);
            Assert.Equal(expectedResult, result);
        }
    }
}
