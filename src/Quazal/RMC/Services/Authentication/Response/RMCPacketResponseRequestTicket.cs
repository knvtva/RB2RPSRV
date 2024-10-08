using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quazal
{
    public class RMCPacketResponseRequestTicket : RMCPResponse
    {
        public uint resultCode = 0x10001;
        public byte[] ticketBuffer;
        public Ticket ticket;

        public RMCPacketResponseRequestTicket(uint pid, uint sPID)
        {
            ticket = new Ticket(sPID);
            ticket.userPID = pid;
            ticket.sessionKey = new byte[] { 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0x7, 0x8, 0x9, 0xa, 0xb, 0xc, 0xd, 0xe, 0xf, 0x10 };
            ticket.ticketData = new byte[] { 0x76, 0x21, 0x4B, 0xA6, 0x21, 0x96, 0xD3, 0xF3, 0x9A, 0x8C, 0x7A, 0x27, 0x0D, 0xD9, 0xB3, 0xFA, 0x21, 0x0E, 0xED, 0xAF, 0x42, 0x63, 0x92, 0x95, 0xC1, 0x16, 0x54, 0x08, 0xEE, 0x6E, 0x69, 0x17, 0x35, 0x78, 0x2E, 0x6E };
            ticketBuffer = ticket.toBuffer();
        }

        public override byte[] ToBuffer()
        {
            MemoryStream m = new MemoryStream();
            DataWriter.WriteUint32(m, resultCode);
            DataWriter.WriteUint32(m, (uint)ticketBuffer.Length);
            foreach (byte b in ticketBuffer)
                DataWriter.WriteUint8(m, b);
            return m.ToArray();
        }
    }
}