﻿using System;
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
            if (!languages.Contains(language))
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

        public static bool IsExciting(List<string> languages) =>
            languages.FirstOrDefault() == "C#" || 
            ( languages.Count > 0 && languages.Count <= 3 && languages[1] == "C#");
 
        public static List<string> RemoveLanguage(List<string> languages, string language)
        {
            languages.Remove(language);
            return languages;
        }

        public static bool IsUnique(List<string> languages) => 
            languages.Count == languages.Distinct().Count();
     }

}
