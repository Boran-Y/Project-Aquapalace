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
            if (FrmBeheerderMenu.ActiveForm != null)
            {
                FrmBeheerderMenu.ActiveForm.Show();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            lbxAbonementAantal.Items.Clear();
            foreach (var abonnementObject in Abonnement.getAbonnementen())
            {
                lbxAbonementAantal.Items.Add(abonnementObject);
            }

            lbxAbonementVerlopen.Items.Clear();
            foreach (var abonnementObject in Abonnement.VerlopenAbonnementen())
            {
                lbxAbonementVerlopen.Items.Add(abonnementObject);
            }

            lbxIncheck.Items.Clear();
            foreach (var geschiedenis in Geschiedenis.incheckDatum())
            {
                lbxIncheck.Items.Add(geschiedenis);
            }

        }

        private void AbboBeheer_Click_1(object sender, EventArgs e)
        {
            FrmAbbo frmAbbo = new FrmAbbo();
            frmAbbo.Show();

        }
    }
}
