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
    public partial class frmProjLog : Form
    {
        private static frmProjLog _instance;
        public frmProjLog()
        {
            InitializeComponent();

            lstProject.DataSource = ProjectRepository.FindAll();
        }

        public static frmProjLog GetInstance()
        {
            if(_instance == null || _instance.IsDisposed) _instance = new frmProjLog();
            return _instance;
        }
    }
}
