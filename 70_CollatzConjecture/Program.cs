using System.ComponentModel;

namespace _70_CollatzConjecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class CollatzConjecture
    {
        public static int Steps(int number)
        {
            if (number <= 0)
                throw new ArgumentOutOfRangeException();

            return Sequence(number).Count();
        }

        private static IEnumerable<int> Sequence(int number)
        {
            var current = number;

            while (current != 1)
            {
                if (current % 2 == 0)
                    current = current / 2;
                else
                    current = current * 3 + 1;
            }

            yield return current;
        }

        //public static int Steps(int number)
        //{
        //    if (number <= 0)
        //        throw new ArgumentOutOfRangeException();
        //    return Steps(number, 0);
        //}

        //private static int Steps(int number, int stepCount)
        //{
        //    if (number == 1)
        //        return stepCount;

        //    if (number % 2 == 0)
        //        return Steps(number / 2, stepCount + 1);
        //    else
        //        return Steps(number * 3 + 1, stepCount + 1);
        //}
        //public static int Steps(int number)
        //{
        //    if (number <= 0)
        //        throw new ArgumentOutOfRangeException();
        //    var result = 0;
        //    while(number > 1)
        //    {
        //        number = SingleConverter(number);
        //        result++;
        //    }
        //    return result;
        //}

        //private static int SingleConverter(int number)
        //{
        //    return number % 2 == 0 ? number /= 2 : number * 3 + 1;
        //}
    }
}