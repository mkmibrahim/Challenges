using System.Numerics;

namespace _29_ExceptionFiltering.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var cth = new CalculatorTestHarness(new Calculator());
            Assert.Throws<CalculationException>(() => cth.Multiply(Int32.MaxValue, Int32.MaxValue));
        }

        [Fact]
        public void Test2()
        {
            var cth = new CalculatorTestHarness(new Calculator());
            var result = cth.TestMultiplication(6, 7);
            var expectedResult = "Multiply succeeded";
            Assert.Equal(expectedResult, result);
        }

        
    }
}