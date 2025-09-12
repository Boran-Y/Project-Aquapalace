using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eindProjectAquaPalace
{
    public partial class FrmAbbo : Form
    {
        private FrmDashboard frmDashboard;

        public FrmAbbo()
        {
            InitializeComponent();
        }

        public FrmAbbo(FrmDashboard frmDashboard)
        {
            this.frmDashboard = frmDashboard;
        }

        private void FrmAbbo_Load(object sender, EventArgs e)
        {

        }
    }
}
