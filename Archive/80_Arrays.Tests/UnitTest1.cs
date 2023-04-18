namespace _80_Arrays.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void LastWeekTest()
        {
            var result = BirdCount.LastWeek();
            var expectedResult = new int[] {0, 2, 5, 3, 7, 8, 4 };
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TodayTest()
        {
            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            var birdCount = new BirdCount(birdsPerDay);
            var result = birdCount.Today();
            Assert.Equal(1, result);
        }

        [Fact]
        public void IncrementTodaysCountTest()
        {
            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            var birdCount = new BirdCount(birdsPerDay);
            birdCount.IncrementTodaysCount();
            var result = birdCount.Today();
            Assert.Equal(2, result);
        }

        [Fact]
        public void HasDayWithoutBirdsTest()
        {
            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            var birdCount = new BirdCount(birdsPerDay);
            Assert.True(birdCount.HasDayWithoutBirds());
        }

        [Fact]
        public void CountForFirstDaysTest()
        {
            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            var birdCount = new BirdCount(birdsPerDay);
            Assert.Equal(14, birdCount.CountForFirstDays(4));
        }

        [Fact]
        public void BusyDaysTest()
        {
            int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
            var birdCount = new BirdCount(birdsPerDay);
            Assert.Equal(2, birdCount.BusyDays());
        }
    }
}