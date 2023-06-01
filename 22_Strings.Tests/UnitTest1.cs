namespace _22_Strings.Tests
{
    public class UnitTest1
    {
        

        [Fact]
        public void Test1()
        {
            var expectedResult = "Invalid operation";
            var result = LogLine.Message("[ERROR]: Invalid operation");
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test2()
        {
            var result = LogLine.Message("[WARNING]:  Disk almost full\r\n");
            var expectedMessage = "Disk almost full";
            Assert.Equal(expectedMessage, result);
        }

        [Fact]
        public void Test3()
        {
            var result = LogLine.LogLevel("[ERROR]: Invalid operation");
            var expectedLogLevel = "error";
            Assert.Equal(expectedLogLevel, result);
        }

        [Fact]
        public void Test4()
        {
            var result = LogLine.Reformat("[INFO]: Operation completed");
            var expectedResult = "Operation completed (info)";
            Assert.Equal(expectedResult, result);
        }
    }
}