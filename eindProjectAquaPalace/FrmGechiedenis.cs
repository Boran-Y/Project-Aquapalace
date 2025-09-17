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
    public partial class FrmGechiedenis : Form
    {
        public FrmGechiedenis()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
=======

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            lbxOverzicht.Items.Clear();
            foreach (Geschiedenis gechiedenis in Geschiedenis.GetAlleGeschiedenis())
            {
                lbxOverzicht.Items.Add(gechiedenis);
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            GebruikersRol Gebruikers = new GebruikersRol();

            if (Gebruikers == GebruikersRol.Medewerker)
            {
                if (frmMedewerkerMenu.ActiveForm != null)
                {
                    frmMedewerkerMenu.ActiveForm.Show();
                }
            }
            else
            {
                if (FrmBeheerderMenu.ActiveForm != null)
                {
                    FrmBeheerderMenu.ActiveForm.Show();
                }
            }

            if (FrmBeheerderMenu.ActiveForm != null)
            {
                FrmBeheerderMenu.ActiveForm.Close();
            }
        }

        private void FrmGechiedenis_Load(object sender, EventArgs e)
        {

        }
>>>>>>> 7a2ae1f00963ff4af96b45a935cf0d5a67dd3e3e
    }
}
