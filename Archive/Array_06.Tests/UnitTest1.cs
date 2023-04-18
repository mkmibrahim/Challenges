using System;
using System.IO;
using Xunit;

namespace Array_06.Tests
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
        public void TestConsoleOutput()
        {
            var arrayInstance = ArrayClass.Make();
            var stringWrighter = new StringWriter();
            Console.SetOut(stringWrighter);

            arrayInstance.ShowContents();

            var consoleMessage = stringWrighter.ToString();
            var expectedMessage = "Slot 0 of array has value -113\r\nSlot 1 of array has value -113\r\nSlot 2 of array has value -113\r\nSlot 3 of array has value -113\r\nSlot 4 of array has value -113\r\nSlot 5 of array has value -113\r\nSlot 6 of array has value -113\r\nSlot 7 of array has value -113\r\nSlot 8 of array has value -113\r\nSlot 9 of array has value -113\r\n";
            Assert.Equal(expectedMessage, consoleMessage);

        }
    }
}
