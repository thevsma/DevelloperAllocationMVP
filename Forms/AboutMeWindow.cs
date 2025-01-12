﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeveloperAllocationMVP.Forms
{
    public partial class frmAbout : Form
    {
        private static frmAbout _instance;
        public frmAbout()
        {
            InitializeComponent();
        }

        public static frmAbout GetInstance()
        {
            if(_instance == null || _instance.IsDisposed) _instance = new frmAbout();
            return _instance;
        }

        private void lnkGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkGit.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/thevsma");
        }
    }
}
