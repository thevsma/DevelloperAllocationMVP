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

namespace DeveloperAllocationMVP.Forms
{
    public partial class frmAllocation : Form
    {
        private static frmAllocation _instance;
        public frmAllocation()
        {
            InitializeComponent();
        }

        public static frmAllocation GetInstance()
        {
            if(_instance == null || _instance.IsDisposed) _instance = new frmAllocation();
            return _instance;
        }

        private void txtDeveloper_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using(Repository repos = new Repository())
                {
                    lstDeveloper.DataSource = DeveloperRepository.FindByPartialName(txtDeveloper.Text);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtProject_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using(Repository repos = new Repository())
                {
                    lstProject.DataSource = ProjectRepository.FindByPartialName(txtProject.Text);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
