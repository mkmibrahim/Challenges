using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _94_Loops
{
    public static class SavingsAccount
    {
        public static float InterestRate(decimal balance) =>
            balance switch
            {
                < 0 => 3.213f,
                < 1000 => 0.5f,
                < 5000 => 1.621f,
                _ => 2.475f
            };

        public static decimal Interest(decimal balance)
        {
            return balance * Convert.ToDecimal(InterestRate(balance)) / 100;
        }

        public static decimal AnnualBalanceUpdate(decimal balance)
        {
            return balance + Interest(balance);
        }

        public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
        {
            var x = 0;
            while (balance < targetBalance)
            {
                x++;
                balance = AnnualBalanceUpdate(balance);
                Console.WriteLine("Debug message");
            }
            return x;
        }
    }
}
