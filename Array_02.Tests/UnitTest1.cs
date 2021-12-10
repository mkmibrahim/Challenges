using System;
using System.IO;
using System.Threading;
using Xunit;

namespace Array_02.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestShowPokeList()
        {
            var pokeTrader = new PokeTrader();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            pokeTrader.ShowPokeList();
            var consoleMessage = stringWriter.ToString();

            var expectedString = "Exchange Pokemon\r\n0. PIKACHU\r\n" +
                "1. CHARMELEON\r\n2. GEODUDE\r\n3. GYARADOS\r\n4. BUTTERFREE\r\n" +
                "5. MANKEY\r\n";

            Assert.Equal(expectedString, consoleMessage);
        }

        [Fact]
        public void TestGetFirstChoice()
        {
            var pokeTrader = new PokeTrader();
            var stringReader = new StringReader("testString");
            Console.SetIn(stringReader);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            
            var returnedString = pokeTrader.GetFirstChoice();

            Assert.Equal("testString", returnedString);
            var consoleMessage = stringWriter.ToString();
            var expectedString = "Choose a Pokemon (or -1 to quit):";
            Assert.Equal(expectedString, consoleMessage);
        }

        [Fact]
        public void TestGetSecondChoice()
        {
            var pokeTrader = new PokeTrader();
            var stringReader = new StringReader("testString");
            Console.SetIn(stringReader);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            var returnedString = pokeTrader.GetSecondChoice(0);

            Assert.Equal("testString", returnedString);
            var consoleMessage = stringWriter.ToString();
            var expectedString = "Choose a Pokemon to exchange with PIKACHU:";
            Assert.Equal(expectedString, consoleMessage);
        }

        [Theory]
        [InlineData("-1", "-1")]
        [InlineData("0", "0")]
        [InlineData("1", "1")]
        [InlineData("2", "2")]
        [InlineData("3", "3")]
        [InlineData("4", "4")]
        [InlineData("5", "5")]
        public void TestValidateChoice(string input, string expectedOutput)
        {
            var pokTrader = new PokeTrader();
            var result = pokTrader.ValidateChoice(input);
            Assert.Equal(expectedOutput, result);
        }

        [Fact]
        public void TestValidateChoiceWithInvalidInput()
        {
            var pokeTrader = new PokeTrader();
            var stringReader = new StringReader("1");
            Console.SetIn(stringReader);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            pokeTrader.ValidateChoice("-2");
            
            var consoleMessage = stringWriter.ToString();

            var expectedString = "Try Again!\r\n" +
                "Exchange Pokemon\r\n0. PIKACHU\r\n" +
                "1. CHARMELEON\r\n2. GEODUDE\r\n3. GYARADOS\r\n4. BUTTERFREE\r\n" +
                "5. MANKEY\r\n" +
                "Choose a Pokemon (or -1 to quit):";

            Assert.Equal(expectedString, consoleMessage);
        }

        [Fact]
        public void TestExchangePokemon()
        {
            var pokeTrader = new PokeTrader();
            pokeTrader.ExchangePokemon(1, 2);
            Assert.Equal("GEODUDE", pokeTrader.Pokelist[1]);
            Assert.Equal("CHARMELEON", pokeTrader.Pokelist[2]);
        }
    }
}
