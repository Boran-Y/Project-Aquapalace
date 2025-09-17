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
    public partial class FrmAbbo : Form
    {
        public Gebruikers gebruikersobject;
        private FrmDashboard frmDashboard;

        public FrmAbbo(Gebruikers gebruikersobject)
        {
            InitializeComponent();
            this.gebruikersobject = gebruikersobject;
        }

        public FrmAbbo(FrmDashboard frmDashboard)
        {
            this.frmDashboard = frmDashboard;
        }

        private void FrmAbbo_Load(object sender, EventArgs e)
        {

<<<<<<< HEAD
=======


            lbxOverzicht.Items.Clear();
            foreach (Abonnement abbonement in Abonnement.getAbonnementen())
            {
                lbxOverzicht.Items.Add(abbonement);
            }


        }

        private void lbxOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(lbxOverzicht.SelectedItem != null)
            {
                Abonnement geslecteerdeAbbo = (Abonnement)lbxOverzicht.SelectedItem;
                txtId.Text = geslecteerdeAbbo.AbonnementId.ToString();
                txtklantId.Text = geslecteerdeAbbo.KlantId.ToString();
                txtAbboTypeId.Text = geslecteerdeAbbo.TypeAbonnement.ToString();
                txtAankoopdatum.Text = geslecteerdeAbbo.Startdatum.ToString();
                txtVervaldatum.Text = geslecteerdeAbbo.Einddatum.ToString();
                txtSaldo.Text = geslecteerdeAbbo.SaldoRitten.ToString();
                txtStatus.Text = geslecteerdeAbbo.Status.ToString();
                txtVerlengbaar.Text = geslecteerdeAbbo.Verlengbaar.ToString();
                txtOverigeRitten.Text = geslecteerdeAbbo.Aanmaakdatum.ToString();    
                txtActief.Text = geslecteerdeAbbo.LaatsteWijziging.ToString();


            }
        }

        private void txtCreate_Click(object sender, EventArgs e)
        {
            int AbbonnementId = int.Parse(txtId.Text);
            int KlantId = int.Parse(txtklantId.Text);
            string TypeAbonnement = txtAbboTypeId.Text;
            DateTime Startdatum = DateTime.Parse(txtAankoopdatum.Text);
            DateTime Einddatum = DateTime.Parse(txtVervaldatum.Text);
            int saldoRitten = int.Parse(txtSaldo.Text);
            string status = txtStatus.Text;
            bool verlengbaar = bool.Parse(txtVerlengbaar.Text);
            DateTime Aanmaakdatum = DateTime.Parse(txtOverigeRitten.Text);
            DateTime LaatsteWijziging = DateTime.Parse(txtActief.Text);
       

           Abonnement abonnement = new Abonnement();
            abonnement.AbonnementId = AbbonnementId;
            abonnement.KlantId = KlantId;
            abonnement.TypeAbonnement = TypeAbonnement.ToString();
            abonnement.Startdatum = Startdatum;
            abonnement.Einddatum = Einddatum;
            abonnement.SaldoRitten = saldoRitten;
            abonnement.Status = status;
            abonnement.Verlengbaar = verlengbaar;
            abonnement.Aanmaakdatum = Aanmaakdatum;
            abonnement.LaatsteWijziging = LaatsteWijziging;
            abonnement.AddAbbo();
            MessageBox.Show("Abonnement is aangemaakt");

            txtId.Clear();
            txtklantId.Clear();
            txtAbboTypeId.Clear();
            txtAankoopdatum.Clear();
            txtVervaldatum.Clear();
            txtSaldo.Clear();
            txtStatus.Clear();
            txtVerlengbaar.Clear();
            txtOverigeRitten.Clear();
            txtActief.Clear();
          


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int AbbonnementId = int.Parse(txtId.Text);
            int KlantId = int.Parse(txtklantId.Text);
           string TypeAbonnement = txtAbboTypeId.Text;
            DateTime Startdatum = DateTime.Parse(txtAankoopdatum.Text);
            DateTime Einddatum = DateTime.Parse(txtVervaldatum.Text);
            int saldoRitten = int.Parse(txtSaldo.Text);
            string status = txtStatus.Text;
            bool verlengbaar = bool.Parse(txtVerlengbaar.Text);
            DateTime Aanmaakdatum = DateTime.Parse(txtOverigeRitten.Text);
            DateTime LaatsteWijziging = DateTime.Parse(txtActief.Text);


            Abonnement abonnement = new Abonnement();
            abonnement.AbonnementId = AbbonnementId;
            abonnement.KlantId = KlantId;
            abonnement.TypeAbonnement = TypeAbonnement.ToString();
            abonnement.Startdatum = Startdatum;
            abonnement.Einddatum = Einddatum;
            abonnement.SaldoRitten = saldoRitten;
            abonnement.Status = status;
            abonnement.Verlengbaar = verlengbaar;
            abonnement.Aanmaakdatum = Aanmaakdatum;
            abonnement.LaatsteWijziging = LaatsteWijziging;
            abonnement.EditAbbo();
            MessageBox.Show("Abonnement is aangepast");

            txtId.Clear();
            txtklantId.Clear();
            txtAbboTypeId.Clear();
            txtAankoopdatum.Clear();
            txtVervaldatum.Clear();
            txtSaldo.Clear();
            txtStatus.Clear();
            txtVerlengbaar.Clear();
            txtOverigeRitten.Clear();
            txtActief.Clear();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbxOverzicht.SelectedItems != null)
            {
                ((Abonnement)lbxOverzicht.SelectedItem).DeleteAbbo();
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
            
            if (Gebruikers == GebruikersRol.Beheerder)
            {
                if(FrmBeheerderMenu.ActiveForm != null)
                {
                    FrmBeheerderMenu.ActiveForm.Show(this);
                }
            }
>>>>>>> 7a2ae1f00963ff4af96b45a935cf0d5a67dd3e3e
        }
    }
}
