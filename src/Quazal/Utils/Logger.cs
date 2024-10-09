using System;

namespace Quazal
{
    public static class Logger
    {
        public static bool isDebug = true;

        public static void Info(object message)
        {
            Console.WriteLine("[Quazal] <INFO> " + message);                    
        }

        public static void Warning(object message)
        {
            Console.WriteLine("[Quazal] <WARNING> " + message);          
        }

        public static void Error(object message)
        {
            Console.WriteLine("[Quazal] <ERROR> " + message);
        }

        public static void Debug(object message)
        {
            if (isDebug)
            {
            Console.WriteLine("[Quazal] <DEBUG> " + message);
            }
        }
    } 
}