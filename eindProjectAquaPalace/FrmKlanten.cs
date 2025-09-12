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
            frmhoofdmenu klantenForm = new frmhoofdmenu();
            klantenForm.Show();
            this.Hide();
        }

        private void cbxAbbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
