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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frmhoofdmenu.ActiveForm != null)
            {
                frmhoofdmenu.ActiveForm.Show();
            }
            this.Close();

        }

        private void btnKlantToevoegen_Click(object sender, EventArgs e)
        {
            FrmKlanten Klantenform = new FrmKlanten();
            Klantenform.Show();
            this.Hide();
        }

        private void AbboBeheer_Click(object sender, EventArgs e)
        {
            FrmAbbo frmAbbo = new FrmAbbo();
            frmAbbo.Show();
            this.Close();
        }

        private void lbxAbonementAantal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
