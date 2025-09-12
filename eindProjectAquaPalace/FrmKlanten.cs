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
    public partial class FrmKlanten : Form
    {
        public FrmKlanten()
        {
            InitializeComponent();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            if (frmhoofdmenu.ActiveForm != null)
            {
                frmhoofdmenu.ActiveForm.Show();
            }
            this.Close();
        }

        private void cbxAbbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmKlanten_Load(object sender, EventArgs e)
        {

        }
    }
}
