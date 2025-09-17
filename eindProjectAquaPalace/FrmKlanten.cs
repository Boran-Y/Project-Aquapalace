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
        public Gebruikers gebruikersobject;
        public FrmKlanten(Gebruikers gebruikersobject)
        {
          
            InitializeComponent();
            this.gebruikersobject = gebruikersobject;
        }

        public FrmKlanten()
        {
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmhoofdmenu klantenForm = new frmhoofdmenu();
            klantenForm.Show();
            this.Hide();
=======
            GebruikersRol Gebruiker = new GebruikersRol();

            if( gebruikersobject != null )
            {
                if (gebruikersobject.Rol == GebruikersRol.Medewerker)
                {
                    if (frmMedewerkerMenu.ActiveForm != null)
                    {
                        frmMedewerkerMenu.ActiveForm.Show();
                    }
                }
                if(gebruikersobject.Rol == GebruikersRol.Beheerder)
                {
                    if (FrmBeheerderMenu.ActiveForm != null)
                    {
                        FrmBeheerderMenu.ActiveForm.Show();
                    }
                }
            }

>>>>>>> 7a2ae1f00963ff4af96b45a935cf0d5a67dd3e3e
        }

        private void cbxAbbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmKlanten_Load(object sender, EventArgs e)
        {

        }
    }
}
