namespace _78_Lasagna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var lasagna = new Lasagna();
            lasagna.ExpectedMinutesInOven();

            lasagna.RemainingMinutesInOven(30);

            lasagna.PreparationTimeInMinutes(2);

            
            lasagna.ElapsedTimeInMinutes(3, 20);
        }
    }

    internal class Lasagna
    {
        internal int ExpectedMinutesInOven()
        {
            return 40;
        }

        internal int RemainingMinutesInOven(int v)
        {
            return ExpectedMinutesInOven() - v;
        }

        internal int PreparationTimeInMinutes(int v)
        {
            return v *2;
        }

        internal int ElapsedTimeInMinutes(int numberOfLayers, int numberOfMinutesInOven)
        {
            return PreparationTimeInMinutes(numberOfLayers) * numberOfLayers + numberOfMinutesInOven;
        }
    }
}