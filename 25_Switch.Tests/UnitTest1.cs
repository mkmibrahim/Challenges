namespace _25_Switch.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "goalie")]
        [InlineData(2, "left back")]
        [InlineData(3,"center back")]
        [InlineData(4,"center back")]
        [InlineData(5, "right back")]
        [InlineData(6, "midfielder")]
        [InlineData(7, "midfielder")]
        [InlineData(8, "midfielder")]
        [InlineData(9, "left wing")]
        [InlineData(10, "striker")]
        [InlineData(11, "right wing")]
        public void Test1(int shirtNumber, string discription)
        {
            var result = PlayAnalyzer.AnalyzeOnField(shirtNumber);
            var expectedResult = discription;
            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void Test2()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => PlayAnalyzer.AnalyzeOnField(20));
        }

        [Fact]
        public void Test3()
        {
            var result = PlayAnalyzer.AnalyzeOffField(5000);
            var expectedResult = "There are 5000 supporters at the match.";
            Assert.Equal(expectedResult, result);

            result = PlayAnalyzer.AnalyzeOffField("5 minutes to go!");
            expectedResult = "5 minutes to go!";
            Assert.Equal(expectedResult, result);

            Assert.Throws<ArgumentException>(()=> PlayAnalyzer.AnalyzeOffField(0.5));
        }

        [Fact]
        public void Test4()
        {
            var result = PlayAnalyzer.AnalyzeOffField(new Foul());
            var expectedResult = "The referee deemed a foul.";
            Assert.Equal(expectedResult, result);


            result = PlayAnalyzer.AnalyzeOffField(new Injury(8));
            expectedResult = "Oh no! Player 8 is injured. Medics are on the field.";
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test5()
        {
            var result = PlayAnalyzer.AnalyzeOffField(new Manager("José Mário dos Santos Mourinho Félix", null));
            var expectedResult = "José Mário dos Santos Mourinho Félix";
            Assert.Equal(expectedResult, result);

            result = PlayAnalyzer.AnalyzeOffField(new Manager("Jürgen Klopp", "Liverpool"));
            expectedResult = "Jürgen Klopp (Liverpool)";
            Assert.Equal(expectedResult, result);
        }
    }
}