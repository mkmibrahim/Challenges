using System;
using Xunit;

namespace Strings_02.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("hoopla", 2)]
        [InlineData("abbcccddedd", 3)]
        public void Test1(string inputString, int expectedMaxBlock)
        {
            var result = StringHelper.MaxBlock(inputString);
            Assert.Equal(expectedMaxBlock, result);
        }
    }
}
