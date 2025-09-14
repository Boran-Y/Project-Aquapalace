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
            if(frmMedewerkerMenu.ActiveForm != null)
            {
                frmMedewerkerMenu.ActiveForm.Close();
            }
        }
    }
}
