//Write a program which accepts 3 integers and sort them in ascending order.

//    For ex :
//1) if user input 39 26 28 then output will be 26 28 39.
//2) if user input 3934 2426 4628 then output will be 2426 3934 4628.

//Write a program which accepts 3 integers and sort them in ascending order.

//    For ex :
//1) if user input 39 26 28 then output will be 26 28 39.
//2) if user input 3934 2426 4628 then output will be 2426 3934 4628.
using Xunit;

namespace _11_SortThreeNumbers.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result = NumberSorter.Sort(39, 26, 28);
            Assert.Equal(26, result[0]);
            Assert.Equal(28, result[1]);
            Assert.Equal(39, result[2]);
        }

        [Fact]
        public void Test2()
        {
            var result = NumberSorter.Sort(3934, 2426, 4628);
            Assert.Equal(2426, result[0]);
            Assert.Equal(3934, result[1]);
            Assert.Equal(4628, result[2]);
        }
    }
}
