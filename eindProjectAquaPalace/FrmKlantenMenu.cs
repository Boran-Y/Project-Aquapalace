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

    public partial class FrmKlantenMenu : Form
    {
        public Gebruikers gebruikersobject;
        public FrmKlantenMenu(Gebruikers gebruikersobject)
        {

            InitializeComponent();

            this.gebruikersobject = gebruikersobject;


        }

        public FrmKlantenMenu()
        {
        }

        private void btnKlanten_Click(object sender, EventArgs e)
        {
            Frmklantenoverzicht klantenOverzicht = new Frmklantenoverzicht();
            klantenOverzicht.ShowDialog();
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
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            if(frmMedewerkerMenu.ActiveForm != null)
            {
                frmMedewerkerMenu.ActiveForm.Show();
                this.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
