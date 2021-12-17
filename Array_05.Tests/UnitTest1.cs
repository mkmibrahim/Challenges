using System;
using System.IO;
using Xunit;

namespace Array_05.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestMakeArray()
        {
            var arrayInstance = ArrayHelper.Make();
            for (int i = 0; i < 10; i++)
            {
                var value = arrayInstance.GetElement(i);
                Assert.True(value > 0);
                Assert.True(value < 50);
            }
        }

        [Fact]
        public void TestShowArray()
        {
            int[] testArrayElements = new int[10]
                        {
                                 1, 2, 3, 4, 5, 6, 7, 7, 9, 14
                        };
            var arrayInstance = ArrayHelper.Make(testArrayElements);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            arrayInstance.ShowArray();

            var consoleMessage = stringWriter.ToString();
            var expecterMessage = "Array: 1 2 3 4 5 6 7 7 9 14\r\n";
            Assert.Equal(expecterMessage, consoleMessage);
        }

        


        [Fact]
        public void TestValueToFind()
        {
            var arrayInstance = ArrayHelper.Make();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var stringReader = new StringReader("6");
            Console.SetIn(stringReader);

            var value = arrayInstance.GetValueToFind();

            var consoleMessage = stringWriter.ToString();
            var expectedMessage = "Value to find:";
            Assert.Equal(expectedMessage, consoleMessage);

            Assert.Equal(6, value);
        }

        [Fact]
        public void TestFindInt()
        {
            int[] testArrayElements = new int[10]
            {
                 1, 2, 3, 4, 5, 6, 7, 7, 9, 14
            };
            var arrayInstance = ArrayHelper.Make(testArrayElements);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            arrayInstance.Find(12);

            var consoleMessage = stringWriter.ToString();
            var expecterMessage = "12 was found 0 times\r\n";
            Assert.Equal(expecterMessage, consoleMessage);
        }

        [Fact]
        public void TestFindInt_2times()
        {
            int[] testArrayElements = new int[10]
            {
                 1, 2, 3, 4, 5, 6, 7, 7, 9, 14
            };
            var arrayInstance = ArrayHelper.Make(testArrayElements);
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            arrayInstance.Find(7);

            var consoleMessage = stringWriter.ToString();
            var expecterMessage = "7 was found 2 times\r\n";
            Assert.Equal(expecterMessage, consoleMessage);
        }
    }
}
