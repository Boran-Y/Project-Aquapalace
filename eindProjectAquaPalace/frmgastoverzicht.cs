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
    public partial class Frmgastoverzicht : Form
    {
        public Frmgastoverzicht()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frmMedewerkerMenu.ActiveForm != null)
            {
                frmMedewerkerMenu.ActiveForm.Show();
            }
            this.Close();

        }

        private void lbxAbonementAantal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void abonomenttoevegoenbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
