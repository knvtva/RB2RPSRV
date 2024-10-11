using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using Quazal;

namespace RB2RPSRV
{
    public static class AuthServer
    {
        public static readonly object _sync = new object();
        public static bool _exit = false;
        private static UdpClient listener;
        private static ushort listenPort = 30845;



        public static void Start()
        {
            _exit = false;
            new Thread(kMainThread).Start();
        }

        public static void Stop()
        {
            lock (_sync)
            {
                _exit = true;
            }
            if (listener != null)
            {
                listener.Close();
            }
        }

        public static void kMainThread(object obj)
        {
            Logger.Info("Auth Server started on " + IPAddress.Loopback + ":" + listenPort);
            listener = new UdpClient(listenPort);
            IPEndPoint ep = new IPEndPoint(IPAddress.Loopback, 0);
            while (true)
            {
                lock (_sync)
                {
                    if (_exit)
                        break;
                }
                try
                {
                    byte[] bytes = listener.Receive(ref ep);
                    ProcessPacket(bytes, ep);
                }
                catch (Exception e)
                {
                    Logger.Error(e.Message);
                }
            }
        }

        public static void ProcessPacket(byte[] data, IPEndPoint ep)
        {
            Logger.Debug("Recieved a packet sending to the Quazal Packet Handler");
            QPacketHandler.ProcessPacket("Auth", data, ep, listener, 0x2, listenPort);
        }
    }
}