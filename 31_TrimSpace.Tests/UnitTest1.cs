using System;
using Xunit;

namespace _31_TrimSpace.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var helper = ProgramHelper.Make();
            helper.SetNumber(0, 10);
            helper.SetNumber(1, 15);
            helper.SetNumber(2, 20);
            helper.SetNumber(3, 30);
            var avg = helper.GetAverage();
            Assert.Equal(18, avg);

        }
    }
}
