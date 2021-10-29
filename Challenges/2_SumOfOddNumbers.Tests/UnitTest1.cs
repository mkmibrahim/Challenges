using System;
using Xunit;

namespace _2_SumOfOddNumbers.Tests
{
    public class UnitTest1
    {
        //1.If the limit is 10 then the program should print the sum of odd numbers from 1 to 10
        //i.e. 1 + 3 + 5 + 7 + 9 = 25
        //So the program should print 25.
        //2. If the limit is 15 then the program should print sum of odd numbers from 1 to 15
        //i.e. 1 + 3 + 5 + 7 + 9 + 11 + 13 + 15 = 64
        //So the program should print 64

        [Theory]
        [InlineData(10, 25)]
        [InlineData(15, 64)]
        public void Test1(int limit, int expectedResult)
        {
            Assert.Equal(expectedResult, SumOfOddNumbers.Calculate(limit));
        }
    }
}
