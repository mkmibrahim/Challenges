using Xunit;

namespace _33_CheckIf.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("if else", "if else")]
        [InlineData("else", "if else")]
        public void Test1(string inputString, string outputString)
        {
            var str = inputString;
            var result = str.IfCheck();
            Assert.Equal(outputString, result);
        }
    }
}
