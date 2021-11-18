using Xunit;

namespace _16_PrimeFactors.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void FacotrsOf369()
        {
            var result = PerfectNumber.Generate(369);
            Assert.Equal("3 3 41", result);
        }

        [Fact]
        public void FacotrsOf287()
        {
            var result = PerfectNumber.Generate(287);
            Assert.Equal("7 41", result);
        }
    }
}
