//Complete the following program which takes the input number then taken the
//number to be searched then find outs the number of occurrence of the given input number from that number. to understand bettor scenario is given below:
//Example1:
//Enter the number:
//43423
//Enter number to search:
//4
//Number of occurence of given number is:
//2

//Example2:
//Enter the number:
//43423
//Enter number to search:
//8
//Number of occurence of given number is:
//0

using Xunit;

namespace _7_NumberOfOccurence.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var numberOfOccurences = OccurencesFinder.GetNumberOfOccurences(43423, 4);
            Assert.Equal(2, numberOfOccurences);
        }

        [Theory]
        [InlineData(43423, 3, 2)]
        [InlineData(43423, 8, 0)]
        public void TestNumberOfOccurences(int number, int searchNumber, int expectedOccurences)
        {
            var numberOfOccurences = OccurencesFinder.GetNumberOfOccurences(number, searchNumber);
            Assert.Equal(expectedOccurences, numberOfOccurences);

        }


    }
}