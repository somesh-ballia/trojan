using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ServerMain
{
    class SnapshotGrabber
    {
        public static void captureScreen()
        {
            try
            {
                Bitmap screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                Graphics screenshotGraphics = Graphics.FromImage(screenshot);
                screenshotGraphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
                MemoryStream screenStream = new MemoryStream();
                screenshot.Save(screenStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                BinaryFormatter formatter = new BinaryFormatter();
                MemoryStream sizeStream = new MemoryStream();
                formatter.Serialize(sizeStream, screenStream.ToArray().Length.ToString());
                ServerMain.socketConnect.Send(sizeStream.ToArray());
                byte[] ack = new byte[1];
                while (ServerMain.socketAccept.Receive(ack) == 0) ;
                ServerMain.socketConnect.Send(screenStream.ToArray());
            }
            catch (Exception)
            {
                ServerMain.connectionfailure = true;
            }
        }
    }
}
