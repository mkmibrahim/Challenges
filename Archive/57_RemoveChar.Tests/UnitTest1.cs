using System;
using Xunit;

namespace _57_RemoveChar.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("xxHxix", "x", "xHix")]
        [InlineData("abxdddca", "a", "abxdddca")]
        [InlineData("xabjbhtrb", "b", "xajhtrb")]
        public void Test1(string inputString, string inputChar, string expextedOutput)
        {
            var str = inputString;
            var result = str.RemoveChar(inputChar[0]);
            Assert.Equal(expextedOutput, result);
        }
    }
}
