using System.Diagnostics;

namespace _94_Loops.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(0.5f, SavingsAccount.InterestRate(balance: 200.75m));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(1.00375m, SavingsAccount.Interest(balance: 200.75m));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(201.75375m, SavingsAccount.AnnualBalanceUpdate(balance: 200.75m));
        }

        [Fact]
        public void Test4()
        {
            Assert.Equal(14, SavingsAccount.YearsBeforeDesiredBalance(balance: 200.75m, targetBalance: 214.88m));
        }
    }
}