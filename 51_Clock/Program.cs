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
            _hours = (hours + minutes / 60) % 24;
            _hours = _hours < 0 ? _hours + 24 : _hours;
            _minutes = minutes % 60;
            while (_minutes < 0)
            {
                _minutes += 60;
                _hours = _hours > 0 ? --_hours : 23;
            }
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
    }
}