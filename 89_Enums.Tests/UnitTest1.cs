namespace _89_Enums.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result = LogLine.ParseLogLevel("[INF]: File deleted");
            Assert.Equal(LogLevel.Info, result);
        }

        [Fact]
        public void Test2()
        {
            var result = LogLine.ParseLogLevel("[XYZ]: Overly specific, out of context message");
            Assert.Equal(LogLevel.Unknown, result);
        }

        [Fact]
        public void Test3()
        {
            var result = LogLine.OutputForShortLog(LogLevel.Error, "Stack overflow");
            Assert.Equal("6:Stack overflow", result);
        }
    }
}