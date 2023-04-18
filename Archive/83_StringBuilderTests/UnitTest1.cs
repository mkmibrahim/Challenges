using _83_StringBuilder;

namespace _83_StringBuilderTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void CleanTest_1()
        {
            var result = CleanerClass.Clean("my   Id");
            Assert.Equal("my___Id", result);
        }

        [Theory]
        [InlineData("my\0Id", "myCTRLId")]
        [InlineData("à-ḃç", "àḂç")]
        //[InlineData("1My2Finder3", "MyFinder")]
        [InlineData("MyΟβιεγτFinder", "MyΟFinder" )]
        public void CleanTest_2(string inputString, string expectedString)
        {
            var result = CleanerClass.Clean(inputString);
            Assert.Equal(expectedString, result);

        }
    }
}