// Write a C# program which will accept a list of integers
// and checks how many integers are needed to complete the range.
// Sample Example [1, 3, 4, 7, 9], between 1 - 9-> 2, 5, 6, 8 are
// not present in the list. So output will be 4.

using System;
using Xunit;

namespace _37_NeededInts.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] array = { 1, 3, 4, 7, 9 };
            var helper1 = helper.Make(array);
            var result = helper1.getNeeded();
            Assert.Equal(4, result);

        }
    }
}
