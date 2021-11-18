//complete the following program of statement reverse. program will take
//string as a input for statement and will print it in reverse form like given below:
//example1:
//Enter the Statement:
//this is programr
//    Reverse is:
//programr is this
//example2:
//Enter the Statement:
//my name is ABC
//    Reverse is:
//ABC is name my

using _09_StatementReverse;
using System;
using Xunit;

namespace _09_StatementReverse.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var returnedStatement = StatementReverser.Reverse("this is programr");
            Assert.Equal("programr is this", returnedStatement);
        }

        [Theory]
        [InlineData("my name is ABC", "ABC is name my")]
        public void Test2(string statement, string expectedReverse)
        {
            var returnedStatement = StatementReverser.Reverse(statement);
            Assert.Equal(expectedReverse, returnedStatement);

        }
    }
}
