using _04_LastSamplesOfNumber;
using System;
using Xunit;

namespace _04_LastSamplesOfNumber.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result = LastSamplesOfNumber.Give(5, 2);
            Assert.Equal(4.ToString(), result[0]);
            Assert.Equal(3.ToString(), result[1]);
        }

        [Fact]
        public void Test2()
        {
            var result = LastSamplesOfNumber.Give(10, 4);
            Assert.Equal(9.ToString(), result[0]);
            Assert.Equal(8.ToString(), result[1]);
            Assert.Equal(7.ToString(), result[2]);
            Assert.Equal(6.ToString(), result[3]);
        }
    }
}
