using System;
using Xunit;

namespace _18_WindChill.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(20, 7, 11.034900625509994)]
        [InlineData(70, 15, 70.26098370128452)]
        public void Test1(double temp, double wind, double expectedWindChill)
        {
            var returnedWindChill = WindChill.Calculate(temp, wind);
            Assert.Equal(expectedWindChill, returnedWindChill);
        }
    }
}
