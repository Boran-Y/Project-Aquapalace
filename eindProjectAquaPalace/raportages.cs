using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace eindProjectAquaPalace
{
    class raportages
    {
        public int id;
        public string Titel;
        public string type;
        public string beschrijving;
        public int beheerderId;
        public int aangemaaktDoor;
        public DateTime aangemaakt;
        public string laatsbekeken;




        public override string ToString()
        {
            return $"{this.id} {this.beheerderId} {this.Titel} {this.type} {this.aangemaakt} {this.beschrijving} {this.aangemaaktDoor} {this.aangemaakt} {this.laatsbekeken} ";
        }

        public static List<raportages> GetRaportages()
        {
            List<raportages> raportagesList = new List<raportages>();
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT * FROM raportages;";
            MySqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                raportages raportagesobj = new raportages();
                raportagesobj.id = Convert.ToInt32("id");
                raportagesobj.beheerderId = Convert.ToInt32("beheerder_Id");
                raportagesobj.Titel = Convert.ToString("titel");
                raportagesobj.type = Convert.ToString("type");
                raportagesobj.beschrijving = Convert.ToString("beschrijving");
                raportagesobj.aangemaaktDoor = Convert.ToInt32("aangemaakt_door");
                raportagesobj.aangemaakt = Convert.ToDateTime("aangemaakt_op");
                raportagesobj.laatsbekeken = Convert.ToString("laats_bekeken");
                raportagesList.Add(raportagesobj);





            }
            con.Close();
            return raportagesList;
        }

    }

    class raportageverlooptBinnemaand
    {
        public int Id;
        public string naam;
        public string achternaam;
        public DateTime einddatum;


        public override string ToString()
        {
            return $"{this.Id} {this.naam} {this.achternaam} {this.einddatum}";
        }


        public static List<raportageverlooptBinnemaand> GetAbonnementenVerlooptBinnenMaand()
        {
            List<raportageverlooptBinnemaand> abonnementenlijst = new List<raportageverlooptBinnemaand>();
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT p.klant_id, p.voornaam, p.achternaam, a.einddatum 
                                      FROM klanten p
                                      JOIN abonnementen a ON p.klant_id = a.klant_id
                                      WHERE a.einddatum BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 30 DAY);";
            MySqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                raportageverlooptBinnemaand abonnementobj = new raportageverlooptBinnemaand();
                abonnementobj.Id = Convert.ToInt32(reader["klant_id"]);
                abonnementobj.naam = Convert.ToString(reader["voornaam"]);
                abonnementobj.achternaam = Convert.ToString(reader["achternaam"]);
                abonnementobj.einddatum = Convert.ToDateTime(reader["einddatum"]);
                abonnementenlijst.Add(abonnementobj);
            }
            con.Close();
            return abonnementenlijst;
        }


    }


    public class RapportageIncheck
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string TypeAbonnement { get; set; }
        public DateTime IncheckDatum { get; set; }
        public string Locatie { get; set; }


        public override string ToString()
        {
            return $"{Voornaam} {Achternaam} - {TypeAbonnement} - Incheck Datum: {IncheckDatum} - Locatie: {Locatie}";
        }

        public static List<RapportageIncheck> GetIncheckRapportage()
        {
            List<RapportageIncheck> incheckLijst = new List<RapportageIncheck>();
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"
                SELECT p.voornaam, p.achternaam, a.type_abonnement, ig.incheck_datum, ig.locatie
                FROM klanten p
                JOIN abonnementen a ON p.klant_id = a.klant_id
                JOIN incheckgeschiedenis ig ON a.abonnement_id = ig.abonnement_id
                ORDER BY ig.incheck_datum DESC;";
            MySqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                RapportageIncheck incheckObj = new RapportageIncheck();
                incheckObj.Voornaam = Convert.ToString(reader["voornaam"]);
                incheckObj.Achternaam = Convert.ToString(reader["achternaam"]);
                incheckObj.TypeAbonnement = Convert.ToString(reader["type_abonnement"]);
                incheckObj.IncheckDatum = Convert.ToDateTime(reader["incheck_datum"]);
                incheckObj.Locatie = Convert.ToString(reader["locatie"]);
                incheckLijst.Add(incheckObj);
            }
            con.Close();
            return incheckLijst;
        }
    }
}


