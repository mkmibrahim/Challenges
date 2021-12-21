using System;
using System.IO;
using Xunit;

namespace Array_07.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var arrayInstance = ArrayClass.Make();
            Assert.NotNull(arrayInstance);
        }

        [Fact]
        public void TestShowContents()
        {
            var arrayInstance = ArrayClass.Make();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            arrayInstance.ShowContents();

            var displayedMessage = stringWriter.ToString();
            var expectedMessage = "0:PIKACHU\r\n1:CHARMELEON\r\n2:GEODUDE\r\n3:GYARADOS\r\n4:BUTTERFREE\r\n5:MANKEY\r\n";
            Assert.Equal(expectedMessage, displayedMessage);
        }

        [Fact]
        public void TestAskChoice()
        {
            var arrayInstance = ArrayClass.Make();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var stringReader = new StringReader("1");
            Console.SetIn(stringReader);

            var receivedResult = arrayInstance.AskChoice();

            var displayedMessage = stringWriter.ToString();
            var expectedMessage = "Choose a Pokemon to exchange with PIKACHU:";
            Assert.Equal(expectedMessage, displayedMessage);
            Assert.Equal(1, receivedResult);
        }

        [Fact]
        public void TestProcessChoiceExit()
        {
            var arrayInstance = ArrayClass.Make();

            var receivedResult = arrayInstance.ProcessChoice(0);

            Assert.False(receivedResult);
        }

        [Fact]
        public void TestProcessChoice_1()
        {
            var arrayInstance = ArrayClass.Make();
            
            arrayInstance.ProcessChoice(1);

            Assert.Equal("CHARMELEON", arrayInstance.ArrayElements[0]);
            
        }

    }
}
