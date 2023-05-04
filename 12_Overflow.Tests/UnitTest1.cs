namespace _12_Overflow.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("10000000", CentralBank.DisplayDenomination(10000L, 1000L));
            
            Assert.Equal("*** Too Big ***", CentralBank.DisplayDenomination(long.MaxValue / 2, 10000L));
        }

        [Theory]
        [InlineData("5550000",555f, 10000f)]
        [InlineData("*** Too Big ***",float.MaxValue / 2,10000f)]
        public void Test2(string expectedResult, float @base, float multiplier)
        {
            Assert.Equal(expectedResult,CentralBank.DisplayGDP(@base, multiplier));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal("5550000000", CentralBank.DisplayChiefEconomistSalary(555000m, 10000m));

            Assert.Equal("*** Much Too Big ***", CentralBank.DisplayChiefEconomistSalary(555000m, decimal.MaxValue / 2L));
 
        }
    }
}