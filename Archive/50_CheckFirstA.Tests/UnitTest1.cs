using System;
using Xunit;

namespace _50_CheckFirstA.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("caabb", true)]
        [InlineData("babaaba", false)]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("aaaaa", true)]
        public void Test1(string inputString, bool expectedResult)
        {
            var str = inputString;
            var result = str.CheckFirstA();
        }
    }
}
