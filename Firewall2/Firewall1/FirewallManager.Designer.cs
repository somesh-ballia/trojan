namespace Firewall1
{
    partial class FirewallManager
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelFwPrivate = new System.Windows.Forms.Label();
            this.labelFwPublic = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEnablePublic = new System.Windows.Forms.Button();
            this.buttonDisablePublic = new System.Windows.Forms.Button();
            this.buttonEnablePrivate = new System.Windows.Forms.Button();
            this.buttonDisablePrivate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3rdParty = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxEnable = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxPortNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonAllow = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port to Open:";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.Location = new System.Drawing.Point(243, 48);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(93, 23);
            this.buttonOpen.TabIndex = 5;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(243, 77);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(93, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port to Close:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 22);
            this.textBox2.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelFwPrivate);
            this.groupBox1.Controls.Add(this.labelFwPublic);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 62);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firewall Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Firewall Status For Private N/W:";
            // 
            // labelFwPrivate
            // 
            this.labelFwPrivate.AutoSize = true;
            this.labelFwPrivate.Location = new System.Drawing.Point(202, 18);
            this.labelFwPrivate.Name = "labelFwPrivate";
            this.labelFwPrivate.Size = new System.Drawing.Size(63, 16);
            this.labelFwPrivate.TabIndex = 19;
            this.labelFwPrivate.Text = "Disabled";
            // 
            // labelFwPublic
            // 
            this.labelFwPublic.AutoSize = true;
            this.labelFwPublic.Location = new System.Drawing.Point(202, 34);
            this.labelFwPublic.Name = "labelFwPublic";
            this.labelFwPublic.Size = new System.Drawing.Size(63, 16);
            this.labelFwPublic.TabIndex = 18;
            this.labelFwPublic.Text = "Disabled";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Firewall Status For Public N/W:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEnablePublic);
            this.groupBox2.Controls.Add(this.buttonDisablePublic);
            this.groupBox2.Controls.Add(this.buttonEnablePrivate);
            this.groupBox2.Controls.Add(this.buttonDisablePrivate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(287, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 77);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Firewall Controller";
            // 
            // buttonEnablePublic
            // 
            this.buttonEnablePublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnablePublic.Location = new System.Drawing.Point(144, 43);
            this.buttonEnablePublic.Name = "buttonEnablePublic";
            this.buttonEnablePublic.Size = new System.Drawing.Size(93, 23);
            this.buttonEnablePublic.TabIndex = 5;
            this.buttonEnablePublic.Text = "Enable";
            this.buttonEnablePublic.UseVisualStyleBackColor = true;
            this.buttonEnablePublic.Click += new System.EventHandler(this.buttonEnablePublic_Click);
            // 
            // buttonDisablePublic
            // 
            this.buttonDisablePublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisablePublic.Location = new System.Drawing.Point(243, 43);
            this.buttonDisablePublic.Name = "buttonDisablePublic";
            this.buttonDisablePublic.Size = new System.Drawing.Size(93, 23);
            this.buttonDisablePublic.TabIndex = 6;
            this.buttonDisablePublic.Text = "Disable";
            this.buttonDisablePublic.UseVisualStyleBackColor = true;
            this.buttonDisablePublic.Click += new System.EventHandler(this.buttonDisablePublic_Click);
            // 
            // buttonEnablePrivate
            // 
            this.buttonEnablePrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnablePrivate.Location = new System.Drawing.Point(144, 15);
            this.buttonEnablePrivate.Name = "buttonEnablePrivate";
            this.buttonEnablePrivate.Size = new System.Drawing.Size(93, 23);
            this.buttonEnablePrivate.TabIndex = 3;
            this.buttonEnablePrivate.Text = "Enable";
            this.buttonEnablePrivate.UseVisualStyleBackColor = true;
            this.buttonEnablePrivate.Click += new System.EventHandler(this.buttonEnablePrivate_Click);
            // 
            // buttonDisablePrivate
            // 
            this.buttonDisablePrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisablePrivate.Location = new System.Drawing.Point(243, 14);
            this.buttonDisablePrivate.Name = "buttonDisablePrivate";
            this.buttonDisablePrivate.Size = new System.Drawing.Size(93, 23);
            this.buttonDisablePrivate.TabIndex = 4;
            this.buttonDisablePrivate.Text = "Disable";
            this.buttonDisablePrivate.UseVisualStyleBackColor = true;
            this.buttonDisablePrivate.Click += new System.EventHandler(this.buttonDisablePrivate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Public N/W Firewall:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Private N/W Firewall:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3rdParty);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 42);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3rd Party Firewall";
            // 
            // label3rdParty
            // 
            this.label3rdParty.AutoSize = true;
            this.label3rdParty.Location = new System.Drawing.Point(60, 18);
            this.label3rdParty.Name = "label3rdParty";
            this.label3rdParty.Size = new System.Drawing.Size(41, 16);
            this.label3rdParty.TabIndex = 1;
            this.label3rdParty.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Name:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxEnable);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textBoxPortNo);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.labelFileName);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.buttonFile);
            this.groupBox4.Controls.Add(this.buttonAllow);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 128);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 163);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Allow Applications";
            // 
            // comboBoxEnable
            // 
            this.comboBoxEnable.FormattingEnabled = true;
            this.comboBoxEnable.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxEnable.Location = new System.Drawing.Point(83, 89);
            this.comboBoxEnable.Name = "comboBoxEnable";
            this.comboBoxEnable.Size = new System.Drawing.Size(180, 24);
            this.comboBoxEnable.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Enable:";
            // 
            // textBoxPortNo
            // 
            this.textBoxPortNo.Location = new System.Drawing.Point(83, 61);
            this.textBoxPortNo.Name = "textBoxPortNo";
            this.textBoxPortNo.Size = new System.Drawing.Size(180, 22);
            this.textBoxPortNo.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Port No:";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(80, 42);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(12, 16);
            this.labelFileName.TabIndex = 21;
            this.labelFileName.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "File Name:";
            // 
            // buttonFile
            // 
            this.buttonFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFile.Location = new System.Drawing.Point(83, 16);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(93, 23);
            this.buttonFile.TabIndex = 19;
            this.buttonFile.Text = "Add File";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonAllow
            // 
            this.buttonAllow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllow.Location = new System.Drawing.Point(83, 119);
            this.buttonAllow.Name = "buttonAllow";
            this.buttonAllow.Size = new System.Drawing.Size(93, 23);
            this.buttonAllow.TabIndex = 1;
            this.buttonAllow.Text = "Add Exception";
            this.buttonAllow.UseVisualStyleBackColor = true;
            this.buttonAllow.Click += new System.EventHandler(this.buttonAllow_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "File Path:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Executable Files|*.exe";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.buttonOpen);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.buttonClose);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(287, 95);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(348, 112);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Opening n Closing Ports";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "Name:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 22);
            this.textBox3.TabIndex = 9;
            // 
            // FirewallManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 303);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirewallManager";
            this.Text = "Filrewall Manager";
            this.Load += new System.EventHandler(this.FirewallManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelFwPrivate;
        private System.Windows.Forms.Label labelFwPublic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonEnablePublic;
        private System.Windows.Forms.Button buttonDisablePublic;
        private System.Windows.Forms.Button buttonEnablePrivate;
        private System.Windows.Forms.Button buttonDisablePrivate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3rdParty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonAllow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxPortNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxEnable;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox3;
    }
}

