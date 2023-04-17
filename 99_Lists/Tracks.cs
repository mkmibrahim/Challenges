using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _99_Lists
{
     public static class Languages
    {
        public static List<string> NewList() => new List<string>();

        public static List<string> GetExistingLanguages() => new List<string>() { "C#", "Clojure", "Elm"};

        public static List<string> AddLanguage(List<string> languages, string language)
        {
            languages.Add(language);
            return languages;
        }

        public static int CountLanguages(List<string> languages) => languages.Count;

        public static bool HasLanguage(List<string> languages, string language) => languages.Contains(language);

        public static List<string> ReverseList(List<string> languages)
        {
            languages.Reverse();
            return languages;
        }

        public static bool IsExciting(List<string> languages)
        {
            var result = false;
            if (languages.FirstOrDefault() == "C#")
                result = true;
            else if (languages.Count > 0 && languages.Count <= 3 && languages[1] == "C#" )
                result = true;
            return result;
        }

        public static List<string> RemoveLanguage(List<string> languages, string language)
        {
            languages.Remove(language);
            return languages;
        }

        public static bool IsUnique(List<string> languages)
        {
            var otherList = new List<string>();
            var result = true;
            for (int i = 0; i < languages.Count; i++)
            {
                if (otherList.Contains(languages[i]))
                    result = false;
                else
                    otherList.Add(languages[i]);
            }
            return result;
        }
    }

}
