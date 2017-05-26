using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ClientMain
{
    public partial class FileManager : Form
    {
        public FileManager()
        {
            InitializeComponent();
        }

        public static Form mainForm;
        public static byte[] commandNo = new byte[1];
        public static bool connectionFailure = false;

        private void FileManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connectionFailure == true)
            {
                ClientMain.connectionFailure = true;
                connectionFailure = false;
            }
            else
            {
                try
                {
                    commandNo[0] = 0;
                    ClientMain.socketConnect.Send(commandNo);
                }
                catch (Exception)
                {
                    ClientMain.connectionFailure = true;
                }
                mainForm.Visible = true;
            }
        }

        private void buttonRefreshHost_Click(object sender, EventArgs e)
        {
            treeViewHostDisk.Nodes.Clear();
            foreach (DriveInfo drv in DriveInfo.GetDrives())
            {
                try
                {
                    if (drv.IsReady)
                    {
                        TreeNode t = new TreeNode();
                        t.Text = drv.Name;
                        t.Nodes.Add("");
                        treeViewHostDisk.Nodes.Add(t);
                    }
                }
                catch (Exception) { }
            }
        }

        private void buttonRefreshTarget_Click(object sender, EventArgs e)
        {
            try
            {
                treeViewTargetDisk.Nodes.Clear();
                commandNo[0] = 1;
                ClientMain.socketConnect.Send(commandNo);
                byte[] drvinfo = new byte[150];
                int size;
                while ((size = ClientMain.socketAccept.Receive(drvinfo)) == 0) ;
                MemoryStream allDrives = new MemoryStream(drvinfo, 0, size);
                BinaryFormatter formatter = new BinaryFormatter();
                int noOfDrives = (int)formatter.Deserialize(allDrives);
                for (int i = 0; i < noOfDrives; i++)
                {
                    TreeNode t = new TreeNode();
                    t.Text = (string)formatter.Deserialize(allDrives);
                    t.Nodes.Add("");
                    treeViewTargetDisk.Nodes.Add(t);
                }
            }
            catch (Exception)
            {
                connectionFailure = true;
                this.Close();
            }
        }

        private void treeViewTargetDisk_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                commandNo[0] = 3;
                ClientMain.socketConnect.Send(commandNo);
                listBoxTargetFiles.Items.Clear();
                listBoxTargetSize.Items.Clear();
                try
                {
                    MemoryStream datastream = new MemoryStream();
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(datastream, e.Node.FullPath);
                    ClientMain.socketConnect.Send(datastream.ToArray());
                    byte[] allFiles = new byte[200000];
                    int size;
                    while ((size = ClientMain.socketAccept.Receive(allFiles)) == 0) ;
                    datastream = new MemoryStream(allFiles, 0, size);
                    int fileNo = (int)formatter.Deserialize(datastream);
                    for (int i = 0; i < fileNo; i++)
                    {
                        listBoxTargetFiles.Items.Add((string)formatter.Deserialize(datastream));
                    }
                    if (fileNo != 0)
                    {
                        byte[] ack = new byte[1];
                        ack[0] = 1;
                        ClientMain.socketConnect.Send(ack);
                        while ((size = ClientMain.socketAccept.Receive(allFiles)) == 0) ;
                        datastream = new MemoryStream(allFiles, 0, size);
                        for (int i = 0; i < fileNo; i++)
                        {
                            listBoxTargetSize.Items.Add(GetSizeinfo("", (long)formatter.Deserialize(datastream)));
                        }
                    }
                }
                catch (Exception) { }
            }
            catch (Exception)
            {
                connectionFailure = true;
                this.Close();
            }
        }

        private void treeViewTargetDisk_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                commandNo[0] = 2;
                ClientMain.socketConnect.Send(commandNo);
                TreeNode parentnode = e.Node;
                MemoryStream datastream = new MemoryStream();
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(datastream, parentnode.FullPath);
                ClientMain.socketConnect.Send(datastream.ToArray());
                byte[] allDir = new byte[200000];
                int size;
                while ((size = ClientMain.socketAccept.Receive(allDir)) == 0) ;
                datastream = new MemoryStream(allDir, 0, size);
                parentnode.Nodes.Clear();
                int dirNo = (int)formatter.Deserialize(datastream);
                for (int i = 0; i < dirNo; i++)
                {
                    TreeNode t = new TreeNode();
                    t.Text = (string)formatter.Deserialize(datastream);
                    t.Nodes.Add("");
                    parentnode.Nodes.Add(t);
                }
            }
            catch (Exception)
            {
                connectionFailure = true;
                this.Close();
            }
        }

        private void treeViewHostDisk_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listBoxHostFiles.Items.Clear();
            listBoxHostSize.Items.Clear();
            try
            {
                TreeNode t = e.Node;
                string path = t.FullPath;
                string[] Files = Directory.GetFiles(path);
                int index;
                foreach (string Fname in Files)
                {
                    index = Fname.LastIndexOf('\\');
                    listBoxHostFiles.Items.Add(Fname.Substring(index + 1));
                    long a = 0;
                    listBoxHostSize.Items.Add(GetSizeinfo(Fname, a));
                }
            }
            catch (Exception) { }
        }

        private void treeViewHostDisk_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                TreeNode parentnode = e.Node;
                DirectoryInfo dr = new DirectoryInfo(parentnode.FullPath);
                parentnode.Nodes.Clear();
                foreach (DirectoryInfo dir in dr.GetDirectories())
                {
                    TreeNode t = new TreeNode();
                    t.Text = dir.Name;
                    t.Nodes.Add("");
                    parentnode.Nodes.Add(t);
                }
            }
            catch (Exception) { }
        }

        public static string GetSizeinfo(string path, long length)
        {
            long size, size1;
            if (path != "")
            {
                FileInfo fi = new FileInfo(path);
                size = fi.Length;
            }
            else
                size = length;
            size1 = size;
            string txtsize = "";
            if (size < 1024)
            {
                txtsize = "byte";
            }
            else if (size > 1024)
            {
                size = size / 1024;
                txtsize = "Kb";
            }
            if (size > 1024)
            {
                size = size / 1024;
                txtsize = "Mb";
            }
            if (size > 1024)
            {
                size = size / 1024;
                txtsize = "Gb";
            }
            return size + " " + txtsize + ", " + size1;
        }

        private void listBoxHostFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxHostSize.SelectedIndex = listBoxHostFiles.SelectedIndex;
        }

        private void listBoxTargetFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxTargetSize.SelectedIndex = listBoxTargetFiles.SelectedIndex;
        }

        private void buttonDownloadFile_Click(object sender, EventArgs e)
        {
            try
            {
                if ((listBoxTargetFiles.SelectedIndex == -1) || (treeViewHostDisk.SelectedNode == null))
                {
                    MessageBox.Show("Either File Or Target Directory Not Selected!");
                    return;
                }
                string fileSize = listBoxTargetSize.SelectedItem.ToString().Substring(listBoxTargetSize.SelectedItem.ToString().LastIndexOf(' ') + 1);
                if (long.Parse(fileSize) == 0)
                {
                    MessageBox.Show("File Does Not Contain Data To Copy");
                    return;
                }
                commandNo[0] = 4;
                ClientMain.socketConnect.Send(commandNo);
                string filePath = treeViewTargetDisk.SelectedNode.FullPath.ToString() + "\\" + listBoxTargetFiles.SelectedItem.ToString();
                MemoryStream datastream = new MemoryStream();
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(datastream, filePath);
                ClientMain.socketConnect.Send(datastream.ToArray());
                FileStream fs = File.OpenWrite(treeViewHostDisk.SelectedNode.FullPath + "\\" + listBoxTargetFiles.SelectedItem.ToString());
                byte[] data = new byte[(int)long.Parse(fileSize)];
                while (ClientMain.socketAccept.Receive(data) == 0) ;
                fs.Write(data, 0, data.Length);
                fs.Close();
            }
            catch (Exception)
            {
                connectionFailure = true;
                this.Close();
            }
        }

        private void buttonUploadFile_Click(object sender, EventArgs e)
        {
            try
            {
                if ((listBoxHostFiles.SelectedIndex == -1) || (treeViewTargetDisk.SelectedNode == null))
                {
                    MessageBox.Show("Either File Or Target Directory Not Selected!");
                    return;
                }
                string fileSize = listBoxHostSize.SelectedItem.ToString().Substring(listBoxHostSize.SelectedItem.ToString().LastIndexOf(' ') + 1);
                if (long.Parse(fileSize) == 0)
                {
                    MessageBox.Show("File Does Not Contain Data To Copy");
                    return;
                }
                commandNo[0] = 5;
                ClientMain.socketConnect.Send(commandNo);
                string filePath = treeViewTargetDisk.SelectedNode.FullPath.ToString() + "\\" + listBoxHostFiles.SelectedItem.ToString();
                MemoryStream datastream = new MemoryStream();
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(datastream, (int)long.Parse(fileSize));
                formatter.Serialize(datastream, filePath);
                ClientMain.socketConnect.Send(datastream.ToArray());
                byte[] ack = new byte[1];
                while (ClientMain.socketAccept.Receive(ack) == 0) ;
                FileStream fs = File.OpenRead(treeViewHostDisk.SelectedNode.FullPath.ToString() + "\\" + listBoxHostFiles.SelectedItem.ToString());
                byte[] data = new byte[(int)fs.Length];
                fs.Read(data, 0, (int)fs.Length);
                fs.Close();
                ClientMain.socketConnect.Send(data);
            }
            catch (Exception)
            {
                connectionFailure = true;
                this.Close();
            }
        }
    }
}
