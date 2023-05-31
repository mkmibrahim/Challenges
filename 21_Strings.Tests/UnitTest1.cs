namespace _21_Strings.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result = HighSchoolSweethearts.DisplaySingleLine("Lance Green", "Pat Riley");
            var expectedResult = "                  Lance Green ♡ Pat Riley                    ";
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test2()
        {
            string actual = HighSchoolSweethearts.DisplayGermanExchangeStudents("Norbert", "Heidi", new DateTime(2019, 1, 22), 1535.22f);
            Assert.Equal("Norbert and Heidi have been dating since 22.01.2019 - that's 1.535,22 hours", actual);
            //Assert.Contains("Norbert and Heidi have been dating since 22.01.2019 - that's ", actual);
        }
    }
}