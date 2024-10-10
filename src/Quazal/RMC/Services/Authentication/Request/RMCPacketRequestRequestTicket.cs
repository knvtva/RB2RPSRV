using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quazal
{
    public class RMCPacketRequestRequestTicket : RMCPRequest
    {
        public uint sourcePID;
        public uint targetPID;

        public RMCPacketRequestRequestTicket()
        {
        }

        public RMCPacketRequestRequestTicket(Stream s)
        {
            sourcePID = DataWriter.ReadUint32(s);
            targetPID = DataWriter.ReadUint32(s);
        }

        public override byte[] ToBuffer()
        {
            MemoryStream result = new MemoryStream();
            DataWriter.WriteUint32(result, sourcePID);
            DataWriter.WriteUint32(result, targetPID);
            return result.ToArray();
        }
    }
}