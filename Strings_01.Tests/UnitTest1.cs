using System;
using Xunit;

namespace Strings_01.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("fez day", 2)]
        public void Test1(string inputString, int expectedResult)
        {
            var result = StringHelper.CountEZ(inputString);
            Assert.Equal(expectedResult, result);
        }
    }
}
