namespace _59_VLQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public static class VariableLengthQuantity
    {
        public static uint[] Encode(uint[] numbers)
        {
            var outputList = new List<uint>();
            var outputOfNumber = new List<uint>();
            for (int i = 0; i < numbers.Length; i++)
            {
                uint currentNumber = numbers[i];
                bool endOfNumber = false;
                int indexWithinNumber = 1;
                while (!endOfNumber)
                {
                    uint lower7bits = currentNumber & 127;
                    currentNumber >>= 7;
                    if (currentNumber == 0)
                    {
                        endOfNumber = true;
                    }
                    if(indexWithinNumber != 1)
                    {
                        lower7bits |= 128;
                    }
                    outputOfNumber.Add(lower7bits);
                    indexWithinNumber++;
                }
                outputOfNumber.Reverse();
                outputList.AddRange(outputOfNumber);
                outputOfNumber.Clear();
            }
            return outputList.ToArray();
        }
        public static uint[] Decode(uint[] bytes)
        {
            var outputList = new List<uint>();
            uint value = 0;
            for(int i = 0; i < bytes.Length; i++)
            {
                uint currentByte = bytes[i];            
                value <<= 7;
                value |= currentByte & 127;
                if ((currentByte & 128) == 0)
                {
                    outputList.Add(value);
                    value = 0;
                }
                else if (i == bytes.Length - 1 && (currentByte & 128) != 0)
                    throw new InvalidOperationException();
            }
            return outputList.ToArray();
        }
    }
}