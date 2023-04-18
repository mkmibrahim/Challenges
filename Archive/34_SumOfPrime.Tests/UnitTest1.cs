using System;
using Xunit;

namespace _34_SumOfPrime.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 4)]
        [InlineData(4, 4)]
        [InlineData(5,9)]
        public void Test1(int higherLimit, int sumOfPrimeNumbers)
        {
            var helper = PrimeHelper.Make();
            var result = helper.GetSumPrimeNumberToNumber(higherLimit);
            Assert.Equal(sumOfPrimeNumbers, result);

        }
    }
}
