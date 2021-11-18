using System;
using Xunit;

namespace _17_NumberOccurencesInArray.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("12 15 15 16 14 45 23 15", 15 , 3)]
        [InlineData("45 45 15 18 24 45 23 45", 45, 4)]
        public void Test1(string inputArray,int number, int expectedNrOfOccurences )
        {
            var result = OccurencesCounter.Get(inputArray, number);
            Assert.Equal(expectedNrOfOccurences, result);
        }
    }
}
