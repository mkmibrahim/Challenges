namespace _14_Properties.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var wm = new WeighingMachine(precision: 3);
            Assert.Equal(3, wm.Precision);

        }

        [Fact]
        public void TestSetWeight()
        {
            var wm = new WeighingMachine(precision: 3);
            wm.Weight = 60.5;
            Assert.Equal(60.5, wm.Weight);   
        }

        [Fact]
        public void TestWeightException()
        {
            var wm = new WeighingMachine(precision: 3);
            Assert.Throws<ArgumentOutOfRangeException>(()=> wm.Weight = -10);    
        }

        [Fact]
        public void TestTareAdjustment()
        {
            var wm = new WeighingMachine(precision: 3);
            wm.TareAdjustment = -10.6;
            Assert.Equal(-10.6, wm.TareAdjustment);
        }

        [Fact]
        public void DefaultTareAdjustment()
        {
            var wm = new WeighingMachine(precision: 3);
            Assert.Equal(5.0, wm.TareAdjustment);
        }

        [Fact]
        public void Test10()
        {
            var wm = new WeighingMachine(precision: 3);
            wm.Weight = 100.770;
            wm.TareAdjustment = 10;
            Assert.Equal("90,770 kg", wm.DisplayWeight);
        }

        [Fact]
        public void Test11()
        {
            var wm = new WeighingMachine(precision: 1);
            wm.Weight = 100.770;
            wm.TareAdjustment = 10;
            Assert.Equal("90,8 kg", wm.DisplayWeight);
        }
    }
}