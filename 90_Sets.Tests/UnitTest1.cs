namespace _90_Sets.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Authenticator.AreSameFace(new FacialFeatures("green", 0.9m), new FacialFeatures("green", 0.9m)));
            
            Assert.False(Authenticator.AreSameFace(new FacialFeatures("blue", 0.9m), new FacialFeatures("green", 0.9m)));
            
        }

        [Fact]
        public void Test2()
        {
            var authenticator = new Authenticator();
            Assert.True(authenticator.IsAdmin(new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m))));
            
            Assert.False(authenticator.IsAdmin(new Identity("admin@thecompetition.com", new FacialFeatures("green", 0.9m))));
        }

        [Fact]
        public void Test3()
        {
            var authenticator = new Authenticator();
            Assert.True(authenticator.Register(new Identity("tunde@thecompetition.com", new FacialFeatures("blue", 0.9m))));
            
            Assert.True(authenticator.IsRegistered(new Identity("tunde@thecompetition.com", new FacialFeatures("blue", 0.9m))));
            
            Assert.False(authenticator.Register(new Identity("tunde@thecompetition.com", new FacialFeatures("blue", 0.9m))));
        }

        [Fact]
        public void Test4()
        {
            var authenticator = new Authenticator();
            Assert.False(authenticator.IsRegistered(new Identity("alice@thecompetition.com", new FacialFeatures("blue", 0.8m))));
        }

        [Fact]
        public void Test5()
        {
            var identityA = new Identity("alice@thecompetition.com", new FacialFeatures("blue", 0.9m));
            var identityB = identityA;
            Assert.True(Authenticator.AreSameObject(identityA, identityB));

            var identityC = new Identity("alice@thecompetition.com", new FacialFeatures("blue", 0.9m));
            var identityD = new Identity("alice@thecompetition.com", new FacialFeatures("blue", 0.9m));
            Assert.False(Authenticator.AreSameObject(identityC, identityD));
        }
    }
}