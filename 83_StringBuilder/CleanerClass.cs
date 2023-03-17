using System.Text;

using System.Runtime.CompilerServices;
using System.Globalization;

[assembly: InternalsVisibleTo("83_StringBuilderTests")]

namespace _83_StringBuilder
{
    internal class CleanerClass
    {
        internal static string Clean(string inputString)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == ' ')
                    result.Append('_');
                else if (char.IsControl( inputString[i]))
                    result.Append("CTRL");
                else if(inputString[i] == '-')
                {
                    result.Append(char.ToUpper(inputString[i+1]));
                    i++;
                }
                else if ((inputString[i] >= 'α') && (inputString[i] <= 'ω')) //Omit Greek lower case letters
                {
                }
                else if((char.GetUnicodeCategory(inputString[i]) == UnicodeCategory.UppercaseLetter) || 
                    (char.GetUnicodeCategory(inputString[i]) == UnicodeCategory.LowercaseLetter))
                {
                    result.Append(inputString[i]);
                }
            }
            return result.ToString();
        }
    }
}
