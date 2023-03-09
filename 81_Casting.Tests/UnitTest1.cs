namespace _81_Casting.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.True(true);
        }

        [Fact]
        public void GetDisplayName_Staff()
        {
            var spm = new SecurityPassMaker();
            Assert.Equal("Too Important for a Security Pass", spm.GetDisplayName(new Manager()));
            // => "Too Important for a Security Pass"
            Assert.Equal("The Physio", spm.GetDisplayName(new Physio()));
        }

        [Fact]
        public void GetDisplayName_Security()
        {
            var spm = new SecurityPassMaker();
            Assert.Equal("The Physio", spm.GetDisplayName(new Physio()));
            
            var spm2 = new SecurityPassMaker();
            Assert.Equal("Security Team Member Priority Personnel", spm2.GetDisplayName(new Security()));
            
            //Assert.Equal("Security Junior Priority Personnel", spm2.GetDisplayName(new SecurityJunior()));
        }

        [Fact]
        public void GetDisplayName_Junior()
        {
            var spm2 = new SecurityPassMaker();
            Assert.Equal("Security Team Member Priority Personnel", spm2.GetDisplayName(new Security()));
            
            Assert.Equal("Security Junior", spm2.GetDisplayName(new SecurityJunior()));
            
        }
    }
}