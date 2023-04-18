using System;
using Xunit;

namespace _21_NameSearch.Tests
{
    
    public class UnitTest1
    {
        static string[] names = { "harry", "michael", "will", "tom", "jackie" };
        static string[] surnames = { "potter", "jackson", "smith", "cruise", "chan" };
        
        [Fact]
        public void Test1()
        {
            var result = NameSearcher.GetFullName("harry", names, surnames);
            Assert.Equal("harry potter", result);
        }
    }
}
