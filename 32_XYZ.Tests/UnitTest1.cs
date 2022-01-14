using System;
using Xunit;

namespace _32_XYZ.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var helper = ProgramHelper.Make();
            helper.Set(0, 5);
            helper.Set(1, 6);
            helper.Set(2, 7);
            var firstResult = helper.GetFirstResult();
            Assert.Equal(77, firstResult);

            var secondResult = helper.GetSecondResult();
            Assert.Equal(72, secondResult);
        }
    }
}
