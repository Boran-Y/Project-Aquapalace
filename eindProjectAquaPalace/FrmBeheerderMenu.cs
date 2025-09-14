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
    public partial class FrmBeheerderMenu : Form
    {
        public FrmBeheerderMenu()
        {
            InitializeComponent();
        }

        private void btnGebruikers_Click(object sender, EventArgs e)
        {
            FrmUsers usersForm = new FrmUsers();
            usersForm.Show();
            this.Hide();
        }

        private void btnKlanten_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboardForm = new FrmDashboard();
            dashboardForm.Show();
            this.Hide();
        }

        private void btnAbbo_Click(object sender, EventArgs e)
        {
            FrmAbbo abboForm = new FrmAbbo();
            abboForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboardForm = new FrmDashboard();
            dashboardForm.Show();
            this.Hide();
        }

        private void btnGeschiedenis_Click(object sender, EventArgs e)
        {
            FrmGechiedenis geschiedenisForm = new FrmGechiedenis();
            geschiedenisForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRaportages frmRaportages = new FrmRaportages();
            frmRaportages.Show();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            if (frmMedewerkerMenu.ActiveForm != null)
            {
                frmMedewerkerMenu.ActiveForm.Show();
                this.Close();
            }
        }
    }
}
