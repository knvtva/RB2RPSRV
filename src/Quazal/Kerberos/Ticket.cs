using System;

namespace Quazal
{
    public class Ticket
    {
        public uint userPID;
        public byte[] sessionKey;
        public uint serverPID;
        public byte[] ticketData;

        public Ticket(uint sPID)
        {
            serverPID = sPID;
        }

        public byte[] toBuffer()
        {
            MemoryStream m = new MemoryStream();
            m.Write(sessionKey, 0, 16);
            DataWriter.WriteUint32(m, serverPID);
            DataWriter.WriteUint32(m, (uint)ticketData.Length);
            m.Write(ticketData, 0, ticketData.Length);
            byte[] buff = m.ToArray();
            byte[] key = DataWriter.DeriveKey(userPID);
            buff = DataWriter.Encrypt(key, buff);
            byte[] hmac = DataWriter.MakeHMAC(key, buff);
            m = new MemoryStream();
            m.Write(buff, 0, buff.Length);
            m.Write(hmac, 0, hmac.Length);
            return m.ToArray();
        }
    }
}
