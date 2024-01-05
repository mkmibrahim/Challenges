using System.Text;

namespace _98_RomanNumerals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class RomanNumeralExtension
    {
        //        public static string ToRoman(this int value)
        //        {
        //            var result = "";
        //            var remainingNumber = value;
        //            while (remainingNumber > 0)
        //            {
        //                switch (remainingNumber)
        //                {
        //                    case 1:
        //                    case 2:
        //                    case 3:
        //                        for (int i = 0; i < remainingNumber; i++)
        //                        {
        //                            result += "I";
        //                            remainingNumber--;
        //                        }
        //                        break;
        //                    case 4:
        //                        result += "IV";
        //                        remainingNumber -= 4;
        //                        break;
        //                    case 5:
        //                        result += "V";
        //                        remainingNumber -= 5;
        //                        break;
        //                    case 6:
        //                        result += "VI";
        //                        remainingNumber -= 6;
        //                        break;
        //                    case 7:
        //                        result += "VII";
        //                        remainingNumber -= 7;
        //                        break;
        //                    case 8:
        //                        result += "VIII";
        //                        remainingNumber -= 8;
        //                        break;
        //                    case 9:
        //                        result += "IX";
        //                        remainingNumber -= 9;
        //                        break;
        //                    case int when remainingNumber is >= 10 and < 40:
        //                        result += "X";
        //                        remainingNumber -= 10;
        //                        break;
        //                    case int when remainingNumber is >= 40 and < 50:
        //                        result += "XL";
        //                        remainingNumber -= 40;
        //                        break;
        //                    case int when remainingNumber is >= 50 and < 90:
        //                        result += "L";
        //                        remainingNumber -= 50;
        //                        break;
        //                    case int when remainingNumber is >= 90 and < 100:
        //                        result += "XC";
        //                        remainingNumber -= 90;
        //                        break;
        //                    case int when remainingNumber is >= 100 and < 400:
        //                        result += "C";
        //                        remainingNumber -= 100;
        //                        break;
        //                    case int when remainingNumber is >= 400 and < 500:
        //                        result += "CD";
        //                        remainingNumber -= 400;
        //                        break;
        //                    case int when remainingNumber is >= 500 and < 900:
        //                        result += "D";
        //                        remainingNumber -= 500;
        //                        break;
        //                    case int when remainingNumber is >= 900 and < 1000:
        //                        result += "CM";
        //                        remainingNumber -= 900;
        //                        break;
        //                    case int when remainingNumber is >= 1000:
        //                        result += "M";
        //                        remainingNumber -= 1000;
        //                        break;
        //;                    default:
        //                        remainingNumber = 0;
        //                        break;
        //                }
        //            }
        //            return result;
        //        }

        private static readonly Dictionary<int, string> NumeralThresholds = new()
    {
        { 1000, "M"  },
        { 900,  "CM" },
        { 500,  "D"  },
        { 400,  "CD" },
        { 100,  "C"  },
        { 90,   "XC" },
        { 50,   "L"  },
        { 40,   "XL" },
        { 10,   "X"  },
        { 9,    "IX" },
        { 5,    "V"  },
        { 4,    "IV" },
        { 1,    "I"  },
    };

        public static string ToRoman(this int value)
        {
            var remainder = value;
            var output = new StringBuilder();
            foreach (var (threshold, numeral) in NumeralThresholds)
            {
                while (remainder / threshold > 0)
                {
                    remainder -= threshold;
                    output.Append(numeral);
                }
            }
            return output.ToString();
        }
    }
}
