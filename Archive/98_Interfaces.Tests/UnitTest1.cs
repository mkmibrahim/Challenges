namespace _98_Interfaces.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            TestTrack.Race(new ProductionRemoteControlCar());
            TestTrack.Race(new ExperimentalRemoteControlCar());
            // this should execute without an exception being thrown
        }

        [Fact]
        public void Test2()
        {
            var prod = new ProductionRemoteControlCar();
            TestTrack.Race(prod);
            var exp = new ExperimentalRemoteControlCar();
            TestTrack.Race(exp);
            Assert.Equal(10, prod.DistanceTravelled);
            // => 10
            Assert.Equal(20, exp.DistanceTravelled);
            // => 20
        }

        [Fact]
        public void Test3()
        {
            var prc1 = new ProductionRemoteControlCar();
            var prc2 = new ProductionRemoteControlCar();
            prc1.NumberOfVictories = 3;
            prc2.NumberOfVictories = 2;
            var rankings = TestTrack.GetRankedCars(prc1, prc2);
            Assert.Equal(prc1, rankings[1]);// => rankings[1] == prc1
        }
    }
}