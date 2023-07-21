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
            //return numbers;
            var result = new List<uint>();
            foreach (uint number in numbers) {
                var value = (uint)number;
                do
                    {
                        byte lower7bits = (byte)(value & 0x7f);
                        value >>= 7;
                        if (value > 0)
                            lower7bits |= 129;
                        result.Add(lower7bits);
                    } while (value > 0);
            }
            return result.ToArray();
        }

        public static uint[] Decode(uint[] bytes)
        {
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}