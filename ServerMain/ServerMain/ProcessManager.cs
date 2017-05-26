using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ServerMain
{
    class ProcessManager
    {
        public static void getProcesses()
        {
            try
            {
                // GET PROCESSES
                Process[] currentProcesses = Process.GetProcesses();
                int count = currentProcesses.Length;
                int[] pid = new int[count];
                string[] pname = new string[count];

                int i = 0;
                foreach (Process p in currentProcesses)
                {
                    p.Refresh();
                    if (p.BasePriority < 32)
                    {
                        if (p.SessionId >= 0)
                        {
                            pid[i] = p.Id;
                            pname[i] = p.ProcessName;
                            i++;
                        }
                    }
                }
                // CONVERT FOR TRANSMISSION
                BinaryFormatter binaryformat = new BinaryFormatter();
                MemoryStream stream = new MemoryStream();
                binaryformat.Serialize(stream, count);
                for (i = 0; i < count; i++)
                {
                    binaryformat.Serialize(stream, pid[i]);
                    binaryformat.Serialize(stream, pname[i]);
                }
                MemoryStream ms = new MemoryStream();
                binaryformat.Serialize(ms, stream.ToArray().Length);
                // SEND DATA
                ServerMain.socketConnect.Send(ms.ToArray());
                byte[] ack = new byte[1];
                while (ServerMain.socketAccept.Receive(ack) == 0) ;
                ServerMain.socketConnect.Send(stream.ToArray());
            }
            catch (Exception)
            {
                ServerMain.connectionfailure = true;
            }
        }

        public static void killProcess()
        {
            try
            {
                byte[] ack = new byte[1];
                ack[0] = 1;
                ServerMain.socketConnect.Send(ack);
                byte[] receiveData = new byte[200];
                int dataSize;
                while ((dataSize = ServerMain.socketAccept.Receive(receiveData)) == 0) ;
                MemoryStream stream = new MemoryStream(receiveData, 0, dataSize);
                BinaryFormatter formatter = new BinaryFormatter();
                Process processTerminate = Process.GetProcessById(int.Parse((string)formatter.Deserialize(stream)));
                processTerminate.Kill();
                ServerMain.socketConnect.Send(ack);
            }
            catch (Exception)
            {
                ServerMain.connectionfailure = true;
            }
        }
    }
}
