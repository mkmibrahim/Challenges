using System;
using Xunit;

namespace _07_Nullability.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expectedResult = "[734] - Ernest Johnny Payne - STRATEGIC COMMUNICATION";
            Assert.Equal(expectedResult, Badge.Print(734, "Ernest Johnny Payne", "Strategic Communication"));
        }

        [Fact]
        public void Test2()
        {
            var expectedResult = "Jane Johnson - PROCUREMENT";
            Assert.Equal(expectedResult, Badge.Print(id: null, "Jane Johnson", "Procurement"));
        }

        [Fact]
        public void Test3()
        {
            var expectedResult = "[254] - Charlotte Hale - OWNER";
            Assert.Equal(expectedResult, Badge.Print(254, "Charlotte Hale", department: null));
        }

        [Fact]
        public void Test4()
        {
            var expectedResult = "Charlotte Hale - OWNER";
            Assert.Equal(expectedResult, Badge.Print(id: null, "Charlotte Hale", department: null));
        }

    }
}
