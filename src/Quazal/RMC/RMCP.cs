using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Quazal
{
    public class RMCP
    {
        public enum PROTOCOL
        {
            AuthenticationService = 0xA,
        }

        public PROTOCOL proto;
        public bool isRequest;
        public bool success;
        public uint error;
        public uint callID;
        public uint methodID;
        public RMCPRequest request;
        public int _afterProtocolOffset;

        public RMCP()
        {
        }

        public RMCP(QPacket p)
        {
            MemoryStream m = new MemoryStream(p.payload);
            DataWriter.ReadUint32(m);
            ushort b = DataWriter.ReadUint8(m);
            isRequest = (b >> 7) == 1;
            try
            {
                if ((b & 0x7F) != 0x7F)
                    proto = (PROTOCOL)(b & 0x7F);
                else
                {
                    b = DataWriter.ReadUint16(m);
                    proto = (PROTOCOL)(b);
                }
            }
            catch
            {
                return;
            }
            _afterProtocolOffset = (int)m.Position;
        }
        

        public byte[] ToBuffer()
        {
            MemoryStream result = new MemoryStream();
            byte[] buff = request.ToBuffer();
            DataWriter.WriteUint32(result, (uint)(buff.Length + 9));
            byte b = (byte)proto;
            if (isRequest)
                b |= 0x80;
            DataWriter.WriteUint8(result, b);
            DataWriter.WriteUint32(result, callID);
            DataWriter.WriteUint32(result, methodID);
            result.Write(buff, 0, buff.Length);
            return result.ToArray();
        }
    }
}