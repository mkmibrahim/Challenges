using System.ComponentModel.DataAnnotations;

namespace _91_Exceptions.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expectedResult = "16 + 51 = 67";
            Assert.Equal(expectedResult, SimpleCalculator.Calculate(16, 51, "+")); 

            expectedResult = "32 * 6 = 192";
            Assert.Equal(expectedResult, SimpleCalculator.Calculate(32, 6, "*"));

            expectedResult = "512 / 4 = 128";
            Assert.Equal(expectedResult, SimpleCalculator.Calculate(512, 4, "/"));
        }

        [Fact]
        public void Test2()
        {
            Assert.Throws<ArgumentOutOfRangeException>( () =>  SimpleCalculator.Calculate(100, 10, "-"));

            Assert.Throws<ArgumentException>(() => SimpleCalculator.Calculate(8, 2, ""));

            Assert.Throws<ArgumentNullException>(() =>  SimpleCalculator.Calculate(58, 6, null));
        }

        [Fact]
        public void Test3()
        {
            var expectedResult = "Division by zero is not allowed.";
            Assert.Equal(expectedResult, SimpleCalculator.Calculate(512, 0, "/"));
        }
    }
}