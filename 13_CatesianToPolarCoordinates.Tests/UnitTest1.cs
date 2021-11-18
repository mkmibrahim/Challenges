using Xunit;
// ReSharper disable InconsistentNaming

namespace _13_CatesianToPolarCoordinates.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3,5, 5.8309, 59.0362)]
        [InlineData(20, 34, 39.4461, 59.5344)]
        public void Test1(double x, double y, double expected_r, double expected_theta)
        {
            var cartesianCoordinate = new CartesianToPolar.CartesianCoordinate
            {
                x = x,
                y = y
            };

            var calculatedPolarCoordinate = CartesianToPolar.Convert(cartesianCoordinate);
            Assert.Equal(expected_r, calculatedPolarCoordinate.r);
            Assert.Equal(expected_theta, calculatedPolarCoordinate.theta);
        }
    }
}
