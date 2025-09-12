using klantenoverzicht;
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
    public partial class Frmklantenoverzicht : Form
    {
        public Frmklantenoverzicht()
        {
            InitializeComponent();
        }

        // Overzicht knop
        private void overzichtbtn_Click(object sender, EventArgs e)
        {
            List<Persoon> personen = Persoon.GetPersonen();
            lbxoverzicht.Items.Clear();
            foreach (var p in personen)
            {
                lbxoverzicht.Items.Add(p);
            }
        }

        // Verwijder knop
        private void verwijderbtn_Click(object sender, EventArgs e)
        {
            if (lbxoverzicht.SelectedItem is Persoon persoon)
            {
                persoon.Verwijder();
                MessageBox.Show("Persoon verwijderd.");
                overzichtbtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Selecteer een persoon.");
            }
        }

        // Pas aan knop
        private void pasaanbtx_Click(object sender, EventArgs e)
        {
            if (lbxoverzicht.SelectedItem is Persoon persoon)
            {
                persoon.Voornaam = voornaamtxt.Text;
                persoon.Achternaam = achternaamtxt.Text;
                persoon.Adres = adresstxt.Text;
                persoon.Postcode = postcodetxt.Text;
                persoon.Stad = stadtxt.Text;
                persoon.Email = emailtxt.Text;

                persoon.Wijzig();
                MessageBox.Show("Gegevens bijgewerkt.");
                overzichtbtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Selecteer een persoon om aan te passen.");
            }
        }

        private void toevoegbtn_Click(object sender, EventArgs e)
        {
            FrmKlanten klantenForm = new FrmKlanten();
            klantenForm.Show();
            this.Hide(); 
        }
    }
}
