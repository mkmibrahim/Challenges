using System;
using Xunit;

namespace _44_RangeInclusive.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(78,95, false)]
        [InlineData(25, 35, false)]
        [InlineData(40, 50, true)]
        [InlineData(55, 60, true)]
        public void Test1(int firstInt, int SecondInt, bool expectedResult)
        {
            int[] intArray = new int[] {firstInt, SecondInt};
            bool result = intArray.CheckRange();
            Assert.Equal(expectedResult, result);


        }
    }
}
