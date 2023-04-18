using System;
using Xunit;

namespace _19_GreyCode.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var grayto2 = Gray.grayToNumber(2);
            Assert.Equal(4, grayto2.Length);
            Assert.Equal("00", grayto2[0]);
            Assert.Equal("01", grayto2[1]);
            Assert.Equal("11", grayto2[2]);
            Assert.Equal("10", grayto2[3]);
        }

        [Fact]
        public void Test2()
        {
            var grayto3 = Gray.grayToNumber(3);
            Assert.Equal(8, grayto3.Length);
            Assert.Equal("000", grayto3[0]);
            Assert.Equal("001", grayto3[1]);
            Assert.Equal("011", grayto3[2]);
            Assert.Equal("010", grayto3[3]);
            Assert.Equal("110", grayto3[4]);
            Assert.Equal("111", grayto3[5]);
            Assert.Equal("101", grayto3[6]);
            Assert.Equal("100", grayto3[7]);
        }
    }
}
