using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quazal
{
    public class Client
    {
        public string Username; // Platform Username
        public uint PID; // PlayerID
        public uint Port;
        public byte sessionID;
        public byte[] sessionKey;
        public static int signatureBase;
        public ushort sequenceCounter; // How many packets have go in and out
        public ushort seqCounterReliable = 1;

        public uint callCounterRMC;
        public string StationURL; // External + Also used for NAT Probing
        public uint IDrecv;
        public uint IDsend;
        public IPEndPoint ep;
        public UdpClient udp;

        public uint sPID; // Server PID
        public ushort sPort; // Server Port      


        public static void reset()
        {
            byte[] accessKeyBytes = Encoding.UTF8.GetBytes(Server.accessKey);
            signatureBase = Sum(accessKeyBytes);
        }

        private static int Sum(byte[] slice)
        {
            int total = 0;
            foreach (byte value in slice)
            {
                total += value;
            }
            return total;
        }
    }
}
