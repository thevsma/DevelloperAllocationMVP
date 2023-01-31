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

            cbbLevel.Items.Add("Selecione um nível");
            cbbLevel.Items.Add("Júnior");
            cbbLevel.Items.Add("Pleno");
            cbbLevel.Items.Add("Sênior");
        }

        public static DeveloperRegistrationWindow GetInstance()
        {
            if(_instance == null || _instance.IsDisposed) _instance = new DeveloperRegistrationWindow();
            return _instance;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtConfirmPwd.Text.Equals(txtPwd.Text))
            {
                if(txtName.Text != "" && txtEmail.Text != "")
                {
                    if (DeveloperRepository.FindByEmail(txtEmail.Text) == null)
                    {
                        if (txtPwd.Text.Length >= 8 && txtPwd.Text.Length <= 12)
                        {
                            Developer dev = new Developer(txtName.Text, dtpBirthday.Value, txtLevel.Text[0]);

                            Credential cred = new Credential(txtEmail.Text, txtPwd.Text, cbAdmin.Checked, cbActive.Checked);

                            dev.Credential = cred;
                            cred.Developer = dev;

                            Repository repos = new Repository();
                            repos.Developers.Add(dev);
                            repos.SaveChanges();

                            MessageBox.Show(String.Format("Desenvolvedor {0} cadastrado!", dev.Name));
                            txtName.Clear();
                            txtEmail.Clear();
                            txtPwd.Clear();
                            txtConfirmPwd.Clear();
                            txtLevel.Clear();
                        }
                        else MessageBox.Show("A senha deve ter entre 8 e 12 caracteres!!!");
                    }
                    else MessageBox.Show("Usuário com este email já está cadastrado!!!");
                }
                else MessageBox.Show("Os campos Nome e/ou Email não podem estar vazios!!!");
            }
            else MessageBox.Show("As senhas não coincidem!!!");
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

        private void txtConfirmPwd_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPwd.Text.Equals(txtPwd.Text)) btnRegister.Enabled = true;
        }

        private void txtPwd_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) txtConfirmPwd.Focus();
        }

        private void txtConfirmPwd_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) btnRegister.PerformClick();
        }
    }
}
