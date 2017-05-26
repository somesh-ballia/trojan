using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ClientMain
{
    public partial class ProcessManager : Form
    {
        public ProcessManager()
        {
            InitializeComponent();
        }

        public static Form mainForm;

        private void ProcessManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Visible = true;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxId.Items.Clear();
                listBoxName.Items.Clear();
                byte[] commandNo = new byte[1];
                commandNo[0] = 20;
                ClientMain.socketConnect.Send(commandNo);
                byte[] processDataSize = new byte[200];
                int dataSize;
                while ((dataSize = ClientMain.socketAccept.Receive(processDataSize)) == 0) ;
                BinaryFormatter formatter = new BinaryFormatter();
                MemoryStream ms = new MemoryStream(processDataSize, 0, dataSize);
                byte[] ack = new byte[1];
                ack[0] = 1;
                ClientMain.socketConnect.Send(ack);
                byte[] processData = new byte[(int)formatter.Deserialize(ms)];
                while ((dataSize = ClientMain.socketAccept.Receive(processData)) == 0) ;
                MemoryStream processStream = new MemoryStream(processData, 0, dataSize);
                int count = (int)formatter.Deserialize(processStream);
                for (int i = 0; i < count; i++)
                {
                    listBoxId.Items.Add((int)formatter.Deserialize(processStream));
                    listBoxName.Items.Add((string)formatter.Deserialize(processStream));
                }
            }
            catch (Exception)
            {
                ClientMain.connectionFailure = true;
                this.Close();
            }
        }

        private void buttonKill_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxId.SelectedIndex == -1)
                {
                    MessageBox.Show("No Process Selected!");
                    return;
                }
                DialogResult dr = MessageBox.Show("Are You Sure?", "Termination Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;
                byte[] commandNo = new byte[1];
                commandNo[0] = 21;
                ClientMain.socketConnect.Send(commandNo);
                while (ClientMain.socketAccept.Receive(commandNo) == 0) ;
                MemoryStream ms = new MemoryStream();
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, listBoxId.SelectedItem.ToString());
                byte[] transmitData = ms.ToArray();
                ClientMain.socketConnect.Send(transmitData);
                while (ClientMain.socketAccept.Receive(commandNo) == 0) ;
                MessageBox.Show("Termination Request Sent, Refresh To See the Effect!");
            }
            catch (Exception)
            {
                ClientMain.connectionFailure = true;
                this.Close();
            }
        }

        private void listBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxId.SelectedIndex = listBoxName.SelectedIndex;
        }

        private void listBoxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxName.SelectedIndex = listBoxId.SelectedIndex;
        }
    }
}
