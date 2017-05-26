using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ServerMain
{
    class CDEject
    {
        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(String command, StringBuilder buffer, Int32 bufferSize, IntPtr hwndCallback);

        public static void ejectCD()
        {
            mciSendString("set CDAudio door open", null, 0, IntPtr.Zero);
        }
    }
}
