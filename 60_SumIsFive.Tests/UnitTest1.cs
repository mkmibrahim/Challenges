using System;
using Xunit;

namespace _60_SumIsFive.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("5, 4", true)]
        [InlineData("4, 3", false)]
        [InlineData("1, 4", true)]
        public void Test1(string inputString, bool expectedResult)
        {
            var str = inputString;
            var result = str.IsSumFive();
            Assert.Equal(expectedResult, result);
        }
    }
}
