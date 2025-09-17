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
<<<<<<< HEAD:eindProjectAquaPalace/frmhoofdmenu.cs
        public frmhoofdmenu()
=======
        public Gebruikers gebruikersobject;
        public frmMedewerkerMenu(Gebruikers gebruikersobject)
>>>>>>> 7a2ae1f00963ff4af96b45a935cf0d5a67dd3e3e:eindProjectAquaPalace/frmMedewerkerMenu.cs
        {
            InitializeComponent();
            this.gebruikersobject = gebruikersobject;
        }

        public frmMedewerkerMenu()
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(frmhoofdmenu.ActiveForm != null)
            {
                frmhoofdmenu.ActiveForm.Hide();
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

            FrmAbbo AbboForm = new FrmAbbo();
            AbboForm.Show();
            this.Hide();

        }
    }
}
