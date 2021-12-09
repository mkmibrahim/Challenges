using System;
using Xunit;

namespace Array_02.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var pokeTrader = new PokeTrader();
            pokeTrader.ExchangePokemon(1, 2);
            Assert.Equal("GEODUDE", pokeTrader.Pokelist[1]);
            Assert.Equal("CHARMELEON", pokeTrader.Pokelist[2]);
        }
    }
}
