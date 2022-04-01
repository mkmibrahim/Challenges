using System;
using Xunit;

namespace _54_CheckInArray.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{ 1,2,9,3}, 3", true)]
        [InlineData("{ 1,2,3,4,5,6}, 2", true)]
        [InlineData("{ 1,2,2,3}, 9", false)]
        public void Test1(string inputString, bool expectedOutput)
        {
            var helper = Helper1.Make();
            var result = helper.Procees(inputString);
            Assert.Equal(expectedOutput, result);

        }
    }
}
