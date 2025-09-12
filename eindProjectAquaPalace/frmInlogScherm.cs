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
    public partial class frmInlogScherm : Form
    {

        public static frmInlogScherm Instance;
        public string tb1;
        string Firstname = "";
        string Lastname = "";

        public static string GebruikersNaam { get; internal set; }
        public frmInlogScherm()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string hashedpassword = BCrypt.Net.BCrypt.HashPassword("");
            return;
            //met deze functie kan je van wachtworden een bcrypt maken 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string gebruikersnaam = txtUsername.Text;
            string wachtwoord = txtPassword.Text;
            Gebruikers gebruikersobject = Gebruikers.GetLoginGebruiker(gebruikersnaam, wachtwoord);

            if (gebruikersobject != null)
            {
                GebruikersNaam = gebruikersobject.firstname + " " + gebruikersobject.lastname;

                // Verschillende forms openen op basis van rol
                switch (gebruikersobject.role?.ToLower())
                {
                    case "beheerder":
                        frmBeheerderMenu beheerderMenuForm = new frmBeheerderMenu();
                        beheerderMenuForm.Show();
                        break;
                    case "medewerker":
                        frmhoofdmenu hoofdMenuForm = new frmhoofdmenu();
                        hoofdMenuForm.Show();
                        break;
                    case "gast":
                    case "klant":
                        FrmKlanten klantenForm = new FrmKlanten();
                        klantenForm.Show();
                        break;
                    default:
                        MessageBox.Show("Onbekende rol, neem contact op met de beheerder.");
                        return;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ongeldige login");
            }
        }
    }
}
