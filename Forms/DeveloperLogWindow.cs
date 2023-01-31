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
    public partial class frmDevLog : Form
    {
        private static frmDevLog _instance;
        public frmDevLog()
        {
            InitializeComponent();

            lstDevs.DataSource = DeveloperRepository.FindAllDevsCredential();
        }

        public static frmDevLog GetInstance()
        {
            if (_instance == null || _instance.IsDisposed) _instance = new frmDevLog();
            return _instance;
        }
    }
}
