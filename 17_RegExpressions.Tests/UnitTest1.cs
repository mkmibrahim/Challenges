namespace _17_RegExpressions.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var lp = new LogParser();
            Assert.True(lp.IsValidLine("[ERR] A good error here"));
            // => true
            Assert.False(lp.IsValidLine("Any old [ERR] text"));
            // => false
            Assert.False(lp.IsValidLine("[BOB] Any old text"));
            // => false
        }

        [Fact]
        public void Test2()
        {
            var lp = new LogParser();
            var result = lp.SplitLogLine("Section 1<===>Section 2<^-^>Section 3");
            Assert.Equal(new String[]{"Section 1", "Section 2", "Section 3"}, result);
        }

        [Fact]
        public void Test3()
        {
            string lines =
                "[INF] passWord " + Environment.NewLine + // contains 'password' but not surrounded by quotation marks
                "\"passWord\"" + Environment.NewLine + // count this one
                "[INF] User saw error message \"Unexpected Error\" on page load." + Environment.NewLine + //does not contain 'password'
                "[INF] \"The secret password was added by the user\""; // count this one

            var lp = new LogParser();
            Assert.Equal(2, lp.CountQuotedPasswords(lines));
            
        }
    }
}