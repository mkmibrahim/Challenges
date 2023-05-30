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
    }
}