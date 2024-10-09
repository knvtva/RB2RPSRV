using System;
using System.Net.Sockets;
using System.Net;

namespace Quazal
{
    public static class QPacketHandler
    {
          public static void ProcessPacket(string source, byte[] data, IPEndPoint ep, UdpClient listener, uint serverPID, ushort listenPort, bool removeConnectPayload = false)
          {
            QPacket p = new QPacket(data);
            MemoryStream m = new MemoryStream();
            byte[] buff = new byte[(int)p.realSize];

            m.Seek(0, 0);
            m.Read(buff, 0, buff.Length);

            QPacket reply = null;
            Client client = null;

            if(p.type != QPacket.PACKETTYPE.SYN && p.type != QPacket.PACKETTYPE.NATPING)
            {
              client = Server.GetClientByIDrecv(p.m_uiSignature);
            }
            switch (p.type)
            {
              case QPacket.PACKETTYPE.SYN:
                  reply = QPacketHandler.ProcessSYN(p, ep, out client);
                  break;
              case QPacket.PACKETTYPE.CONNECT:
                  if (client != null && !p.flags.Contains(QPacket.PACKETFLAG.FLAG_ACK))
                        {
                            client.sPID = serverPID;
                            client.sPort = listenPort;
                            if (removeConnectPayload)
                            {
                                p.payload = new byte[0];
                                p.payloadSize = 0;
                            }
                            reply = QPacketHandler.ProcessCONNECT(client, p);
                        }
                  break;
              case QPacket.PACKETTYPE.DISCONNECT:
                  if (client != null)
                      reply = QPacketHandler.ProcessDISCONNECT(client, p);
                      break;
              case QPacket.PACKETTYPE.PING:
                  if (client != null)
                      reply = QPacketHandler.ProcessPING(client, p);
                      break;
            }
          }
    }
}
