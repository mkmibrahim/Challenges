namespace _27_Tuples.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result = PhoneNumber.Analyze("631-555-1234");
            var expectedResult =  (false, true, "1234");
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test2()
        {
            Assert.True(PhoneNumber.IsFake(PhoneNumber.Analyze("631-555-1234")));
        }
    }
}