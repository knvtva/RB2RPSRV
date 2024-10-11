using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Quazal
{
    public static class Server
    {
        public static readonly string key = "CD&ML"; // Quazal Encryption & Decryption key
        public static readonly string accessKey = "dqN3rVe"; // (TODO) Use the access key from the config file
        public static string serverAddress = "192.168.1.27"; // Bind the server to this specific address
        public static uint idCounter = 0x9FAB6A15; // Not sure
        public static uint pidCounter = 0x1F4; // Not sure
        public static string sessionURL = "prudp:/address=192.168.1.27;port=0000;RVCID=1"; // Change this to Rock Band 2's sessionURL (TODO) grab data from config
        public static List<Client> clients = new List<Client>();

        public static Client GetClientByEndPoint(IPEndPoint ep)
        {
            foreach (Client c in clients)
                if (c.ep.Address.ToString() == ep.Address.ToString() && c.ep.Port == ep.Port)
                {
                    Logger.Debug("Client found");
                    return c;
                }

            return null;
        }

        public static Client GetClientByIDsend(uint id)
        {
            foreach (Client c in clients)
                if (c.IDsend == id)
                    return c;
            return null;
        }

        public static Client GetClientByIDrecv(uint id)
        {
            foreach (Client c in clients)
                if (c.IDrecv == id)
                    return c;
            return null;
        }  
    }
}