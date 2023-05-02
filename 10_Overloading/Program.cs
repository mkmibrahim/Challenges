namespace _10_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

    }

    public struct CurrencyAmount
    {
        private const string MessageDifferentCurrency = "not same currency";
        private decimal amount;
        private string currency;

        public CurrencyAmount(decimal amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public static bool operator ==(CurrencyAmount a, CurrencyAmount b)
        {
            if (a.currency == b.currency)
                return a.amount == b.amount;
            else
                throw new ArgumentException(MessageDifferentCurrency);
        } 
             
        
        public static bool operator != (CurrencyAmount a, CurrencyAmount b) =>
            !(a == b);

        public static bool operator >(CurrencyAmount a, CurrencyAmount b)
        {
            if (a.currency == b.currency)
                return a.amount > b.amount;
            else
                throw new ArgumentException(MessageDifferentCurrency);
        }

        public static bool operator <(CurrencyAmount a, CurrencyAmount b) =>
            !(a > b);

        public static CurrencyAmount operator +(CurrencyAmount a, CurrencyAmount b)
        {
            if (a.currency == b.currency)
                return new CurrencyAmount(a.amount + b.amount, a.currency);
            else
                throw new ArgumentException(MessageDifferentCurrency);
        }

        public static CurrencyAmount operator -(CurrencyAmount a, CurrencyAmount b)
        {
            if (a.currency == b.currency)
                return new CurrencyAmount(a.amount - b.amount, a.currency);
            else
                throw new ArgumentException(MessageDifferentCurrency);
        }


        public static CurrencyAmount operator *(CurrencyAmount a, decimal b) => 
            new CurrencyAmount(a.amount * b, a.currency);
        
        public static CurrencyAmount operator /(CurrencyAmount a, decimal b) => 
            new CurrencyAmount(a.amount / b, a.currency);

        public static implicit operator double(CurrencyAmount v) => (double)v.amount;

        public static implicit operator decimal(CurrencyAmount v) => (decimal)v.amount;
    }

}