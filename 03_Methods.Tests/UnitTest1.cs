using System;
using Xunit;

namespace _03_Methods.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var character = new Character();
            character.Class = "Wizard";
            character.Level = 4;
            character.HitPoints = 28;

            Assert.Equal("You're a level 4 Wizard with 28 hit points.",
                GameMaster.Describe(character));
        }

        [Fact]
        public void Test2()
        {
            var destination = new Destination();
            destination.Name = "Muros";
            destination.Inhabitants = 732;

            Assert.Equal("You've arrived at Muros, which has 732 inhabitants.",
                GameMaster.Describe(destination));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal("You're traveling to your destination on horseback.",
                GameMaster.Describe(TravelMethod.Horseback));
        }

        [Fact]
        public void Test4()
        {
            var character = new Character();
            character.Class = "Wizard";
            character.Level = 4;
            character.HitPoints = 28;

            var destination = new Destination();
            destination.Name = "Muros";
            destination.Inhabitants = 732;

            Assert.Equal("You're a level 4 Wizard with 28 hit points. You're traveling to your destination on horseback. You've arrived at Muros, which has 732 inhabitants.",
                GameMaster.Describe(character, destination, TravelMethod.Horseback));
        }

        [Fact]
        public void Test5()
        {
            var character = new Character();
            character.Class = "Wizard";
            character.Level = 4;
            character.HitPoints = 28;

            var destination = new Destination();
            destination.Name = "Muros";
            destination.Inhabitants = 732;

            Assert.Equal("You're a level 4 Wizard with 28 hit points. You're traveling to your destination by walking. You've arrived at Muros, which has 732 inhabitants.",
                GameMaster.Describe(character, destination));
            
        }
    }
}
