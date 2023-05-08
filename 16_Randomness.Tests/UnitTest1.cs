using System.Numerics;

namespace _16_Randomness.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var player = new Player();
            var result = player.RollDie();
            Assert.True(1 <= result);
            Assert.True(18 >= result);
        }

        [Fact]
        public void Test2()
        {
            var player = new Player();
            var result = player.GenerateSpellStrength();
            Assert.True(0.0 <= result);
            Assert.True(100.0 >= result);
            // => >= 0.0 < 100.0
        }
    }
}