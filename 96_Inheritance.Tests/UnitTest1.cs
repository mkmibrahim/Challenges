using System.Threading;

namespace _96_Inheritance.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var warrior = new Warrior();
            Assert.Equal("Character is a Warrior", warrior.ToString());
        }

        [Fact]
        public void Test2()
        {
            var warrior = new Warrior();
            Assert.False(warrior.Vulnerable());
        }

        [Fact]
        public void Test3()
        {
            var wizard = new Wizard();
            wizard.PrepareSpell();
        }

        [Fact]
        public void Test4()
        {
            var wizard = new Wizard();
            Assert.True(wizard.Vulnerable());
        }

        [Fact]
        public void Test5()
        {
            var wizard = new Wizard();
            var warrior = new Warrior();

            wizard.PrepareSpell();
            Assert.Equal(12, wizard.DamagePoints(warrior));
        }

        [Fact]
        public void Test6()
        {
            var warrior = new Warrior();
            var wizard = new Wizard();

            Assert.Equal(10, warrior.DamagePoints(wizard));
        }

    }
}