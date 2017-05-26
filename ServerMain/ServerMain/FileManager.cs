using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ServerMain
{
    class FileManager
    {
        public static bool connectionFailure = false;

        public static void fileManagerKernel()
        {
            byte[] commandNo = new byte[1];
            do
            {
                try
                {
                    while (ServerMain.socketAccept.Receive(commandNo) == 0) ;
                }
                catch (Exception)
                {
                    connectionFailure = true;
                    commandNo[0] = 0;
                }
                switch (commandNo[0])
                {
                    case 1:
                        refreshHost();
                        break;
                    case 2:
                        beforeExpand();
                        break;
                    case 3:
                        afterSelect();
                        break;
                    case 4:
                        fileDownload();
                        break;
                    case 5:
                        fileUpload();
                        break;
                    default:
                        break;
                }
                if (connectionFailure == true)
                    ServerMain.connectionfailure = true;
            } while (commandNo[0] != 0);
        }

        public static void refreshHost()
        {
            try
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                MemoryStream driveInfoStream = new MemoryStream();
                BinaryFormatter formatter = new BinaryFormatter();
                int count = 0;
                foreach (DriveInfo drv in allDrives)
                {
                    if (drv.IsReady)
                        count++;
                }
                formatter.Serialize(driveInfoStream, count);
                foreach (DriveInfo drv in allDrives)
                {
                    if (drv.IsReady)
                        formatter.Serialize(driveInfoStream, drv.Name);
                }
                ServerMain.socketConnect.Send(driveInfoStream.ToArray());
            }
            catch (Exception)
            {
                connectionFailure = true;
            }
        }

        public static void beforeExpand()
        {
            try
            {
                byte[] path = new byte[1000];
                int size;
                while ((size = ServerMain.socketAccept.Receive(path)) == 0) ;
                MemoryStream dataStream = new MemoryStream(path, 0, size);
                BinaryFormatter formatter = new BinaryFormatter();
                int count = 0;
                try
                {
                    DirectoryInfo allDir = new DirectoryInfo((string)formatter.Deserialize(dataStream));
                    dataStream = new MemoryStream();
                    foreach (DirectoryInfo dr in allDir.GetDirectories())
                    {
                        try
                        {
                            count++;
                        }
                        catch (Exception) { }
                    }
                    formatter.Serialize(dataStream, count);
                    foreach (DirectoryInfo dr in allDir.GetDirectories())
                    {
                        try
                        {
                            formatter.Serialize(dataStream, dr.Name);
                        }
                        catch (Exception) { }
                    }
                }
                catch (Exception)
                {
                    dataStream = new MemoryStream();
                    formatter.Serialize(dataStream, count);
                }
                ServerMain.socketConnect.Send(dataStream.ToArray());
            }
            catch (Exception)
            {
                connectionFailure = true;
            }
        }

        public static void afterSelect()
        {
            try
            {
                byte[] path = new byte[1000];
                int size;
                while ((size = ServerMain.socketAccept.Receive(path)) == 0) ;
                MemoryStream dataStream = new MemoryStream(path, 0, size);
                MemoryStream sizeStream = new MemoryStream();
                BinaryFormatter formatter = new BinaryFormatter();
                int count = 0;
                try
                {
                    string[] allFiles = Directory.GetFiles((string)formatter.Deserialize(dataStream));
                    dataStream = new MemoryStream();
                    count = allFiles.Length;
                    formatter.Serialize(dataStream, count);
                    int index;
                    foreach (string s in allFiles)
                    {
                        index = s.LastIndexOf('\\');
                        formatter.Serialize(dataStream, s.Substring(index + 1));
                        FileInfo f = new FileInfo(s);
                        formatter.Serialize(sizeStream, f.Length);
                    }
                }
                catch (Exception)
                {
                    count = 0;
                    dataStream = new MemoryStream();
                    formatter.Serialize(dataStream, count);
                }
                ServerMain.socketConnect.Send(dataStream.ToArray());
                if (count != 0)
                {
                    byte[] ack = new byte[1];
                    while (ServerMain.socketAccept.Receive(ack) == 0) ;
                    ServerMain.socketConnect.Send(sizeStream.ToArray());
                }
            }
            catch (Exception)
            {
                connectionFailure = true;
            }
        }

        public static void fileDownload()
        {
            try
            {
                byte[] path = new byte[1000];
                int size;
                while ((size = ServerMain.socketAccept.Receive(path)) == 0) ;
                MemoryStream dataStream = new MemoryStream(path, 0, size);
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream fs = File.OpenRead((string)formatter.Deserialize(dataStream));
                byte[] data = new byte[(int)fs.Length];
                fs.Read(data, 0, (int)fs.Length);
                fs.Close();
                ServerMain.socketConnect.Send(data);
            }
            catch (Exception)
            {
                connectionFailure = true;
            }
        }

        public static void fileUpload()
        {
            try
            {
                byte[] path = new byte[1000];
                int size;
                while ((size = ServerMain.socketAccept.Receive(path)) == 0) ;
                MemoryStream dataStream = new MemoryStream(path, 0, size);
                BinaryFormatter formatter = new BinaryFormatter();
                int fileSize = (int)formatter.Deserialize(dataStream);
                string filePath = (string)formatter.Deserialize(dataStream);
                byte[] ack = new byte[1];
                ack[0] = 1;
                ServerMain.socketConnect.Send(ack);
                byte[] data = new byte[fileSize];
                while (ServerMain.socketAccept.Receive(data) == 0) ;
                FileStream fs = File.OpenWrite(filePath);
                fs.Write(data, 0, data.Length);
                fs.Close();
            }
            catch (Exception)
            {
                connectionFailure = true;
            }
        }
    }
}
