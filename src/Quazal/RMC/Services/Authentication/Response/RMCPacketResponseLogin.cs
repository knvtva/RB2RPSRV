using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quazal
{
    public class RMCPacketResponseLogin : RMCPResponse
    {
        public uint resultCode = 0x10001; // LOL I THINK?
        public uint PID;
        public byte[] pbufResponse;
        public Ticket ticket;
        public string address = Server.serverAddress;
        public ushort port;
        public uint serverID;
        public string pStationURl = "prudps:/address=#ADDRESS#;port=#PORT#;CID=1;PID=2;sid=1;stream=3;type=2"; // Server's stationURL pointing to the secure server.
        public uint unk2 = 0;
        public ushort unk3 = 0;
        public ushort unk4 = 0;
        public ushort unk5 = 0x1;
        public ushort unk6 = 0;

        public RMCPacketResponseLogin(uint pid, uint sPID, ushort sPort)
        {
            PID = pid;
            serverID = sPID;
            port = sPort;
            ticket = new Ticket(serverID);
            ticket.userPID = PID;
            ticket.sessionKey = new byte[] { 0x9C, 0xB0, 0x1D, 0x7A, 0x2C, 0x5A, 0x6C, 0x5B, 0xED, 0x12, 0x68, 0x45, 0x69, 0xAE, 0x09, 0x0D };
            ticket.ticketData = new byte[] { 0x76, 0x21, 0x4B, 0xA6, 0x21, 0x96, 0xD3, 0xF3, 0x9A, 0x8C, 0x7A, 0x27, 0x0D, 0xD9, 0xB3, 0xFA, 0x21, 0x0E, 0xED, 0xAF, 0x42, 0x63, 0x92, 0x95, 0xC1, 0x16, 0x54, 0x08, 0xEE, 0x6E, 0x69, 0x17, 0x35, 0x78, 0x2E, 0x6E };
            pbufResponse = ticket.toBuffer();
        }

        public override byte[] ToBuffer()
        {
            MemoryStream m = new MemoryStream();
            DataWriter.WriteUint32(m, resultCode);
            DataWriter.WriteUint32(m, PID);
            DataWriter.WriteUint32(m, (uint)pbufResponse.Length);
            m.Write(pbufResponse, 0, pbufResponse.Length);
            string s = MakeConnectionString();
            DataWriter.WriteUint16(m, (ushort)(s.Length + 1));
            foreach (char c in s)
                DataWriter.WriteUint8(m, (byte)c);
            DataWriter.WriteUint8(m, 0);
            DataWriter.WriteUint32(m, unk2);
            DataWriter.WriteUint16(m, unk3);
            DataWriter.WriteUint16(m, unk4);
            DataWriter.WriteUint16(m, unk5);
            DataWriter.WriteUint16(m, unk6);
            return m.ToArray();
        }

        private string MakeConnectionString()
        {
            return pStationURl.Replace("#ADDRESS#", address).Replace("#PORT#", port.ToString());
        }
    }
}