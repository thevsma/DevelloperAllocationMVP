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
    public partial class MainWindow : Form
    {
        private static MainWindow _instance;
        public MainWindow()
        {
            InitializeComponent();

            if(Repository.LoggedDeveloper.Credential.Admin == false)
            {
                mnuDeveloper.Enabled = false;
                mnuProject.Enabled = false;
            }
        }

        public static MainWindow GetInstance()
        {
            if(_instance == null || _instance.IsDisposed) _instance = new MainWindow();
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
            DeveloperRegistrationWindow d = DeveloperRegistrationWindow.GetInstance();
            d.MdiParent = this;
            d.Show();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            AboutMeWindow a = AboutMeWindow.GetInstance();
            a.MdiParent = this;
            a.Show();
        }

        private void mnuProject_Click(object sender, EventArgs e)
        {
            ProjectRegistrationWindow p = ProjectRegistrationWindow.GetInstance();
            p.MdiParent = this;
            p.Show();
        }

        private void mnuDevEntries_Click(object sender, EventArgs e)
        {
            DeveloperLogWindow d = DeveloperLogWindow.GetInstance();
            d.MdiParent = this;
            d.Show();
        }
    }
}
