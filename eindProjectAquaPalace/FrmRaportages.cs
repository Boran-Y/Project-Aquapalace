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
    public partial class FrmRaportages : Form
    {
        public FrmRaportages()
        {
            InitializeComponent();
        }

        private void FrmRaportages_Load(object sender, EventArgs e)
        {
            BindingSource bSource = Abonnement.MySQL_ToDatagridview();
            dataGridView1.DataSource = bSource;




            lbxActief.Items.Clear();
            foreach (Abonnement abbonement in Abonnement.getAbonnementen())
            {
                if (abbonement.Status == "Actief")
                {
                    lbxActief.Items.Add(abbonement);
                }
            }

            lbxverloopt.Items.Clear();
            foreach(raportageverlooptBinnemaand abbonement in raportageverlooptBinnemaand.GetAbonnementenVerlooptBinnenMaand())
            {
                lbxverloopt.Items.Add(abbonement);
            }


            lbxInchecks.Items.Clear();
            foreach (RapportageIncheck incheck in RapportageIncheck.GetIncheckRapportage())
            {
                lbxInchecks.Items.Add(incheck);
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            frmhoofdmenu hoofdmenu = new frmhoofdmenu();
            hoofdmenu.Show();
        }
    }
}
