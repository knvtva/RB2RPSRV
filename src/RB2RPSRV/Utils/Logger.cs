using System;

namespace RB2RPSRV
{
    public static class Logger
    {
        public static bool isDebug = true;

        public static void Info(object message)
        {
            Console.WriteLine("[RB2RPSRV] <INFO> " + message);                    
        }

        public static void Warning(object message)
        {
            Console.WriteLine("[RB2RPSRV] <WARNING> " + message);          
        }

        public static void Error(object message)
        {
            Console.WriteLine("[RB2RPSRV] <ERROR> " + message);
        }

        public static void Debug(object message)
        {
            if (isDebug)
            {
            Console.WriteLine("[RB2RPSRV] <DEBUG> " + message);
            }
        }
    } 
}