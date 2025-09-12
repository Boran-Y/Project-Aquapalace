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
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }

        private void lbxOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxOverzicht.SelectedItem != null)
            {
                Gebruikers gebruikers = new Gebruikers();
                gebruikers = (Gebruikers)lbxOverzicht.SelectedItem;
                txtGebruikersnaam.Text = gebruikers.Gebruikersnaam;
                txtWachtwoord.Text = gebruikers.WachtwoordHash;
                txtRol.Text = Convert.ToString(gebruikers.Rol);
                if (gebruikers.GekoppeldKlant != null)
                    txtGekoppeld.Text = Convert.ToString(gebruikers.GekoppeldKlant);
                else
                    txtGekoppeld.Text = "";

            }



        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            lbxOverzicht.Items.Clear();
            foreach (Gebruikers UserObject in Gebruikers.Userlist())
            {
                lbxOverzicht.Items.Add(UserObject);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lbxOverzicht.SelectedItems != null)
            {
                ((Gebruikers)lbxOverzicht.SelectedItem).Delete();

            }
            MessageBox.Show(lbxOverzicht.SelectedItem.ToString() + "is verwijderd");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int GebruikerId = char.Parse(txtId.Text);
            string Gebruikersnaam = txtGebruikersnaam.Text;
            string WachtwoordHash = txtWachtwoord.Text;
            GebruikersRol Rol = (GebruikersRol)Enum.Parse(typeof(GebruikersRol), txtRol.Text);
            int? GekoppeldKlant = null;

            Gebruikers UserObject = new Gebruikers();
            UserObject.GebruikerId = GebruikerId;
            UserObject.Gebruikersnaam = Gebruikersnaam;
            UserObject.WachtwoordHash = WachtwoordHash;
            UserObject.Rol = Rol;
            UserObject.GekoppeldKlant = GekoppeldKlant;
            UserObject.Insert();
            MessageBox.Show("Nieuwe gebruiker is aangemaakt");


            txtId.Clear();
            txtGebruikersnaam.Clear();
            txtWachtwoord.Clear();
            txtRol.Clear();
            txtGekoppeld.Clear();
           


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int GebruikerId = char.Parse(txtId.Text);
            string Gebruikersnaam = txtGebruikersnaam.Text;
            string WachtwoordHash = txtWachtwoord.Text;
            GebruikersRol Rol = (GebruikersRol)Enum.Parse(typeof(GebruikersRol), txtRol.Text);
            int? GekoppeldKlant = null;

            Gebruikers UserObject = new Gebruikers();
            UserObject.GebruikerId = GebruikerId;
            UserObject.Gebruikersnaam = Gebruikersnaam;
            UserObject.WachtwoordHash = WachtwoordHash;
            UserObject.Rol = Rol;
            UserObject.GekoppeldKlant = GekoppeldKlant;
            UserObject.Update();
            MessageBox.Show("gebruiker is aangepast");


            txtId.Clear();
            txtGebruikersnaam.Clear();
            txtWachtwoord.Clear();
            txtRol.Clear();
            txtGekoppeld.Clear();
        }
    }
}
