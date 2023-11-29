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

        public double Real() => _real;

        public double Imaginary() => _imaginary;

        public ComplexNumber Mul(ComplexNumber other)
        {
            // (a + i * b) * (c + i * d) = (a * c - b * d) + (b * c + a * d) * i
            var result = new ComplexNumber();
            result._real = _real * other._real - _imaginary * other._imaginary;
            result._imaginary = _imaginary * other._real + _real * other._imaginary;
            return result;
        }

        public ComplexNumber Mul(double other)
        {
            // (a + i * b) * c = (a * c) + (b * c) * i
            var result = new ComplexNumber();
            result._real = _real * other;
            result._imaginary = _imaginary * other;
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

        public ComplexNumber Add(double other)
        {
            // (a + i * b) + c = (a + c) + b * i
            var result = new ComplexNumber();
            result._real = _real + other;
            result._imaginary = _imaginary;
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

        public ComplexNumber Sub(double other)
        {
            // (a + i * b) - c = (a - c) + b * i
            var result = new ComplexNumber();
            result._real = _real - other;
            result._imaginary = _imaginary;
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

        public ComplexNumber Div(double other)
        {
            // (a + i * b) / c = (a / c) + (b / c) * i
            var result = new ComplexNumber();
            result._real = _real / other;
            result._imaginary = _imaginary / other;
            return result;
        }

        public double Abs()
        {
            var result = Math.Sqrt(_real * _real + _imaginary * _imaginary);
            return result;
        }

        public ComplexNumber Conjugate()
        {
            var result = new ComplexNumber
            {
                _real = _real,
                _imaginary = -_imaginary
            };
            return result;
        }

        public ComplexNumber Exp()
        {
            // e^(a + i * b) = e^a * e^(i * b) = e^a * (cos(b) + i * sin(b))
            var result = new ComplexNumber();
            result._real = Math.Exp(_real) * Math.Cos(_imaginary);
            result._imaginary = Math.Exp(_real) * Math.Sin(_imaginary);
            return result;
        }
    }
}
