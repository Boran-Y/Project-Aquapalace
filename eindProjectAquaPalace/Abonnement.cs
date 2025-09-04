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
        public int Id;
        public int CustomerId;
        public int TypeId;
        public DateTime Aankoopdatum;
        public DateTime vervaldatum;
        public string OverigeInfo;
        public string Actief;

        public override string ToString()
        {
            return $"{this.Id}  {this.CustomerId}  {this.TypeId}  {this.Aankoopdatum}  {this.vervaldatum}  {this.OverigeInfo}  {this.Actief}";
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
                abonnementobject.Id = Convert.ToInt32((reader["id"]));
                abonnementobject.CustomerId = Convert.ToInt32((reader["klant_id"]));
                abonnementobject.TypeId = Convert.ToInt32((reader["abonnement_type_id"]));
                abonnementobject.Aankoopdatum = Convert.ToDateTime((reader["aankoop_datum"]));
                abonnementobject.vervaldatum = Convert.ToDateTime((reader["verval_datum"]));
                abonnementobject.OverigeInfo = Convert.ToString(reader["aantal_overige_ritten"]);
                abonnementobject.Actief = Convert.ToString(reader["actief"]);
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
            myCommand.CommandText = @"INSERT INTO `abonnementen` (`klant_id`, `abonnement_type_id`, `aankoop_datum`, `verval_datum`, `aantal_overige_ritten`, `actief`) 
                                      VALUES (@klant_id, @abonnement_type_id, @aankoop_datum, @verval_datum, @aantal_overige_ritten, @actief);";
            myCommand.Parameters.AddWithValue("@klant_id", this.CustomerId);
            myCommand.Parameters.AddWithValue("@abonnement_type_id", this.TypeId);
            myCommand.Parameters.AddWithValue("@aankoop_datum", this.Aankoopdatum);
            myCommand.Parameters.AddWithValue("@verval_datum", this.vervaldatum);
            myCommand.Parameters.AddWithValue("@aantal_overige_ritten", this.OverigeInfo);
            myCommand.Parameters.AddWithValue("@actief", this.Actief);
            myCommand.ExecuteNonQuery();
            con.Close();


        }

        public void EditAbbo()
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"UPDATE `abonnementen` 
                                      SET `klant_id` = @klant_id, 
                                          `abonnement_type_id` = @abonnement_type_id, 
                                          `aankoop_datum` = @aankoop_datum, 
                                          `verval_datum` = @verval_datum, 
                                          `aantal_overige_ritten` = @aantal_overige_ritten, 
                                          `actief` = @actief 
                                      WHERE `id` = @id;";
            myCommand.Parameters.AddWithValue("@id", this.Id);
            myCommand.Parameters.AddWithValue("@klant_id", this.CustomerId);
            myCommand.Parameters.AddWithValue("@abonnement_type_id", this.TypeId);
            // Voorbeeld: nieuw abonnement koppelen aan klant met ID 5
            Abonnement nieuwAbbo = new Abonnement
            {
                CustomerId = 5,
                TypeId = 2, // bijvoorbeeld type 2
                Aankoopdatum = DateTime.Now,
                vervaldatum = DateTime.Now.AddMonths(1),
                OverigeInfo = "Geen",
                Actief = "ja"
            };
            nieuwAbbo.AddAbbo();
            bool status = Abonnement.IsAbonnementActief(10); // Abonnement met ID 10
            if (status)
                Console.WriteLine("Abonnement is actief.");
            else
                Console.WriteLine("Abonnement is niet actief.");
            myCommand.Parameters.AddWithValue("@aankoop_datum", this.Aankoopdatum);
            myCommand.Parameters.AddWithValue("@verval_datum", this.vervaldatum);
            myCommand.Parameters.AddWithValue("@aantal_overige_ritten", this.OverigeInfo);
            myCommand.Parameters.AddWithValue("@actief", this.Actief);
            myCommand.ExecuteNonQuery();
            con.Close();

        }


        public void DeleteAbbo()
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"DELETE FROM `abonnementen` WHERE `id` = @id;";
            myCommand.Parameters.AddWithValue("@id", this.Id);
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
            myCommand.CommandText = @"SELECT actief FROM abonnementen WHERE id = @id;";
            myCommand.Parameters.AddWithValue("@id", abonnementId);
            var result = myCommand.ExecuteScalar();
            if (result != null && result.ToString().ToLower() == "ja")
                actief = true;
            con.Close();
            return actief;
        }

    }
}
