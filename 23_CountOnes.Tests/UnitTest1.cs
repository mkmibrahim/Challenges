//Write a program which accepts two integers as a minimum and maximum limit and calculates total of how many 1s were their within the limit.

//For ex:

//1) if user input 1 11 then it should print 4.

//2) if user input 11 111 then it should print 34using System;
using Xunit;

namespace _23_CountOnes.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 11,4)]
        [InlineData(11, 111, 34)]
        public void Test1(int firstNumer, int secondNumer, int expectedResult)
        {
            var result = Counter.CountOnes(firstNumer, secondNumer);
            Assert.Equal(expectedResult, result);

        }
    }
}
