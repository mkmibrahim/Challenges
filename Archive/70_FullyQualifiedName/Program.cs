using System;
using System.Reflection;

namespace _70_FullyQualifiedName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Module[] moduleArray;

            moduleArray = typeof(Program).Assembly.GetModules(false);

            Module myModule = moduleArray[0];

            Console.WriteLine("myModule.FullyQualifiedName = {0}", myModule.FullyQualifiedName);
            
        }
    }
}
