namespace _38_SpaceAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class SpaceAge
    {
        private int _seconds;
        private const double _mercuryToEarthYears = 0.2408467;
        private const double _secondsInEarthYear = 31557600;
        private const double _venusToEarthYears = 0.61519726;
        private const double _marsToEarthYears = 1.8808158;
        private const double _jupiterToEarthYears = 11.862615;
        private const double _saturnToEarthYears = 29.447498;
        private const double _uranusToEarthYears = 84.016846;
        private const double _neptuneToEarthYears = 164.79132;

        public SpaceAge(int seconds)
        {
            _seconds = seconds;
        }

        public double OnEarth() => (double)_seconds / _secondsInEarthYear;

        public double OnMercury() => (double) OnEarth() / _mercuryToEarthYears;

        public double OnVenus() => (double) OnEarth() / _venusToEarthYears;

        public double OnMars() => (double) OnEarth() / _marsToEarthYears;

        public double OnJupiter() => OnEarth() / _jupiterToEarthYears;

        public double OnSaturn() => OnEarth() / _saturnToEarthYears;

        public double OnUranus() => OnEarth() / _uranusToEarthYears;
        

        public double OnNeptune() => OnEarth() / _neptuneToEarthYears;
        
    }
}