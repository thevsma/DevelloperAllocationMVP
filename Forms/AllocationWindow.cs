﻿using System;
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
        public frmAllocation()
        {
            InitializeComponent();
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
    }
}
