using System;
using Xunit;

namespace Array_01.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CreatearrayWithRandomNumbersTest()
        {
            var array = new ArrayInstance(10, 50);
            Assert.Equal(10, array.ArrayContents.Length);
            foreach (var item in array.ArrayContents)
            {
                Assert.True(item < 50);

            }
        }

        [Fact]
        public void CreatearrayWithSpecificNumbersTest()
        {
            var fixedArrayContents = new int[10]
            {
                1, 2, 3, 4, 5, 6, 7, 7, 9, 14
            };
            var array = new ArrayInstance(fixedArrayContents);
            Assert.Equal(10, array.ArrayContents.Length);
            foreach (var item in array.ArrayContents)
            {
                Assert.True(item < 50);
            }
        }

        [Fact]
        public void CheckOccurencesTest()
        {
            var fixedArrayContents = new int[10]
            {
                1, 2, 3, 4, 5, 6, 7, 7, 9, 14
            };

            var array = new ArrayInstance(fixedArrayContents);
            var result = array.CheckOccurences(7);
            Assert.Equal(2, result);
        }


    }
}
