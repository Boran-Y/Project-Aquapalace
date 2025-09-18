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
        public static Gebruikers loggedInUser;

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
            string hashedpassword = BCrypt.Net.BCrypt.HashPassword("beheerder");
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
                frmInlogScherm.loggedInUser = gebruikersobject;

                // Gebruik de juiste properties uit Gebruikers
                GebruikersNaam = gebruikersobject.Gebruikersnaam;

                // Controleer de rol via enum
                switch (gebruikersobject.Rol)
                {
                    case GebruikersRol.Beheerder:
                        FrmBeheerderMenu beheerderMenuForm = new FrmBeheerderMenu();
                        beheerderMenuForm.Show();
                        break;
                    case GebruikersRol.Medewerker:
                        frmMedewerkerMenu medewerkerMenu = new frmMedewerkerMenu();
                        medewerkerMenu.Show();
                        break;
                    case GebruikersRol.Klant:
                        FrmKlantenMenu klantenForm = new FrmKlantenMenu();
                        klantenForm.Show();
                        break;
                    default:
                        MessageBox.Show("Onbekende rol, neem contact op met de beheerder.");
                        return;
                }
             
            }
            else
            {
                MessageBox.Show("Ongeldige login");
            }
        }
    }
}
