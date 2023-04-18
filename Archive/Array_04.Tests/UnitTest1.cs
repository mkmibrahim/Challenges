using System;
using System.IO;
using Xunit;

namespace Array_04.Tests
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
        public void TestSetElement()
        {
            var arrayInstance = ArrayClass.Make();

            for (var i = 0; i < 10; i++)
            {
                var value = i + 10;
                arrayInstance.SetValue(i, value);
                Assert.Equal(value, arrayInstance.GetValue(i));
            }
        }

        [Fact]
        public void TestPopulateArray()
        {
            ArrayClass arrayInstance = GetArrayInstancePopulated();

            for (var i = 0; i < 10; i++)
            {
                Assert.Equal(i, arrayInstance.GetValue(i));
            }
        }

        private static ArrayClass GetArrayInstancePopulated()
        {
            const string input = @"0
                                    1
                                    2
                                    3
                                    4
                                    5
                                    6
                                    7
                                    8
                                    9";

            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);
            var arrayInstance = ArrayClass.Make();

            arrayInstance.PopulateArrayFromConsole();
            return arrayInstance;
        }

        [Fact]
        public void TestGetValueToFind()
        {
            ArrayClass arrayInstance = GetArrayInstancePopulated();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            const string input = "5\r\n"; ;
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            var value = arrayInstance.GetValueToFind();

            var consoleMessage = stringWriter.ToString();
            var expectedString = "Value to find: ";
            Assert.Equal(expectedString, consoleMessage);
            Assert.Equal(5, value);
        }

        [Fact]
        public void TestDislayFindResult()
        {
            ArrayClass arrayInstance = GetArrayInstancePopulated();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            arrayInstance.DisplayFindResult(6);

            var consoleMessage = stringWriter.ToString();
            var expectedString = "6 is in slot 6.\r\n";
            Assert.Equal(expectedString , consoleMessage);
        }
    }
}
