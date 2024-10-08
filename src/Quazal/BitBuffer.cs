using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quazal
{
    public class BitBuffer
    {
        MemoryStream buffer;
        public int byteSize;
        public int bitSize;
        public int bitPos;

        public BitBuffer()
        {
            buffer = new MemoryStream();
            byteSize = 0;
            bitSize = 0;
            bitPos = 0;
            buffer.WriteByte(0);
        }

        public byte[] createArray()
        {
            MemoryStream m = new MemoryStream();
            // Implement WriteUint8
            byte[] data = buffer.ToArray();
            m.Write(data, 0, data.Length);
            return m.ToArray();
        }
    }
}