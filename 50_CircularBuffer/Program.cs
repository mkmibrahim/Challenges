namespace _50_CircularBuffer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class CircularBuffer<T>
    {
        private T[] _buffer;
        int _start = 0, _end = 0;
        

        public CircularBuffer(int capacity)
        {
            _buffer = new T[capacity];
        }

        public T Read()
        {
            if (isBufferEmpty)
                throw new InvalidOperationException();
            return _buffer[Wrap(_end++)];
        }

        public void Write(T value)
        {
            if (isBufferFull)
                throw new InvalidOperationException(); 

            _buffer[Wrap(_start++)] = value;
        }

        public void Overwrite(T value)
        {
            if (isBufferFull)
                _end++;

            Write(value);
        }

        public void Clear()
        {
            _end = _start;
        }

        private bool isBufferEmpty => _start == _end;

        private bool isBufferFull => _buffer.Length == Length;

        private int Length  => _start - _end;

        private int Wrap(int v) => v % _buffer.Length;
        


        //private T[] _buffer = null;
        //private int _readLocation;
        //private int _writeLocation;
        //private int _contentSize;

        //public CircularBuffer(int capacity)
        //{
        //    _buffer = new T[capacity];
        //    _readLocation = 0;
        //    _writeLocation = 0;
        //    _contentSize = 0;
        //}

        //public T Read()
        //{
        //    if (_contentSize == 0 )
        //        throw new InvalidOperationException();
        //    else 
        //        { 
        //            _contentSize--;
        //            if (_readLocation >= _buffer.Length)    
        //                _readLocation = 0;
        //            return _buffer[_readLocation++];
        //        }
        //}

        //public void Write(T value)
        //{
        //    if (_contentSize == _buffer.Length)
        //        throw new InvalidOperationException();

        //    if (_writeLocation < _buffer.Length)
        //    { 

        //        _buffer[_writeLocation++] = value;
        //        _contentSize++;
        //    }
        //    else
        //    {
        //        _writeLocation = 0;
        //        _buffer[_writeLocation++] = value;
        //        _contentSize++;
        //    }
        //}

        //public void Overwrite(T value)
        //{
        //    if (_writeLocation < _buffer.Length)
        //    { 
        //        _buffer[_writeLocation++] = value;
        //    }
        //    else
        //    {
        //        _writeLocation = 0;
        //        _buffer[_writeLocation++] = value;
        //    }
        //    if ( _contentSize < _buffer.Length )
        //        _contentSize++;
        //    else
        //        _readLocation++;
        //}

        //public void Clear()
        //{
        //    _buffer = new T[_buffer.Length];
        //    _readLocation = 0;
        //    _writeLocation = 0;
        //    _contentSize = 0;
        //}
    }
}