using DeveloperAllocationMVP.Entities;
using DeveloperAllocationMVP.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeveloperAllocationMVP.Forms
{
    public partial class frmProjRegistration : Form
    {
        private static frmProjRegistration _instance;
        public frmProjRegistration()
        {
            InitializeComponent();
        }

        public static frmProjRegistration GetInstance()
        {
            if(_instance == null || _instance.IsDisposed) _instance = new frmProjRegistration();
            return _instance;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Project p = new Project();
            p.Name = txtName.Text;
            p.Start = dtpStart.Value;
            p.PlannedCompletion = dtpPlanned.Value;

            ProjectRepository.Save(p);

            MessageBox.Show(String.Format("Projeto {0} criado!", p.Name));
            txtName.Clear();
        }
    }
}
