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

        }

        private void cbxAbbo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmKlanten_Load(object sender, EventArgs e)
        {

        }

        private void btnVerzend_Click(object sender, EventArgs e)
        {
            int klantId = int.Parse(txtId.Text);
            string voornaam = txtVoornaam.Text;
            string achternaam = txtAchternaam.Text;
            string email = txtEmail.Text;
            string telefoonnummer = txtTel.Text;
            string adres = txtAdres.Text;
            DateTime geboortedatum = DateTime.Parse(txtGeboorte.Text);
            string accountstatus = txtActief.Text;

            Customers customers = new Customers();
            customers.KlantId = klantId;
            customers.Voornaam = voornaam;
            customers.Achternaam = achternaam;
            customers.Email = email;
            customers.Telefoonnummer = telefoonnummer;
            customers.Adres = adres;
            customers.Geboortedatum = geboortedatum;
            customers.AccountStatus = accountstatus;
            customers.Toevoegen();
            MessageBox.Show("Klant toegevoegd");
            // Hier zou je de code toevoegen om het 'customers' object op te slaan in de database
        }
    }
}
