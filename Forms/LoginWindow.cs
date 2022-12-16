using DeveloperAllocationMVP.Repositories;
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
    public partial class frmLogin : Form
    {
        private static frmLogin _instance;
        public frmLogin()
        {
            InitializeComponent();
        }

        public static frmLogin GetInstance()
        {
            if(_instance == null || _instance.IsDisposed) _instance = new frmLogin();
            return _instance;
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtPwd.Focus();
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin.PerformClick();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(CredentialRepository.Authenticate(txtEmail.Text, txtPwd.Text))
            {
                txtEmail.Clear();
                txtPwd.Clear();
                this.Hide();
                MainWindow jp = MainWindow.GetInstance();
                jp.Show();
                MessageBox.Show(String.Format("Seja bem vindo(a) {0}!", Repository.LoggedDeveloper.Name));
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Repository repos = new Repository();
        }
    }
}
