namespace _91_ComplexNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public struct ComplexNumber
    {
        double _real;
        double _imaginary;

        public ComplexNumber(double real, double imaginary)
        {
            _real = real;
            _imaginary = imaginary;
        }

        public double Real()
        {
            return _real;
        }

        public double Imaginary()
        {
            return _imaginary;
        }

        public ComplexNumber Mul(ComplexNumber other)
        {
            // (a + i * b) * (c + i * d) = (a * c - b * d) + (b * c + a * d) * i
            var result = new ComplexNumber();
            result._real = _real * other._real - _imaginary * other._imaginary;
            result._imaginary = _imaginary * other._real + _real * other._imaginary;
            return result;
        }

        public ComplexNumber Add(ComplexNumber other)
        {
            //(a + i * b) + (c + i * d) = (a + c) + (b + d) * i
            var result = new ComplexNumber();
            result._real = _real + other._real;
            result._imaginary = _imaginary + other._imaginary;
            return result;
        }

        public ComplexNumber Sub(ComplexNumber other)
        {
            // (a + i * b) - (c + i * d) = (a - c) + (b - d) * i.
            var result = new ComplexNumber();
            result._real = _real - other._real;
            result._imaginary = _imaginary - other._imaginary;
            return result;
        }

        public ComplexNumber Div(ComplexNumber other)
        {
            // (a + i * b) / (c + i * d) = (a * c + b * d)/(c^2 + d^2) + (b * c - a * d)/(c^2 + d^2) * i
            var result = new ComplexNumber();
            result._real = (_real * other._real + _imaginary * other._imaginary) / 
                            (other._real * other._real + other._imaginary * other._imaginary);
            result._imaginary = (_imaginary * other._real - _real * other._imaginary) /
                            (other._real * other._real + other._imaginary * other._imaginary);
            return result;
        }

        public double Abs()
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        public ComplexNumber Conjugate()
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        public ComplexNumber Exp()
        {
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}
