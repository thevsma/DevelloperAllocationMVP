using DeveloperAllocationMVP.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeveloperAllocationMVP
{
    public partial class frmMain : Form
    {
        private static frmMain _instance;
        public frmMain()
        {
            InitializeComponent();

            if(DeveloperRepository.LoggedDeveloper.Credential.Admin == false)
            {
                mnuDeveloper.Enabled = false;
                mnuProject.Enabled = false;
            }
        }

        public static frmMain GetInstance()
        {
            if(_instance == null || _instance.IsDisposed) _instance = new frmMain();
            return _instance;
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mnuDeveloper_Click(object sender, EventArgs e)
        {
            frmDevRegistration d = frmDevRegistration.GetInstance();
            d.MdiParent = this;
            d.Show();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            frmAbout a = frmAbout.GetInstance();
            a.MdiParent = this;
            a.Show();
        }

        private void mnuProject_Click(object sender, EventArgs e)
        {
            frmProjRegistration p = frmProjRegistration.GetInstance();
            p.MdiParent = this;
            p.Show();
        }

        private void mnuDevEntries_Click(object sender, EventArgs e)
        {
            frmDevLog d = frmDevLog.GetInstance();
            d.MdiParent = this;
            d.Show();
        }

        private void mnuAllocation_Click(object sender, EventArgs e)
        {
            frmAllocation a = frmAllocation.GetInstance();
            a.MdiParent = this;
            a.Show();
        }

        private void mnuProjEntries_Click(object sender, EventArgs e)
        {
            frmProjLog p = frmProjLog.GetInstance();
            p.MdiParent = this;
            p.Show();
        }
    }
}
