namespace _84_Classes.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void BuyTest()
        {
            Assert.True(true);
            RemoteControlCar car = RemoteControlCar.Buy();
        }

        [Fact]
        public void DistanceDrivenTest()
        {
            var car = RemoteControlCar.Buy();
            Assert.Equal("Driven 0 meters", car.DistanceDisplay());
        }

        [Fact]
        public void BatteryDisplayTest()
        {
            var car = RemoteControlCar.Buy();
            Assert.Equal("Battery at 100%", car.BatteryDisplay());
        }

        [Fact]
        public void UpdateMetersDrivenTest()
        {
            var car = RemoteControlCar.Buy();
            car.Drive();
            car.Drive();
            Assert.Equal("Driven 40 meters", car.DistanceDisplay());
        }

        [Fact]
        public void UpdateBatteryPercentageTest()
        {
            var car = RemoteControlCar.Buy();
            car.Drive();
            car.Drive();
            Assert.Equal("Battery at 98%", car.BatteryDisplay());
        }

        [Fact]
        public void DrainedBatteryTest()
        {
            var car = RemoteControlCar.Buy();
            for(int i = 0; i < 1000; i++)
            {
                car.Drive();
            }
            Assert.Equal("Driven 2000 meters", car.DistanceDisplay());
            Assert.Equal("Battery empty", car.BatteryDisplay());
        }
    }
}