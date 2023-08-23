namespace _71_NANP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class PhoneNumber
    {
        public static string Clean(string phoneNumber)
        {
            const int MinimumPhoneNumberLength = 10;

            if (phoneNumber.Length < MinimumPhoneNumberLength)
                throw new ArgumentException();

            string cleanedNumber = RemoveNonDigitSymbols(phoneNumber);
            cleanedNumber = RemoveCountryCode(cleanedNumber);

            if (cleanedNumber.Length < 10)
                throw new ArgumentException();
            
            if (cleanedNumber.Length > 10)
                throw new ArgumentException();
            
            var areaCode = GetAreaCode(cleanedNumber);
            var localNumber = GetLocalNumber(cleanedNumber);

            return areaCode + localNumber;
        }

        private static string RemoveNonDigitSymbols(string phoneNumber) =>
            new string(phoneNumber.Where(char.IsDigit).ToArray());

        private static string RemoveCountryCode(string phoneNumber)
        {
            if (phoneNumber[0] == '+' || phoneNumber[0] == '1')
                phoneNumber = phoneNumber.Substring(1);

            if (phoneNumber.Substring(0, 2) == "+1")
                return phoneNumber.Substring(2);
            else
                return phoneNumber;
        }

        private static string GetLocalNumber(string number)
        {
            var result = "";
            if (number.Contains(")"))
            {
               number = number.Replace("-", "");
               result = number.Substring(6);
            }
            else
                result = number.Substring(3);
            if (result[0] == '0' || result[0] == '1')
                throw new ArgumentException();
            return result;
        }

        private static object GetAreaCode(string number)
        {
            var result = "";
            if (number.Length == 10)
                result =  number.Substring(0, 3);
            else
                result = number.Substring(1, 3);
            if (result[0] == '0' || result[0] == '1')
                throw new ArgumentException();
            return result;
        }

       
    }
}