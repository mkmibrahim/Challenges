using System;
using Xunit;

namespace Array_03.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var arrayInstance = new ArrayClass();
            Assert.NotNull(arrayInstance);
        }

        [Fact]
        public void SetValueTest()
        {
            var arrayInstance = new ArrayClass();
            
            arrayInstance.SetValue(1, 10);

            Assert.Equal(10, arrayInstance.GetValue(1));
        }

        [Fact]
        public void GetLargestValueTest()
        {
            var arrayInstance = new ArrayClass();

            for(int i = 0; i < 10; i++)
                arrayInstance.SetValue(i, i+10);

            var largestValue = arrayInstance.GetLargestValue();

            Assert.Equal(19, largestValue);
        }
    }
}
