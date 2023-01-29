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
    public partial class DeveloperLogWindow : Form
    {
        private static DeveloperLogWindow _instance;
        public DeveloperLogWindow()
        {
            InitializeComponent();

            lstDevs.DataSource = DeveloperRepository.FindAllDevsCredential();
        }

        public static DeveloperLogWindow GetInstance()
        {
            if (_instance == null || _instance.IsDisposed) _instance = new DeveloperLogWindow();
            return _instance;
        }
    }
}
