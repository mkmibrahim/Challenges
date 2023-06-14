namespace _33_TweFor.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void No_name_given()
            {
                Assert.Equal("One for you, one for me.", TwoFer.Speak());
            }

        [Fact]
        public void A_name_given()
            {
                Assert.Equal("One for Alice, one for me.", TwoFer.Speak("Alice"));
            }

        [Fact]
        public void Another_name_given()
            {
                Assert.Equal("One for Bob, one for me.", TwoFer.Speak("Bob"));
            }
    }
}