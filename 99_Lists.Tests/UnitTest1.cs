namespace _99_Lists.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.NotNull(Languages.NewList());
            Assert.Empty(Languages.NewList());
            
        }

        [Fact]
        public void Test2()
        {
            var result = Languages.GetExistingLanguages();
            Assert.Equal(new List<string>(){"C#", "Clojure", "Elm"}, result);
            
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(new List<string>(){"C#", "Clojure", "Elm", "VBA"},
                Languages.AddLanguage(Languages.GetExistingLanguages(), "VBA"));
        }

        [Fact]
        public void Test4()
        {
            Assert.Equal(3, Languages.CountLanguages(Languages.GetExistingLanguages()));
        }

        [Fact]
        public void Test5()
        {
            Assert.True(Languages.HasLanguage(Languages.GetExistingLanguages(), "Elm"));
        }

        [Fact]
        public void Test6()
        {
            Assert.Equal(new List<string>(){"Elm", "Clojure", "C#"},
                    Languages.ReverseList(Languages.GetExistingLanguages()));
        }

        [Fact]
        public void Test7()
        {
            Assert.True(Languages.IsExciting(Languages.GetExistingLanguages()));
        }

        [Fact]
        public void Test8()
        {
            Assert.Equal(new List<string>(){ "C#", "Elm" }, 
                Languages.RemoveLanguage(Languages.GetExistingLanguages(), "Clojure"));
        }

        [Fact]
        public void Test9()
        {
            Assert.True(Languages.IsUnique(Languages.GetExistingLanguages()));
        }
    }
}