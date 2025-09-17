using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace eindProjectAquaPalace
{
   class Geschiedenis
    {
        public int GeschiedenisId;
        public int AbonnementId;
        public DateTime Datum;
        public string locatie;


        public override string ToString()
        {
            return $"{this.GeschiedenisId}  {this.AbonnementId} te {this.Datum} Telnr.{this.locatie}";
        }

        public static List<Geschiedenis> GetGeschiedenis(int abonnementId)
        {
            List<Geschiedenis> geschiedenisLijst = new List<Geschiedenis>();
            MySql.Data.MySqlClient.MySqlConnection con = Database.start();
            con.Open();
            MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT * FROM incheckgeschiedenis WHERE abonnement_id = @abonnementId";
            myCommand.Parameters.AddWithValue("@abonnementId", abonnementId);
            MySql.Data.MySqlClient.MySqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    Geschiedenis geschiedenis = new Geschiedenis();
                    geschiedenis.GeschiedenisId = Convert.ToInt32(reader["incheck_id"]);
                    geschiedenis.AbonnementId = Convert.ToInt32(reader["abonnement_id"]);
                    geschiedenis.Datum = Convert.ToDateTime(reader["incheck_datum"]);
                    geschiedenis.locatie = Convert.ToString(reader["locatie"]);
                    geschiedenisLijst.Add(geschiedenis);
                }
            }
            con.Close();
            return geschiedenisLijst;
        }


        public static string incheckDatum()
        {
            MySql.Data.MySqlClient.MySqlConnection con = Database.start();
            con.Open();
            MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT incheck_datum FROM incheckgeschiedenis ORDER BY incheck_datum DESC LIMIT 1";
            string datum = Convert.ToString(myCommand.ExecuteScalar());
            con.Close();
            return datum;
        }

        public static List<Geschiedenis> GetAlleGeschiedenis()
        {
            List<Geschiedenis> geschiedenisLijst = new List<Geschiedenis>();
            MySql.Data.MySqlClient.MySqlConnection con = Database.start();
            con.Open();
            MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT * FROM incheckgeschiedenis";
            MySql.Data.MySqlClient.MySqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    Geschiedenis geschiedenis = new Geschiedenis();
                    geschiedenis.GeschiedenisId = Convert.ToInt32(reader["incheck_id"]);
                    geschiedenis.AbonnementId = Convert.ToInt32(reader["abonnement_id"]);
                    geschiedenis.Datum = Convert.ToDateTime(reader["incheck_datum"]);
                    geschiedenis.locatie = Convert.ToString(reader["locatie"]);
                    geschiedenisLijst.Add(geschiedenis);
                }
            }
            con.Close();
            return geschiedenisLijst;
        }

    }
}
