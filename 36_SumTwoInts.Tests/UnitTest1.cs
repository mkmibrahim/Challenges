using System;
using Xunit;

namespace _36_SumTwoInts.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(3,2,5)]
        [InlineData(2,2,12)]

        public void Test1(int input1, int input2, int expectedResult)
        {
            var helper = ProgramHelper.Make();
            var result = helper.Add(input1, input2);
            Assert.Equal(expectedResult, result);
        }
    }
}
