using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Expr;

namespace eindProjectAquaPalace
{
    class Abonnement
    {
        public int AbonnementId;
        public int KlantId;
        public string TypeAbonnement;
        public DateTime Startdatum;
        public DateTime Einddatum;
        public int SaldoRitten;
        public string Status;
        public bool Verlengbaar;
        public DateTime Aanmaakdatum;
        public DateTime LaatsteWijziging;

        public override string ToString()
        {
            return $"{AbonnementId} {KlantId} {TypeAbonnement} {Startdatum} {Einddatum} {SaldoRitten} {Status} {Verlengbaar} {Aanmaakdatum} {LaatsteWijziging}";
        }

        public static List<Abonnement> getAbonnementen()
        {
            List<Abonnement> abonnementlist = new List<Abonnement>();
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT * FROM abonnementen;";
            MySqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                Abonnement abonnementobject = new Abonnement();
                abonnementobject.AbonnementId = Convert.ToInt32(reader["abonnement_id"]);
                abonnementobject.KlantId = Convert.ToInt32(reader["klant_id"]);
                abonnementobject.TypeAbonnement = Convert.ToString(reader["type_abonnement"]);
                abonnementobject.Startdatum = Convert.ToDateTime(reader["startdatum"]);
                abonnementobject.Einddatum = Convert.ToDateTime(reader["einddatum"]);
                abonnementobject.SaldoRitten = Convert.ToInt32(reader["saldo_ritten"]);
                abonnementobject.Status = Convert.ToString(reader["status"]);
                abonnementobject.Verlengbaar = Convert.ToBoolean(reader["verlengbaar"]);
                abonnementobject.Aanmaakdatum = Convert.ToDateTime(reader["aanmaakdatum"]);
                abonnementobject.LaatsteWijziging = Convert.ToDateTime(reader["laatste_wijziging"]);
                abonnementlist.Add(abonnementobject);
            }
            con.Close();
            return abonnementlist;
        }

        public static string aantalAbonnementen()
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT COUNT(*) FROM abonnementen;";
            string aantal = Convert.ToString(myCommand.ExecuteScalar());
            con.Close();
            return aantal;
        }

        public void AddAbbo()
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"INSERT INTO abonnementen 
                (klant_id, type_abonnement, startdatum, einddatum, saldo_ritten, status, verlengbaar, aanmaakdatum, laatste_wijziging) 
                VALUES (@klant_id, @type_abonnement, @startdatum, @einddatum, @saldo_ritten, @status, @verlengbaar, @aanmaakdatum, @laatste_wijziging);";
            myCommand.Parameters.AddWithValue("@klant_id", this.KlantId);
            myCommand.Parameters.AddWithValue("@type_abonnement", this.TypeAbonnement);
            myCommand.Parameters.AddWithValue("@startdatum", this.Startdatum);
            myCommand.Parameters.AddWithValue("@einddatum", this.Einddatum);
            myCommand.Parameters.AddWithValue("@saldo_ritten", this.SaldoRitten);
            myCommand.Parameters.AddWithValue("@status", this.Status);
            myCommand.Parameters.AddWithValue("@verlengbaar", this.Verlengbaar);
            myCommand.Parameters.AddWithValue("@aanmaakdatum", this.Aanmaakdatum);
            myCommand.Parameters.AddWithValue("@laatste_wijziging", this.LaatsteWijziging);
            myCommand.ExecuteNonQuery();
            con.Close();
        }

        public void EditAbbo()
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"UPDATE abonnementen 
                SET klant_id = @klant_id, 
                    type_abonnement = @type_abonnement, 
                    startdatum = @startdatum, 
                    einddatum = @einddatum, 
                    saldo_ritten = @saldo_ritten, 
                    status = @status, 
                    verlengbaar = @verlengbaar, 
                    aanmaakdatum = @aanmaakdatum, 
                    laatste_wijziging = @laatste_wijziging 
                WHERE abonnement_id = @abonnement_id;";
            myCommand.Parameters.AddWithValue("@abonnement_id", this.AbonnementId);
            myCommand.Parameters.AddWithValue("@klant_id", this.KlantId);
            myCommand.Parameters.AddWithValue("@type_abonnement", this.TypeAbonnement);
            myCommand.Parameters.AddWithValue("@startdatum", this.Startdatum);
            myCommand.Parameters.AddWithValue("@einddatum", this.Einddatum);
            myCommand.Parameters.AddWithValue("@saldo_ritten", this.SaldoRitten);
            myCommand.Parameters.AddWithValue("@status", this.Status);
            myCommand.Parameters.AddWithValue("@verlengbaar", this.Verlengbaar);
            myCommand.Parameters.AddWithValue("@aanmaakdatum", this.Aanmaakdatum);
            myCommand.Parameters.AddWithValue("@laatste_wijziging", this.LaatsteWijziging);
            myCommand.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteAbbo()
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"DELETE FROM abonnementen WHERE abonnement_id = @abonnement_id;";
            myCommand.Parameters.AddWithValue("@abonnement_id", this.AbonnementId);
            myCommand.ExecuteNonQuery();
            con.Close();
        }

        public static bool IsAbonnementActief(int abonnementId)
        {
            bool actief = false;
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT status FROM abonnementen WHERE abonnement_id = @abonnement_id;";
            myCommand.Parameters.AddWithValue("@abonnement_id", abonnementId);
            var result = myCommand.ExecuteScalar();
            if (result != null && result.ToString().ToLower() == "actief")
                actief = true;
            con.Close();
            return actief;
        }
    }
}
