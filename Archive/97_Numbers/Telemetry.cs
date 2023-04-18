namespace _97_Numbers
{
    enum ValueType
    {
        uShortType = 2,
        uIntType = 4,
        longType = 248,
        intType = 252,
        shortType = 254,
    }

    public static class TelemetryBuffer
    {
        public static byte[] ToBuffer(long reading)
        {
            var result = new List<byte>();
            ValueType readingType = GetReadingType(reading);
            int prefixNumber = (int) readingType;
            result.Add((byte)prefixNumber);

            byte[] payloadBytes = GetReadingBytes(reading, readingType);
            result.AddRange(payloadBytes);
            while (result.Count < 9)
                result.Add(0x0);
            return result.ToArray<byte>();
        }

        private static byte[] GetReadingBytes(long reading, ValueType readingType)
        {
            if (readingType == ValueType.shortType)
                return BitConverter.GetBytes((short)reading);
            if (readingType == ValueType.intType)
                return BitConverter.GetBytes(Convert.ToInt32(reading));
            return BitConverter.GetBytes(reading);
        }

        private static ValueType GetReadingType(long reading)
        {
            if (reading >= long.MinValue && reading < int.MinValue)
                return ValueType.longType;
            if (reading >= int.MinValue && reading < short.MinValue)
                return ValueType.intType;
            if (reading  >= short.MinValue && reading <= -1 )
                return ValueType.shortType;
            if (reading >= 0 && reading <= ushort.MaxValue)
                return ValueType.uShortType;
            if (reading > ushort.MaxValue && reading <= int.MaxValue)
                return ValueType.intType;
            if (reading > int.MaxValue && reading <= uint.MaxValue)
                return ValueType.uIntType;
            else if (reading > uint.MaxValue && reading <= long.MaxValue)
                return ValueType.longType;
            else 
                throw new ArgumentException("Reading "+ reading +" can not be processed");
        }

        public static long FromBuffer(byte[] buffer)
        {
            long result;
            var payloadType = (ValueType)buffer[0];
            var bufferList = buffer.ToList();
            bufferList.RemoveAt(0);
            if (payloadType == ValueType.shortType)
                result = BitConverter.ToInt16(bufferList.ToArray<byte>());
            else if (payloadType == ValueType.longType)
                result = BitConverter.ToInt64(bufferList.ToArray<byte>());
            else if (payloadType == ValueType.intType)
                result = BitConverter.ToInt32(bufferList.ToArray<byte>());
            else if (payloadType == ValueType.uIntType)
                result = BitConverter.ToUInt32(bufferList.ToArray<byte>());
            else if (payloadType == ValueType.uShortType)
                result = BitConverter.ToUInt16(bufferList.ToArray<byte>());
            else
                result = 0;
            return result;
        }
    }

}
