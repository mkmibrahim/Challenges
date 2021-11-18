using Xunit;

namespace _14_IndianRupeesFormat.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("3432", "3Thousand 432")]
        [InlineData("12533", "12Thousand 533")]
        public void Test1(string amount, string expectedString)
        {
            var returnedString = RupeeFormatter.Convert(amount);
            Assert.Equal(expectedString, returnedString);
        }
    }


}
