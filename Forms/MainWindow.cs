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
    }
}
