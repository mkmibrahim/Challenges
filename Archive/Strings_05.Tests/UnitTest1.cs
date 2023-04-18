using System;
using Xunit;

namespace Strings_05.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("aaa", true)]
        [InlineData("abc", false)]
        public void Test1(String inputString, bool expectedResult)
        {
            var str = inputString;
            var result = str.Palindromecheck();
            Assert.Equal(expectedResult, result);
        }
    }
}
