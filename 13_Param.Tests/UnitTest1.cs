namespace _13_Param.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var car = RemoteControlCar.Buy();
            car.SetSponsors("Exercism", "Walker Industries", "Acme Co.");
            var sp2 = car.DisplaySponsor(sponsorNum: 1);
            Assert.Equal("Walker Industries", sp2);
            // => "Walker Industries"
        }

        [Fact]
        public void Test2()
        {
            var car = RemoteControlCar.Buy();
            car.Drive();
            car.Drive();
            int serialNum = 4;
            //car.GetTelemetryData(ref serialNum, out int batteryPercentage, out int distanceDrivenInMeters);
            Assert.True(car.GetTelemetryData(ref serialNum, out int batteryPercentage, out int distanceDrivenInMeters));
            Assert.Equal(4L, serialNum);
            Assert.Equal(80, batteryPercentage);
            Assert.Equal(4, distanceDrivenInMeters);
            

            serialNum = 1;
            //car.GetTelemetryData(ref serialNum, out batteryPercentage, out distanceDrivenInMeters);
            Assert.False(car.GetTelemetryData(ref serialNum, out batteryPercentage, out distanceDrivenInMeters));
            Assert.Equal(4L, serialNum);
            Assert.Equal(-1, batteryPercentage);
            Assert.Equal(-1, distanceDrivenInMeters);
            // => false, 4L, -1, -1
        }

        [Fact]
        public void Test3()
        {
            var car = RemoteControlCar.Buy();
            car.Drive();
            car.Drive();
            var tc = new TelemetryClient(car);
            int serialNum = 4;
            Assert.Equal("usage-per-meter=5", tc.GetBatteryUsagePerMeter(serialNum));

            serialNum = 1;
            Assert.Equal("no data", tc.GetBatteryUsagePerMeter(serialNum));
        }

        [Fact]
        public void Test4()
        {
            var car = RemoteControlCar.Buy();
            var tc = new TelemetryClient(car);
            Assert.Equal("no data", tc.GetBatteryUsagePerMeter(serialNum: 1));
        }

    }
}