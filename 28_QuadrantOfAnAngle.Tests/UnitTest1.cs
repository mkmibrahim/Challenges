using Xunit;

namespace _28_QuadrantOfAnAngle.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(30, 1)]
        [InlineData(197, 3)]
        public void Test1(int angle, int expectedQuadrant)
        {
            var returnedQuadrant = QuadrantOfAnAngle.GetQuadrant(angle);
            Assert.Equal(expectedQuadrant, returnedQuadrant);
            
        }
    }
}
