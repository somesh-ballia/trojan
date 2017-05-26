using System;
using System.Windows.Forms;
using NATUPNPLib;
using NETCONLib;
using NetFwTypeLib;

namespace Firewall1
{
    public partial class FirewallManager : Form
    {
        public FirewallManager()
        {
            InitializeComponent();
        }

        INetFwPolicy2 fwPolicy2;
        DialogResult dr;
        string filename;
        public bool otherParty = true;
        
        private void FirewallManager_Load(object sender, EventArgs e)
        {
            comboBoxEnable.SelectedIndex = 0;
            checkFwStatus();
        }

        public void checkFwStatus()
        {
            fwPolicy2 = Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2")) as INetFwPolicy2;
            if (fwPolicy2.get_FirewallEnabled(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PUBLIC))
            {
                labelFwPublic.Text = "Enabled";
                otherParty = false;
            }
            else
                labelFwPublic.Text = "Disabled";
            if (fwPolicy2.get_FirewallEnabled(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PRIVATE))
            {
                labelFwPrivate.Text = "Enabled";
                otherParty = false;
            }
            else
                labelFwPrivate.Text = "Disabled";
            if (otherParty)
            {
                INetFwProduct fwPolicy = Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwProduct")) as INetFwProduct;
                label3rdParty.Text = fwPolicy.DisplayName;
            }
        }

        private void buttonEnablePrivate_Click(object sender, EventArgs e)
        {
            fwPolicy2 = Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2")) as INetFwPolicy2;
            fwPolicy2.set_FirewallEnabled(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PRIVATE, true);
            checkFwStatus();
        }

        private void buttonEnablePublic_Click(object sender, EventArgs e)
        {
            fwPolicy2 = Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2")) as INetFwPolicy2;
            fwPolicy2.set_FirewallEnabled(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PUBLIC, true);
            checkFwStatus();
        }

        private void buttonDisablePrivate_Click(object sender, EventArgs e)
        {
            fwPolicy2 = Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2")) as INetFwPolicy2;
            fwPolicy2.set_FirewallEnabled(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PRIVATE, false);
            checkFwStatus();
        }

        private void buttonDisablePublic_Click(object sender, EventArgs e)
        {
            fwPolicy2 = Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2")) as INetFwPolicy2;
            fwPolicy2.set_FirewallEnabled(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PUBLIC, false);
            checkFwStatus();
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);
                filename = filename.Substring(0, filename.LastIndexOf('.'));
                labelFileName.Text = filename;
            }

        }

        private void buttonAllow_Click(object sender, EventArgs e)
        {
            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("No File Selected!");
                return;
            }
            INetFwMgr manager = Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwMgr")) as INetFwMgr;
            INetFwAuthorizedApplication app = Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwAuthorizedApplication")) as INetFwAuthorizedApplication;
            INetFwProfile profile = manager.LocalPolicy.CurrentProfile;
            app.ProcessImageFileName = openFileDialog1.FileName;
            app.Name = filename;
            app.Scope = NET_FW_SCOPE_.NET_FW_SCOPE_ALL;
            app.IpVersion = NET_FW_IP_VERSION_.NET_FW_IP_VERSION_ANY;
            if (comboBoxEnable.SelectedIndex == 0)
                app.Enabled = true;
            else
                app.Enabled = false;
            profile.AuthorizedApplications.Add(app);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter Port No.!");
                return;
            }
            INetFwMgr manager = Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwMgr")) as INetFwMgr;
            INetFwOpenPort port = Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWOpenPort")) as INetFwOpenPort;
            port.Name = textBox3.Text;
            port.Port = int.Parse(textBox1.Text);
            port.Scope = NET_FW_SCOPE_.NET_FW_SCOPE_ALL;
            port.Protocol = NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP;
            port.Enabled = true;
            try
            {
                manager.LocalPolicy.CurrentProfile.GloballyOpenPorts.Add(port);
            }
            catch (Exception) { }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Enter Port No.!");
                return;
            }
            INetFwMgr manager = Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwMgr")) as INetFwMgr;
            try
            {
                manager.LocalPolicy.CurrentProfile.GloballyOpenPorts.Remove(int.Parse(textBox2.Text), NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP);
            }
            catch (Exception) { }
        }
    }
}
