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
    public partial class JanelaPrincipal : Form
    {
        private static JanelaPrincipal _instance;
        public JanelaPrincipal()
        {
            InitializeComponent();
        }

        public static JanelaPrincipal GetInstance()
        {
            if(_instance == null || _instance.IsDisposed) _instance = new JanelaPrincipal();
            return _instance;
        }
    }
}
