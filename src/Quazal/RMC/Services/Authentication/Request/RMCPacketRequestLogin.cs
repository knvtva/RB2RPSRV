using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quazal
{
    public class RMCPacketRequestLogin : RMCPRequest
    {
        public string user;
        public string username;

        public RMCPacketRequestLogin()
        { 
        }

        public RMCPacketRequestLogin(Stream s)
        {
            user = DataWriter.ReadString(s);
            ProcessData(s);
        }

        private void ProcessData(Stream s)
        {
            DataWriter.ReadUint32(s);
            DataWriter.ReadUint32(s);
            username = DataWriter.Read2ByteString(s);
        }

        public override byte[] ToBuffer()
        {
            MemoryStream result = new MemoryStream();
            DataWriter.WriteString(result, user);
            MemoryStream m = new MemoryStream();
            DataWriter.WriteString(m, username);
            byte[] buff = m.ToArray();
            DataWriter.WriteUint32(result, (uint)(buff.Length + 4));
            DataWriter.WriteUint32(result, (uint)buff.Length);
            result.Write(buff, 0, buff.Length);
            return result.ToArray();
        }
    }
}