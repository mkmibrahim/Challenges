namespace _87_DateTime.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(new DateTime(2019, 7, 25, 13, 45, 0), Appointment.Schedule("7/25/2019 13:45:00"));

        }

        [Fact]
        public void HasPassedTest()
        {
            Assert.True(Appointment.HasPassed(new DateTime(1999, 12, 31, 9, 0, 0)));
        }

        [Fact]
        public void HasPassedTestFalse()
        {
            Assert.False(Appointment.HasPassed(new DateTime(2050, 12, 31, 9, 0, 0)));
        }

        [Fact]
        public void isAfternoonAppointmentTest()
        {
            Assert.True(Appointment.IsAfternoonAppointment(new DateTime(2019, 03, 29, 15, 0, 0)));
        }

        [Fact]
        public void DescribeTest()
        {
            Assert.Equal("You have an appointment on 3/29/2019 3:00:00 PM.",
                Appointment.Description(new DateTime(2019, 03, 29, 15, 0, 0)));
        }

        [Fact]
        public void AnniversaryTest()
        {
            Assert.Equal(new DateTime(2023, 9, 15, 0, 0, 0),
                Appointment.AnniversaryDate());
        }

        [Fact]
        public void test2()
        {
            Assert.False(Appointment.IsAfternoonAppointment(new DateTime(2019, 9, 1, 18, 0, 0)));
        }
    }
}