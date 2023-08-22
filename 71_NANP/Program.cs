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
            if (phoneNumber.Length < 10)
                throw new ArgumentException();
            var number = phoneNumber.Replace(".", "")
                        .Replace(" ","")
                        .Replace("(","")
                        .Replace(")","")
                        .Replace("-","");
            if (!checkOnlydigits(number))
                throw new ArgumentException();
            number = RemoveCountryCode(number);
            var areaCode = GetAreaCode(number);
            var localNumber = GetLocalNumber(number);

            var result = areaCode + localNumber;
            return result;
        }

        private static bool checkOnlydigits(string number)
        {
            var result = true;
            foreach (var item in number)
            {
                if (!char.IsDigit(item))
                    result = false;
            }
            return result;
        }

        private static string GetLocalNumber(string number)
        {
            if (number.Contains(")"))
            {
                number = number.Replace("-", "");
               return number.Substring(6);
            }
            else
                return number.Substring(3);
        }

        private static object GetAreaCode(string number)
        {
            if (number[0]== '(')
                return number.Substring(1, 3);
            if (number.Length == 10)
                return number.Substring(0, 3);
            else
                return number.Substring(1, 3);
        }

        private static string RemoveCountryCode(string phoneNumber)
        {
            if (phoneNumber[0] == '+')
                phoneNumber = phoneNumber.Substring(1);
            if (phoneNumber.Length > 10 && phoneNumber[0] != '1')
                throw new ArgumentException();
            if (phoneNumber[0] == '1')
                return phoneNumber.Substring(1);
            if (phoneNumber.Substring(0, 2) == "+1")
                return phoneNumber.Substring(2);
            else
                return phoneNumber;
        }
    }
}