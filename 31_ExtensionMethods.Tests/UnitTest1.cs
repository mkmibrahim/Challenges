namespace _31_ExtensionMethods.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var log = "[INFO]: File Deleted.";
            var result = log.SubstringAfter(": "); 
            var expectedResult = "File Deleted.";
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test2()
        {
            var log = "[INFO]: File Deleted.";
            var result = log.SubstringBetween("[", "]"); 
            var expectedResult = "INFO";
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test3()
        {
            var log = "[ERROR]: Missing ; on line 20.";
            var result = log.Message(); 
            var expectedResult = "Missing ; on line 20.";
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test4()
        {
            var log = "[ERROR]: Missing ; on line 20.";
            var result = log.LogLevel(); 
            var expectedResult = "ERROR";
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test5()
        {
            Assert.Equal("SOMETHING", "FIND >>> SOMETHING <===< HERE".SubstringBetween(">>> ", " <===<"));
        }
    }
}