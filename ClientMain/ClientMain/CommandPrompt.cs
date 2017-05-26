using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ClientMain
{
    public partial class CommandPrompt : Form
    {
        public CommandPrompt()
        {
            InitializeComponent();
        }

        public static Form mainForm;

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (textBoxCommand.Text == "")
            {
                MessageBox.Show("No Command To Execute!");
                return;
            }
            try
            {
                byte[] commandNo = new byte[1];
                commandNo[0] = 56;
                ClientMain.socketConnect.Send(commandNo);
                MemoryStream dataStream = new MemoryStream();
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(dataStream, textBoxCommand.Text);
                ClientMain.socketConnect.Send(dataStream.ToArray());
            }
            catch (Exception)
            {
                ClientMain.connectionFailure = true;
                this.Close();
            }
        }

        private void CommandPrompt_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Visible = true;
        }
    }
}
