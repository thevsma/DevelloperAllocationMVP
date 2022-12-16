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
    public partial class DeveloperRegistrationWindow : Form
    {
        private static DeveloperRegistrationWindow _instance;
        public DeveloperRegistrationWindow()
        {
            InitializeComponent();
        }

        public static DeveloperRegistrationWindow GetInstance()
        {
            if(_instance == null || _instance.IsDisposed) _instance = new DeveloperRegistrationWindow();
            return _instance;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Developer dev = new Developer();
            dev.Name = txtName.Text;
            dev.Birthday = dtpBirthday.Value;
            dev.LvlInMemory = txtLevel.Text[0];

            Credential cred = new Credential();
            cred.Email = txtEmail.Text;
            cred.Password = txtPwd.Text;
            cred.Admin = cbAdmin.Checked;
            cred.Active= cbActive.Checked;

            dev.Credential = cred;
            cred.Developer = dev;

            Repository repos = new Repository();
            repos.Developers.Add(dev);
            repos.SaveChanges();

            MessageBox.Show(String.Format("Desenvolvedor {0} cadastrado!", dev.Name));
            this.Close();
        }

        private void txtLevel_Click(object sender, EventArgs e)
        {
            txtLevel.SelectAll();
        }

        private void txtPwd_Click(object sender, EventArgs e)
        {
            txtPwd.SelectAll();
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) dtpBirthday.Focus();
        }

        private void txtLevel_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) txtEmail.Focus();
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) txtPwd.Focus();
        }
    }
}
