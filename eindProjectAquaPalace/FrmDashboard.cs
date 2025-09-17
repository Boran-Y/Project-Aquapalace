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
<<<<<<< HEAD
            if (frmhoofdmenu.ActiveForm != null)
            {
                frmhoofdmenu.ActiveForm.Show();
=======
            if (FrmBeheerderMenu.ActiveForm != null)
            {
                FrmBeheerderMenu.ActiveForm.Show();
>>>>>>> 7a2ae1f00963ff4af96b45a935cf0d5a67dd3e3e
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
