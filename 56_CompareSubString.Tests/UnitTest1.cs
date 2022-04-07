using System;
using Xunit;

namespace _56_CompareSubString.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("abcdefgh", "abijsklm", 1)]
        [InlineData("abcde", "osuefrcd", 1)]
        [InlineData("pqrstuvwx", "pqkdiewx",2)]
        public void Test1(string firstString, string secondString, int expectedResult)
        {
            var str1 = firstString;
            var result = firstString.CheckSubString(secondString);
            Assert.Equal(expectedResult, result);
        }
    }
}
