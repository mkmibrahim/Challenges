using System;
using Xunit;

namespace _22_Capitalization.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("jon skeet", "Jon Skeet")]
        [InlineData("old mcdonald", "Old Mcdonald")]
        [InlineData("miles o'Brien", "Miles O'Brien")]
        public void Test1(string inputString, string expectedOutputString)
        {
            var result = Capitalize.CapitalizeString(inputString);
            Assert.Equal(expectedOutputString, result);
        }
    }
}
