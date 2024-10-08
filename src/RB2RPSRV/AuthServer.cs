using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace RB2RPSRV
{
    public static class AuthServer
    {
        public static readonly object _sync = new object();
        public static bool _exit = false;
        private static UdpClient listener;
        private static ushort listenPort = 30640;



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
            Console.WriteLine("[RB2RPSRV] Auth Server Started on " + IPAddress.Any + ":" + listenPort);
            listener = new UdpClient(listenPort);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 0);
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
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                } 
            }
            Console.WriteLine("[RB2RPSRV] Secure Server Stopped");
        }

        public static void ProcessPacket(byte[] data, IPEndPoint ep)
        {
            Console.WriteLine("[RB2RPSRV] <> Not Implemented...");
        }
    }
}