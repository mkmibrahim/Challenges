using System;
using System.Reflection.Metadata.Ecma335;

namespace _07_Nullability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }

    public static class Badge
    {
        public static string Print(int? id, string name, string? department)
        {
            department = (department ?? "owner").ToUpper();
            return id.HasValue switch
            {
                true => $"[{id}] - {name} - {department}",
                false => $"{name} - {department}",
            };
        }
    }
}
