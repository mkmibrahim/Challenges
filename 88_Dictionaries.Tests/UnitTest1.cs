namespace _88_Dictionaries.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestEmptyDictionary()
        {
            var result = DialingCodes.GetEmptyDictionary();
            Assert.NotNull(result);
            Assert.Empty(result);
        }

        [Fact]
        public void TestExistingDictionary()
        {
            var result = DialingCodes.GetExistingDictionary();
            Assert.NotNull(result);
            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void AddCountryTest()
        {
            var result = DialingCodes.AddCountryToEmptyDictionary(44, "United Kingdom");
            Assert.Single(result);
        }

        [Fact]
        public void AddCountryToExisting()
        {
            var result = DialingCodes.AddCountryToExistingDictionary(DialingCodes.GetExistingDictionary(),
                            44, "United Kingdom");
            Assert.Equal(4, result.Count);
            // => 1 => "United States of America", 44 => "United Kingdom", 55 => "Brazil", 91 => "India"
        }

        [Fact]
        public void GetCountryNameTest()
        {
            var result = DialingCodes.GetCountryNameFromDictionary(DialingCodes.GetExistingDictionary(), 55);
            Assert.Equal("Brazil", result);

            result = DialingCodes.GetCountryNameFromDictionary(DialingCodes.GetExistingDictionary(), 999);
            Assert.Empty(result);
        }

        [Fact]
        public void CountryExistTest()
        {
            Assert.True(DialingCodes.CheckCodeExists(DialingCodes.GetExistingDictionary(), 55));
        }

        [Fact]
        public void UpdateCountryNameTest()
        {
            var result = DialingCodes.UpdateDictionary(DialingCodes.GetExistingDictionary(), 1, "Les États-Unis");
            Assert.Equal("Les États-Unis", result[1]);

            result = DialingCodes.UpdateDictionary(DialingCodes.GetExistingDictionary(), 999, "Newlands");
            Assert.Equal("United States of America", result[1]);
            Assert.Equal("Brazil", result[55]);
        }

        [Fact]
        public void RemoveCountryTest()
        {
            var result =  DialingCodes.RemoveCountryFromDictionary(DialingCodes.GetExistingDictionary(), 91);
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void LongestNameTest()
        {
            var result = DialingCodes.FindLongestCountryName(DialingCodes.GetExistingDictionary());
            Assert.Equal("United States of America", result);
        }

        [Fact]
        public void test()
        {
            var countryCodes = DialingCodes.UpdateDictionary(DialingCodes.GetExistingDictionary(), 999, "Newlands");
            Assert.Equal(3, countryCodes.Count);
        }
    }
}