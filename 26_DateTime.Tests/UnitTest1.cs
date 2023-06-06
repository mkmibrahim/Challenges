namespace _26_DateTime.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // For a student in NY
            var result = Appointment.ShowLocalTime(new DateTime(2030, 7, 25, 13, 45, 0));
            var expectedResult = new DateTime(2030, 7, 25, 15, 45, 0);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void test2()
        {
            var result = Appointment.Schedule("7/25/2030 13:45:00", Location.Paris);
            var expectedResult = new DateTime(2030, 7, 25, 11, 45, 0);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test3()
        {
            var result = Appointment.GetAlertTime(new DateTime(2030, 7, 25, 14, 45, 0), AlertLevel.Early);
            var expectedResult = new DateTime(2030, 7, 24, 14, 45, 0);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test4()
        {
            Assert.True(Appointment.HasDaylightSavingChanged(new DateTime(2020, 3, 30, 14, 45, 0), Location.London));
        }

        [Fact]
        public void Test5()
        {
            var result = Appointment.NormalizeDateTime("25/11/2019 13:45:00", Location.London);
            var expectedResult = new DateTime(2019, 11, 25, 13, 45, 0);
            Assert.Equal(expectedResult, result);

            result = Appointment.NormalizeDateTime("25/11/2019 13:45:00", Location.NewYork);
            expectedResult = new DateTime(1, 1, 1, 0, 0, 0);
            Assert.Equal(expectedResult, result);

        }
    }
}