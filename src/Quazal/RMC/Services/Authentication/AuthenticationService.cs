using System;

namespace Quazal
{
    public static class AuthenticationService
    {
        public static void ProcessAuthenticationServiceRequest(Stream s, RMCP rmc)
        {
            switch(rmc.methodID)
            {
                case 1:
                    rmc.request = new RMCPacketRequestLogin(s);
                    break;
                case 3:
                    rmc.request = new RMCPacketRequestTicket(s);
                    break;
                default:
                    Logger.Error("[RMC Authentication] Unknown Method ID" + rmc.methodID);
                    break;
            }
        }
    }
}