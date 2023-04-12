using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _97_Numbers
{
    internal class Telemetry
    {
    }

    
    public static class TelemetryBuffer
    {
        public static byte[] ToBuffer(long reading)
        {
            var result = new List<byte>();
            int numberOfBits;
            if (reading >= long.MinValue && reading < int.MinValue)
                numberOfBits = 248;
            else if (reading >= int.MinValue && reading < short.MinValue)
            {
                numberOfBits = 252;
                reading = Convert.ToInt32(reading);

                result.Add((byte)numberOfBits);
                result.AddRange(BitConverter.GetBytes((int)reading));

                result.AddRange(new byte[4] { 0, 0, 0, 0 });
                return result.ToArray<byte>();
            }
            else if (reading <= -1) // ushort
            {
                numberOfBits = 254;
                reading = (ushort)reading;
            }
            else if (reading <= ushort.MaxValue)
                numberOfBits = 2;
            else if (reading <= int.MaxValue)
                numberOfBits = 252; //256-4
            else if (reading <= uint.MaxValue)
                numberOfBits = 4;
            else if (reading <= long.MaxValue)
                numberOfBits = 256 - 8;
            else
                numberOfBits = 4;

            result.Add((byte)numberOfBits);
            result.AddRange( BitConverter.GetBytes(reading));

            return result.ToArray<byte>();
        }

        public static long FromBuffer(byte[] buffer)
        {
            long result;
            var bufferList = buffer.ToList();
            var first = (int)bufferList.FirstOrDefault();
            bufferList.RemoveAt(0);
            if (first == 254)
                result = BitConverter.ToInt16(bufferList.ToArray<byte>());
            else if (first == 248)
                result = BitConverter.ToInt64(bufferList.ToArray<byte>());
            else if (first == 252)
                result = BitConverter.ToInt32(bufferList.ToArray<byte>());
            else if (first == 4)
                result = BitConverter.ToUInt32(bufferList.ToArray<byte>());
            else if (first == 2)
                result = BitConverter.ToUInt16(bufferList.ToArray<byte>());
            else
                result = 0;
            return result;
        }
    }

}
