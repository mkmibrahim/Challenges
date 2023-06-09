namespace _27_Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class PhoneNumber
    {
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {
            var _phoneNumberSeparator = "-";
            
            var phoneNumberParts = phoneNumber.Split(_phoneNumberSeparator);
            var isNewYork = phoneNumberParts[0].Equals("212");
            var isFake = phoneNumberParts[1].Equals("555");
            var localNumber = phoneNumberParts[2];
            var result = (IsNewYork: isNewYork, IsFake: isFake, LocalNumber: localNumber);
            return result ;

        }

        public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
    }
}