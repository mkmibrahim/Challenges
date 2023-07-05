using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace _46_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    
    public class GradeSchool
    {
        private Dictionary<string, int> studentsInGrades = new Dictionary<string, int>();

        public bool Add(string student, int grade)
        {
            if (studentsInGrades.ContainsKey(student))
                return false;
            else
                return studentsInGrades.TryAdd(student, grade);
        }

        public IEnumerable<string> Roster()
        {
            var result = new List<string>();
            foreach (var item in studentsInGrades.Values.OrderBy(x => x).Distinct())
            {
                result.AddRange(from kvp in studentsInGrades
                                   where kvp.Value == item
                                   orderby kvp.Key
                                   select kvp.Key
                                   );
            }
            return result;
        }

        public IEnumerable<string> Grade(int grade)
        {
            var result = from kvp in studentsInGrades
                            .OrderBy(x => x.Value)
                            .OrderBy(x => x.Key)
                            where kvp.Value == grade
                            select kvp.Key;
            return result;
        }
    }
}