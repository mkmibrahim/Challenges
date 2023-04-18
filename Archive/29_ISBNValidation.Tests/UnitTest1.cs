using System;
using Xunit;

namespace _29_ISBNValidation.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("8535902775", "Valid")]
        [InlineData("1843369283", "Not Valid")]
        public void Test1(string ISBNNumber, string expectedResult)
        {
            var result = ISBNHelper.Validate(ISBNNumber);
            Assert.Equal(expectedResult, result);
        }
    }
}
