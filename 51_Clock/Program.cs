namespace _51_Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Clock
    {
        private int _hours;
        private int _minutes;

        public Clock(int hours, int minutes)
        {
            NormalizeTime(ref hours, ref minutes);
            _hours = hours;
            _minutes = minutes;
        }

        public Clock Add(int minutesToAdd)
        {
            return new Clock(_hours, _minutes + minutesToAdd);
        }

        public Clock Subtract(int minutesToSubtract)
        {
            return new Clock (_hours, _minutes - minutesToSubtract);
        }

        public override string ToString()
        {
            string hoursString = _hours < 10 ? ("0" + _hours) : _hours.ToString();
            string minutesString = _minutes < 10 ? ("0" + _minutes) : _minutes.ToString();

            return hoursString + ":" + minutesString;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Clock otherClock)
            {
                return _hours == otherClock._hours & _minutes == otherClock._minutes;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_hours, _minutes);
        }

        private void NormalizeTime(ref int hours, ref int minutes)
        {
            int minutesTotal = hours * 60 + minutes;
            int minutesNormalized = (minutesTotal % 1440 + 1440) % 1440;
            hours = minutesNormalized / 60;
            minutes = minutesNormalized % 60;
        }
    }
}