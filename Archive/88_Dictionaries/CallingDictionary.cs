using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly:InternalsVisibleTo("88_Dictionaries.Tests")]

namespace _88_Dictionaries
{
    internal class CallingDictionary
    {

    }

    public static class DialingCodes
    {
        public static Dictionary<int, string> GetEmptyDictionary()
        {
            var result = new Dictionary<int, string>();
            return result;
        }

        public static Dictionary<int, string> GetExistingDictionary()
        {
            var result = new Dictionary<int, string>{
                {1, "United States of America" },
                {55, "Brazil" },
                {91, "India" } 
            };
            return result;
        }

        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            var result = new Dictionary<int, string>();
            result.Add(countryCode, countryName);
            return result;
        }

        public static Dictionary<int, string> AddCountryToExistingDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            existingDictionary.Add(countryCode, countryName);
            return existingDictionary;

        }

        public static string GetCountryNameFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            if (existingDictionary.ContainsKey(countryCode))
                return existingDictionary[countryCode];
            else 
                return string.Empty;
        }

        public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
        {
            var result = existingDictionary.ContainsKey(countryCode);
            return result;
        }

        public static Dictionary<int, string> UpdateDictionary(
            Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            var dictionary = existingDictionary;
            if (dictionary.ContainsKey(countryCode))
                dictionary[countryCode] = countryName;
            return dictionary;
        }

        public static Dictionary<int, string> RemoveCountryFromDictionary(
            Dictionary<int, string> existingDictionary, int countryCode)
        {
            var dictionary = existingDictionary;
            existingDictionary.Remove(countryCode);
            return dictionary;
        }

        public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
        {
            var longestName = string.Empty;
            foreach (var countryName in existingDictionary.Values)
            {
                if (countryName.Length > longestName.Length)
                    longestName = countryName;
            }
            return longestName;
        }
    }
}
