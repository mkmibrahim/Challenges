namespace _86_Constructors.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CarTest()
        {
            int speed = 5;
            int batteryDrain = 2;
            var car = new RemoteControlCar(speed, batteryDrain);

            Assert.NotNull(car);
        }

        [Fact]
        public void RaceTrackTest()
        {
            int distance = 800;
            var raceTrack = new RaceTrack(distance);

            Assert.NotNull(raceTrack);
        }

        [Fact]
        public void DriveTest()
        {
            int speed = 5;
            int batteryDrain = 2;
            var car = new RemoteControlCar(speed, batteryDrain);
            car.Drive();

            Assert.Equal(5, car.DistanceDriven());
        }

        [Fact]
        public void CheckDrainedBatteryTest()
        {
            int speed = 5;
            int batteryDrain = 2;
            var car = new RemoteControlCar(speed, batteryDrain);
            car.Drive();

            Assert.False(car.BatteryDrained());
            
        }

        [Fact]
        public void NitroTest()
        {
            var car = RemoteControlCar.Nitro();
            car.Drive();
            Assert.Equal(50, car.DistanceDriven());
        }

        [Fact]
        public void CheckFinishTrackTest()
        {
            int speed = 5;
            int batteryDrain = 2;
            var car = new RemoteControlCar(speed, batteryDrain);

            int distance = 100;
            var raceTrack = new RaceTrack(distance);

            Assert.True(raceTrack.TryFinishTrack(car));
        }
    }
}