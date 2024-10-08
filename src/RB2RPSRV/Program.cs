using System;

namespace RB2RPSRV
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            AuthServer.Start();
            SecureServer.Start();
        }
    }
}
