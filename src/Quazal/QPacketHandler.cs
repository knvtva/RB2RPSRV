using System;
using System.Net.Sockets;
using System.Net;

namespace Quazal
{
    public static class QPacketHandler
    {
          public static void ProcessPacket(string source, byte[] data, IPEndPoint ep, UdpClient listener, uint serverPID, ushort listenPort, bool removeConnectPayload = false)
          { // }
    }
}
