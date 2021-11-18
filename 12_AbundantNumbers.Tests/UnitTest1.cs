using Xunit;

namespace _12_AbundantNumbers.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(20, new[]{12,18,20})]
        [InlineData(40, new[]{12,18,20,24,30,36,40})]
        public void Test(int limit, int[] expectedResult)
        {
            var result = AbundantNumbers.GetUpToLimit(limit);
            Assert.Equal(expectedResult.Length, result.Length);
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }

        [Theory]
        [InlineData("1 11", 4)]
        [InlineData("11 111", 34)]
        public void Test2(string limitsString, int expectedNumberOfOnes)
        {
            var numberOfOnes = OnesCounter.Get(limitsString);
            Assert.Equal(expectedNumberOfOnes, numberOfOnes);
        }
    }
}
