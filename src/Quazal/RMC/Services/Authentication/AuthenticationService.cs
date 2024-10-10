using System;

namespace Quazal
{
    public static class AuthenticationService
    {
        public static void ProcessAuthenticationServiceRequest(Stream s, RMCP rmc)
        {
            switch(rmc.methodID)
            {
                //case 1:
                    //rmc.request = new RMCPacketRequestLogin(s);
                    //break;
                case 3:
                    rmc.request = new RMCPacketRequestRequestTicket(s);
                    break;
                default:
                    Logger.Error("[RMC Authentication] Unknown Method ID" + rmc.methodID);
                    break;
            }
        }

        public static void HandleAuthenticationServiceRequest(QPacket p, RMCP rmc, Client client)
        {
            RMCPResponse reply;
            switch (rmc.methodID)
            {
                case 1:
                    Logger.Error("[RMC Authentication] Login Request Received but not implemented");
                    break;
                case 3:
                    reply = new RMCPacketResponseRequestTicket(client.PID, client.sPID);
                    RMC.SendResponseWithACK(client.udp, p, rmc, client, reply);
                    break;
                default:
                    Logger.Error("[RMC Authentication] Unknown Method ID" + rmc.methodID);
                    break;
            }
        }
    }
}