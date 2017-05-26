namespace ClientMain
{
    partial class FileManager
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
            this.treeViewTargetDisk = new System.Windows.Forms.TreeView();
            this.listBoxTargetFiles = new System.Windows.Forms.ListBox();
            this.listBoxTargetSize = new System.Windows.Forms.ListBox();
            this.groupBoxTarget = new System.Windows.Forms.GroupBox();
            this.groupBoxHost = new System.Windows.Forms.GroupBox();
            this.treeViewHostDisk = new System.Windows.Forms.TreeView();
            this.listBoxHostFiles = new System.Windows.Forms.ListBox();
            this.listBoxHostSize = new System.Windows.Forms.ListBox();
            this.buttonRefreshTarget = new System.Windows.Forms.Button();
            this.buttonDownloadFile = new System.Windows.Forms.Button();
            this.buttonRefreshHost = new System.Windows.Forms.Button();
            this.buttonUploadFile = new System.Windows.Forms.Button();
            this.groupBoxTarget.SuspendLayout();
            this.groupBoxHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewTargetDisk
            // 
            this.treeViewTargetDisk.Location = new System.Drawing.Point(6, 19);
            this.treeViewTargetDisk.Name = "treeViewTargetDisk";
            this.treeViewTargetDisk.Size = new System.Drawing.Size(140, 290);
            this.treeViewTargetDisk.TabIndex = 0;
            this.treeViewTargetDisk.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewTargetDisk_BeforeExpand);
            this.treeViewTargetDisk.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTargetDisk_AfterSelect);
            // 
            // listBoxTargetFiles
            // 
            this.listBoxTargetFiles.FormattingEnabled = true;
            this.listBoxTargetFiles.Location = new System.Drawing.Point(152, 19);
            this.listBoxTargetFiles.Name = "listBoxTargetFiles";
            this.listBoxTargetFiles.Size = new System.Drawing.Size(140, 290);
            this.listBoxTargetFiles.TabIndex = 1;
            this.listBoxTargetFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxTargetFiles_SelectedIndexChanged);
            // 
            // listBoxTargetSize
            // 
            this.listBoxTargetSize.FormattingEnabled = true;
            this.listBoxTargetSize.Location = new System.Drawing.Point(298, 19);
            this.listBoxTargetSize.Name = "listBoxTargetSize";
            this.listBoxTargetSize.Size = new System.Drawing.Size(75, 290);
            this.listBoxTargetSize.TabIndex = 2;
            // 
            // groupBoxTarget
            // 
            this.groupBoxTarget.Controls.Add(this.treeViewTargetDisk);
            this.groupBoxTarget.Controls.Add(this.listBoxTargetFiles);
            this.groupBoxTarget.Controls.Add(this.listBoxTargetSize);
            this.groupBoxTarget.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTarget.Name = "groupBoxTarget";
            this.groupBoxTarget.Size = new System.Drawing.Size(379, 315);
            this.groupBoxTarget.TabIndex = 6;
            this.groupBoxTarget.TabStop = false;
            this.groupBoxTarget.Text = "Target\'s File Hierarchy";
            // 
            // groupBoxHost
            // 
            this.groupBoxHost.Controls.Add(this.treeViewHostDisk);
            this.groupBoxHost.Controls.Add(this.listBoxHostFiles);
            this.groupBoxHost.Controls.Add(this.listBoxHostSize);
            this.groupBoxHost.Location = new System.Drawing.Point(397, 12);
            this.groupBoxHost.Name = "groupBoxHost";
            this.groupBoxHost.Size = new System.Drawing.Size(379, 315);
            this.groupBoxHost.TabIndex = 7;
            this.groupBoxHost.TabStop = false;
            this.groupBoxHost.Text = "Host\'s File Hierarchy";
            // 
            // treeViewHostDisk
            // 
            this.treeViewHostDisk.Location = new System.Drawing.Point(6, 19);
            this.treeViewHostDisk.Name = "treeViewHostDisk";
            this.treeViewHostDisk.Size = new System.Drawing.Size(140, 290);
            this.treeViewHostDisk.TabIndex = 0;
            this.treeViewHostDisk.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewHostDisk_BeforeExpand);
            this.treeViewHostDisk.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewHostDisk_AfterSelect);
            // 
            // listBoxHostFiles
            // 
            this.listBoxHostFiles.FormattingEnabled = true;
            this.listBoxHostFiles.Location = new System.Drawing.Point(152, 19);
            this.listBoxHostFiles.Name = "listBoxHostFiles";
            this.listBoxHostFiles.Size = new System.Drawing.Size(140, 290);
            this.listBoxHostFiles.TabIndex = 1;
            this.listBoxHostFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxHostFiles_SelectedIndexChanged);
            // 
            // listBoxHostSize
            // 
            this.listBoxHostSize.FormattingEnabled = true;
            this.listBoxHostSize.Location = new System.Drawing.Point(298, 19);
            this.listBoxHostSize.Name = "listBoxHostSize";
            this.listBoxHostSize.Size = new System.Drawing.Size(75, 290);
            this.listBoxHostSize.TabIndex = 2;
            // 
            // buttonRefreshTarget
            // 
            this.buttonRefreshTarget.Location = new System.Drawing.Point(31, 333);
            this.buttonRefreshTarget.Name = "buttonRefreshTarget";
            this.buttonRefreshTarget.Size = new System.Drawing.Size(160, 23);
            this.buttonRefreshTarget.TabIndex = 8;
            this.buttonRefreshTarget.Text = "Refresh Target\'s File Hierarchy";
            this.buttonRefreshTarget.UseVisualStyleBackColor = true;
            this.buttonRefreshTarget.Click += new System.EventHandler(this.buttonRefreshTarget_Click);
            // 
            // buttonDownloadFile
            // 
            this.buttonDownloadFile.Location = new System.Drawing.Point(221, 333);
            this.buttonDownloadFile.Name = "buttonDownloadFile";
            this.buttonDownloadFile.Size = new System.Drawing.Size(160, 23);
            this.buttonDownloadFile.TabIndex = 9;
            this.buttonDownloadFile.Text = "Download File";
            this.buttonDownloadFile.UseVisualStyleBackColor = true;
            this.buttonDownloadFile.Click += new System.EventHandler(this.buttonDownloadFile_Click);
            // 
            // buttonRefreshHost
            // 
            this.buttonRefreshHost.Location = new System.Drawing.Point(412, 333);
            this.buttonRefreshHost.Name = "buttonRefreshHost";
            this.buttonRefreshHost.Size = new System.Drawing.Size(160, 23);
            this.buttonRefreshHost.TabIndex = 10;
            this.buttonRefreshHost.Text = "Refresh Host\'s File Hierarchy";
            this.buttonRefreshHost.UseVisualStyleBackColor = true;
            this.buttonRefreshHost.Click += new System.EventHandler(this.buttonRefreshHost_Click);
            // 
            // buttonUploadFile
            // 
            this.buttonUploadFile.Location = new System.Drawing.Point(602, 333);
            this.buttonUploadFile.Name = "buttonUploadFile";
            this.buttonUploadFile.Size = new System.Drawing.Size(160, 23);
            this.buttonUploadFile.TabIndex = 11;
            this.buttonUploadFile.Text = "Upload File";
            this.buttonUploadFile.UseVisualStyleBackColor = true;
            this.buttonUploadFile.Click += new System.EventHandler(this.buttonUploadFile_Click);
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 368);
            this.Controls.Add(this.buttonUploadFile);
            this.Controls.Add(this.buttonRefreshHost);
            this.Controls.Add(this.buttonDownloadFile);
            this.Controls.Add(this.buttonRefreshTarget);
            this.Controls.Add(this.groupBoxHost);
            this.Controls.Add(this.groupBoxTarget);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileManager_FormClosing);
            this.groupBoxTarget.ResumeLayout(false);
            this.groupBoxHost.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewTargetDisk;
        private System.Windows.Forms.ListBox listBoxTargetFiles;
        private System.Windows.Forms.ListBox listBoxTargetSize;
        private System.Windows.Forms.GroupBox groupBoxTarget;
        private System.Windows.Forms.GroupBox groupBoxHost;
        private System.Windows.Forms.TreeView treeViewHostDisk;
        private System.Windows.Forms.ListBox listBoxHostFiles;
        private System.Windows.Forms.ListBox listBoxHostSize;
        private System.Windows.Forms.Button buttonRefreshTarget;
        private System.Windows.Forms.Button buttonDownloadFile;
        private System.Windows.Forms.Button buttonRefreshHost;
        private System.Windows.Forms.Button buttonUploadFile;
    }
}