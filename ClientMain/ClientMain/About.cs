﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientMain
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        public static Form mainForm;

        private void About_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Visible = true;
        }
    }
}
