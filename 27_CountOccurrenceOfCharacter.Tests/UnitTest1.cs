using System;
using Xunit;

namespace _27_CountOccurrenceOfCharacter.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result = OccurenceHelper.Count("This is count occurrence program", 'c');
            Assert.Equal(4, result);
        }
    }
}
