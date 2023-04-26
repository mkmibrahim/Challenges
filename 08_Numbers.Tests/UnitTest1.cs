using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using Xunit;
using static _08_Numbers.Program;

namespace _08_Numbers.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(0.77, AssemblyLine.SuccessRate(10));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(1193.4, AssemblyLine.ProductionRatePerHour(6));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(19, AssemblyLine.WorkingItemsPerMinute(6));
        }
    }
}
