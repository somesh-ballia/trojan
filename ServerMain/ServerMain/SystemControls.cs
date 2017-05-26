using System;

namespace ServerMain
{
    class SystemControls
    {
        public static void logOff()
        {
            System.Diagnostics.Process.Start("shutdown", "/l");
        }

        public static void powerOff()
        {
            System.Diagnostics.Process.Start("shutdown", "/s /t 0"); ;
        }

        public static void reStart()
        {
            System.Diagnostics.Process.Start("shutdown", "/r /t 0"); ;
        }
    }
}
