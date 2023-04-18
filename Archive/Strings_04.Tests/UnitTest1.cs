using System;
using Xunit;

namespace Strings_04.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("endless", false)]
        [InlineData("endlessy", false)]
        [InlineData("endlessl", false)]
        [InlineData("endlessly", true)]
        public void Test1(string inputString, bool expectedResult)
        {
            var str = inputString;
            var result = str.LyCheck();
            Assert.Equal(expectedResult, result);
        }
    }
}
