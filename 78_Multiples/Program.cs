namespace _78_Multiples
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class SumOfMultiples
    {
        public static int Sum(IEnumerable<int> multiples, int max)
        {
            //int result;
            //var multiplesList = new List<int>();
            //foreach (var multiple in multiples)
            //{
            //    for(int i = 0; i < max; i++)
            //    {
            //        if (multiple > 0 &&
            //            i % multiple == 0 &&
            //            !multiplesList.Contains(i))
            //            multiplesList.Add(i);
            //    }
            //}
            //result = multiplesList.Sum();
            //return result;

            var result = Enumerable
                                    .Range(0, max)
                                    .Where(i => multiples.Any(m => m > 0 && i % m == 0))
                                    .Distinct()
                                    .Sum(); 
            return result;
        }
    }
}