using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ClientMain
{
    public partial class SnapshotGrabber : Form
    {
        public SnapshotGrabber()
        {
            InitializeComponent();
        }

        public static Bitmap screenshot;
        public static Form mainForm;

        private void SnapshotGrabber_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Visible = true;
        }

        private void buttonCaptureShot_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] commandNo = new byte[1];
                commandNo[0] = 51;
                ClientMain.socketConnect.Send(commandNo);
                byte[] dataSize = new byte[2000];
                int size;
                while ((size = ClientMain.socketAccept.Receive(dataSize)) == 0) ;
                MemoryStream sizeStream = new MemoryStream(dataSize, 0, size);
                BinaryFormatter formatter = new BinaryFormatter();
                byte[] screenData = new byte[int.Parse((string)formatter.Deserialize(sizeStream))];
                ClientMain.socketConnect.Send(commandNo);
                while (ClientMain.socketAccept.Receive(screenData) == 0) ;
                TypeConverter converter = TypeDescriptor.GetConverter(typeof(Bitmap));
                screenshot = (Bitmap)converter.ConvertFrom(screenData);
                pictureBox1.Image = screenshot;
            }
            catch (Exception)
            {
                ClientMain.connectionFailure = true;
                this.Close();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (screenshot == null)
            {
                MessageBox.Show("Capture Screen First!");
                return;
            }
            screenshot.Save(Directory.GetCurrentDirectory() + "\\screenshot.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

    }
}
