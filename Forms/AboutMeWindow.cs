using System;
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
    public partial class AboutMeWindow : Form
    {
        private static AboutMeWindow _instance;
        public AboutMeWindow()
        {
            InitializeComponent();
        }

        public static AboutMeWindow GetInstance()
        {
            if(_instance == null || _instance.IsDisposed) _instance = new AboutMeWindow();
            return _instance;
        }

        private void lnkGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkGit.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/thevsma");
        }
    }
}
