using System.Drawing;

namespace _24_Structs.Tests
{
    public class UnitTest1
    {
        #region Helpers
        private Plot CreatePlot(Coord coord1, Coord coord2, Coord coord3, Coord coord4)
        {
            return new Plot(coord1,coord2,coord3,coord4);
        }

        #endregion

        [Fact]
        public void Test1()
        {
            var plot = new Plot(new Coord(1,1), new Coord(2,1), new Coord(1,2), new Coord(2,2));
            Assert.NotNull(plot);
        }

        [Fact]
        public void Test2()
        {
            var ch = new ClaimsHandler();
            ch.StakeClaim(CreatePlot(new Coord(1, 1), new Coord(2, 1), new Coord(1, 2), new Coord(2, 2)));
            var claimed = ch.IsClaimStaked(CreatePlot(new Coord(1, 1), new Coord(2, 1), new Coord(1, 2), new Coord(2, 2)));
            Assert.True(claimed);
        }

        

        [Fact]
        public void Test3()
        {
            var ch = new ClaimsHandler();
            ch.StakeClaim(CreatePlot(new Coord(1, 1), new Coord(2, 1), new Coord(1, 2), new Coord(2, 2)));
            ch.StakeClaim(CreatePlot(new Coord(10, 1), new Coord(20, 1), new Coord(10, 2), new Coord(20, 2)));
            var lastClaim = ch.IsLastClaim(CreatePlot(new Coord(10, 1), new Coord(20, 1), new Coord(10, 2), new Coord(20, 2)));
            Assert.True(lastClaim);
        }

        [Fact]
        public void Test4()
        {
            var ch = new ClaimsHandler();
            var longer = CreatePlot(new Coord(10, 1), new Coord(20, 1), new Coord(10, 2), new Coord(20, 2));
            var shorter = CreatePlot(new Coord(1, 1), new Coord(2, 1), new Coord(1, 2), new Coord(2, 2));
            ch.StakeClaim(longer);
            ch.StakeClaim(shorter);
            Assert.Equal(longer, ch.GetClaimWithLongestSide());

        }
    }
}