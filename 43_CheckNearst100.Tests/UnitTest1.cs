using System;
using Xunit;

namespace _43_CheckNearst100.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(78, 95, 95)]
        [InlineData(95, 95, 0)]
        [InlineData(99, 70, 99)]
        public void Test1(int firstNumber, int secondNumber, int expectedResult)
        {
            int[] intArray = new int[] { firstNumber, secondNumber };
            var result = intArray.FindNearest100();
            Assert.Equal(result, expectedResult);
        }
    }
}
