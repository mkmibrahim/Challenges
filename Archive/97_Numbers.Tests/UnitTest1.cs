namespace _97_Numbers.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Type: ushort, bytes: 2, signed: no, prefix byte: 2
            Assert.Equal(new byte []{0x2, 0x5, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 }, TelemetryBuffer.ToBuffer(5));
            // => {0x2, 0x5, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };

            // Type: int, bytes: 4, signed: yes, prefix byte: 256 - 4
            Assert.Equal(new byte[]{0xfc, 0xff, 0xff, 0xff, 0x7f, 0x0, 0x0, 0x0, 0x0 }, TelemetryBuffer.ToBuffer(Int32.MaxValue));

        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(2147483647, TelemetryBuffer.FromBuffer(new byte[] {0xfc, 0xff, 0xff, 0xff, 0x7f, 0x0, 0x0, 0x0, 0x0 }));
            // => 2147483647
        }

        
    }
}