using System;
using Xunit;
//using CustomExtensions;

namespace Strings_03.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("ab*cd","ad")]
        [InlineData("ab*cde*fg","adg")]
        [InlineData("ab*cd*ef*gh*", "a")]
        [InlineData("ab**cd", "ad")]
        [InlineData("ab***cd", "ad")]
        public void Test1(string inputString, string expectedResult)
        {
            string str = inputString;
            var p = str.StarOut();
            Assert.Equal(expectedResult, p);
            
        }
    }
}
