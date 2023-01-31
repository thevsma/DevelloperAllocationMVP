using DeveloperAllocationMVP.Entities;
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
    public partial class ProjectRegistrationWindow : Form
    {
        private static ProjectRegistrationWindow _instance;
        public ProjectRegistrationWindow()
        {
            InitializeComponent();
        }

        public static ProjectRegistrationWindow GetInstance()
        {
            if(_instance == null || _instance.IsDisposed) _instance = new ProjectRegistrationWindow();
            return _instance;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Project p = new Project();
            p.Name = txtName.Text;
            p.Start = dtpStart.Value;
            p.PlannedCompletion = dtpPlanned.Value;

            Repository repos = new Repository();
            repos.Projects.Add(p);
            repos.SaveChanges();

            MessageBox.Show(String.Format("Projeto {0} criado!", p.Name));
            txtName.Clear();
        }
    }
}
