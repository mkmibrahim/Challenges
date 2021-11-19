
using System;
using Xunit;

namespace _20_SexyPairs.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestWithLimit20()
        {
            var returnedPairs = Pairs.GetSexyPairsToLimit(20);
            Assert.Equal(4, returnedPairs.Length);
            var firstReturnedPair = returnedPairs[0];
            Assert.Equal(5, firstReturnedPair.firstnumber);
            Assert.Equal(11, firstReturnedPair.secondnumber);

            var secondReturnedPair = returnedPairs[1];
            Assert.Equal(7, secondReturnedPair.firstnumber);
            Assert.Equal(13, secondReturnedPair.secondnumber);
            
            var thirdReturnedPair = returnedPairs[2];
            Assert.Equal(11, thirdReturnedPair.firstnumber);
            Assert.Equal(17, thirdReturnedPair.secondnumber);

            var fourthReturnedPair = returnedPairs[3];
            Assert.Equal(13, fourthReturnedPair.firstnumber);
            Assert.Equal(19, fourthReturnedPair.secondnumber);
        }

        [Theory]
        [InlineData(20, "(5 11) (7 13) (11 17) (13 19)")]
        [InlineData(30, "(5 11) (7 13) (11 17) (13 19) (17 23) (23 29)")]
        public void TestString(int limit, string expectedString)
        {
            var returnedString = Pairs.GetStringSexyPairsToLimit(limit);
            Assert.Equal(expectedString, returnedString);
        }
    }
}
