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
    public partial class frmMedewerkerMenu : Form
    {
        public Gebruikers gebruikersobject;
        public frmMedewerkerMenu(Gebruikers gebruikersobject)
        {
            InitializeComponent();
            this.gebruikersobject = gebruikersobject;
        }

        public frmMedewerkerMenu()
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(frmMedewerkerMenu.ActiveForm != null)
            {
                frmMedewerkerMenu.ActiveForm.Hide();
            }
        }

        private void btnKlanten_Click(object sender, EventArgs e)
        {
            Frmklantenoverzicht klantenForm = new Frmklantenoverzicht();
            klantenForm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboardForm = new FrmDashboard();
            dashboardForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            FrmAbbo abboForm = new FrmAbbo();
            abboForm.Show();
        }

        private void frmhoofdmenu_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            

        }

        private void btnGeschiedenis_Click(object sender, EventArgs e)
        {
            FrmGechiedenis geschiedenisForm = new FrmGechiedenis();
            geschiedenisForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
