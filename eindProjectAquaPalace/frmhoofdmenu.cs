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
    public partial class frmhoofdmenu : Form
    {
        public frmhoofdmenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(frmhoofdmenu.ActiveForm != null)
            {
                frmhoofdmenu.ActiveForm.Hide();
            }
        }
    }
}
