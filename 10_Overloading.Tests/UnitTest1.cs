namespace _10_Overloading.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            CurrencyAmount amountA = new CurrencyAmount(55, "HD");
            CurrencyAmount amountB = new CurrencyAmount(55, "HD");
            CurrencyAmount amountC = new CurrencyAmount(55, "USD");
            Assert.True(amountA == amountB);
            
            Assert.False(amountA != amountB);
            
            Assert.Throws<ArgumentException>(() => amountA == amountC);
            
            Assert.Throws<ArgumentException>(() => amountA != amountC);
        }

        [Fact]
        public void Test2()
        {
            CurrencyAmount amountA = new CurrencyAmount(55, "HD");
            Assert.True(amountA > new CurrencyAmount(50, "HD"));
            
            Assert.False(amountA < new CurrencyAmount(50, "HD"));
            
            Assert.Throws<ArgumentException>(() => amountA > new CurrencyAmount(50, "USD"));
        }

        [Fact]
        public void Test3()
        {
            CurrencyAmount amountA = new CurrencyAmount(55, "HD");
            CurrencyAmount amountB = new CurrencyAmount(100, "HD");
            CurrencyAmount amountC = new CurrencyAmount(55, "USD");
            Assert.Equal(new CurrencyAmount(155, "HD"), amountA + amountB);
            
            var result = amountA - amountB;
            Assert.Equal(new CurrencyAmount(45, "HD"), amountB - amountA);
            
            Assert.Throws<ArgumentException>(() => amountA + amountC);
        }

        [Fact]
        public void Test4()
        {
            CurrencyAmount amountA = new CurrencyAmount(10, "HD");
            Assert.Equal(new CurrencyAmount(20, "HD"), amountA * 2m);
            
            Assert.Equal(new CurrencyAmount(5, "HD"), amountA / 2m); //amountA / 2m
        }

        [Fact]
        public void Test5()
        {
            CurrencyAmount amountA = new CurrencyAmount(55.5m, "HD");
            Assert.Equal(55.5d,(double)amountA);

            decimal d = amountA;
            Assert.Equal(55.5m, d);
        }
    }
}