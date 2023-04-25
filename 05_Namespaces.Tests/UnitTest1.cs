using System;
using Xunit;

namespace _05_Namespaces.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var test = Type.GetType("System.Int32");
            
            Assert.NotNull(test);
            //var carBuilderType = Type.GetType("Combined.CarBuilder");
            //Assert.NotNull(carBuilderType);
        }
    }
}
