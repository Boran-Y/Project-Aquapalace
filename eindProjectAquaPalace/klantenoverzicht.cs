using eindProjectAquaPalace;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace klantenoverzicht
{
    public class Persoon
    {
        public int Id;
        public string Voornaam;
        public string Achternaam;
        public string Adres;
        public string Postcode;
        public string Stad;
        public string Email;

        // Ophalen uit DB
        public static List<Persoon> GetPersonen()
        {
            List<Persoon> lijst = new List<Persoon>();
            MySqlConnection con = Database.start();
            con.Open();

            string sql = "SELECT * FROM personen;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Persoon p = new Persoon();
                p.Id = Convert.ToInt32(reader["id"]);
                p.Voornaam = Convert.ToString(reader["voornaam"]);
                p.Achternaam = Convert.ToString(reader["achternaam"]);
                p.Adres = Convert.ToString(reader["adres"]);
                p.Postcode = Convert.ToString(reader["postcode"]);
                p.Stad = Convert.ToString(reader["stad"]);
                p.Email = Convert.ToString(reader["email"]);
                lijst.Add(p);
            }

            con.Close();
            return lijst;
        }

        // Verwijderen
        public void Verwijder()
        {
            MySqlConnection con = Database.start();
            con.Open();

            string sql = "DELETE FROM personen WHERE id = @id;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        // Wijzigen
        public void Wijzig()
        {
            MySqlConnection con = Database.start();
            con.Open();

            string sql = @"UPDATE personen 
                           SET voornaam=@voornaam, achternaam=@achternaam, adres=@adres, 
                               postcode=@postcode, stad=@stad, email=@email 
                           WHERE id=@id;";

            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@voornaam", Voornaam);
            cmd.Parameters.AddWithValue("@achternaam", Achternaam);
            cmd.Parameters.AddWithValue("@adres", Adres);
            cmd.Parameters.AddWithValue("@postcode", Postcode);
            cmd.Parameters.AddWithValue("@stad", Stad);
            cmd.Parameters.AddWithValue("@email", Email);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public override string ToString()
        {
            return $"{Voornaam} {Achternaam} ({Email})";
        }
    }
}
