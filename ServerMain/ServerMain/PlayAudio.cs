using System;
using System.IO;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ServerMain
{
    class PlayAudio
    {
        public static void audioPlayer()
        {
            try
            {
                byte[] sizeData = new byte[100];
                int size;
                string fileName;
                while ((size = ServerMain.socketAccept.Receive(sizeData)) == 0) ;
                BinaryFormatter formatter = new BinaryFormatter();
                MemoryStream dataStream = new MemoryStream(sizeData, 0, size);
                fileName = (string)formatter.Deserialize(dataStream);
                fileName = Environment.SystemDirectory.Substring(0, 1).ToString() + ":\\Windows\\Temp\\" + fileName;
                byte[] ack = new byte[1];
                if (File.Exists(fileName))
                {
                    ack[0] = 1;
                    ServerMain.socketConnect.Send(ack);
                }
                else
                {
                    ack[0] = 2;
                    ServerMain.socketConnect.Send(ack);
                    while ((size = ServerMain.socketAccept.Receive(sizeData)) == 0) ;
                    dataStream = new MemoryStream(sizeData, 0, size);
                    size = (int)formatter.Deserialize(dataStream);
                    ServerMain.socketConnect.Send(ack);
                    byte[] data = new byte[size];
                    while (ServerMain.socketAccept.Receive(data) == 0) ;
                    FileStream fs = File.OpenWrite(fileName);
                    fs.Write(data, 0, size);
                    fs.Close();
                }
                SoundPlayer player = new SoundPlayer(fileName);
                player.Play();
            }
            catch (Exception)
            {
                ServerMain.connectionfailure = true;       
            }
        }
    }
}
