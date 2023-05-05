using System;

namespace _14_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }



    public class WeighingMachine
    {
        private int _precision;
        private double _weight;
        private double _tareAdjustment = 5.0;

        public WeighingMachine(int precision)
        {
            _precision = precision;
        }

        public int Precision => _precision;

        public double Weight 
        {
            get => _weight; 
            set 
            {
                if (value >= 0 )
                    _weight = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        public double TareAdjustment
        {
            get => _tareAdjustment;
            set => _tareAdjustment = value;
        }

        public string DisplayWeight
        {
            get
            {
                var result = _weight - _tareAdjustment;
                result = Math.Round(result, _precision);
                var stringResult = string.Format($"{{0:f{_precision}}}", result);
                return stringResult + " kg";
            }   
        }
    

    }

}