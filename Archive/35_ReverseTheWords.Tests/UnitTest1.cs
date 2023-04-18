using System;
using Xunit;

namespace _35_ReverseTheWords.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var startStr = "Display the pattern like pyramid using the alphabet.";
            var endStr = "alphabet.the using pyramid like pattern the Display";

            string result = ProgramHelper.Reverse(startStr);
            Assert.Equal(endStr, result);
        }
    }
}
