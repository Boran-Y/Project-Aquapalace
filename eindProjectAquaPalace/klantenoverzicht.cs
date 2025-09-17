using eindProjectAquaPalace;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace klantenoverzicht
{
    public class Persoon
    {
        public int KlantId;
        public string Voornaam;
        public string Achternaam;
        public DateTime Geboortedatum;
        public string Email;
        public string Telefoonnummer;
        public string Adres;
        public string AccountStatus;

        public static List<Persoon> GetPersonen()
        {
            List<Persoon> lijst = new List<Persoon>();
            MySqlConnection con = Database.start();
            con.Open();

            string sql = "SELECT * FROM klanten;"; // tabel: klanten
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Persoon p = new Persoon();
                p.KlantId = Convert.ToInt32(reader["klant_id"]);
                p.Voornaam = Convert.ToString(reader["voornaam"]);
                p.Achternaam = Convert.ToString(reader["achternaam"]);
                p.Geboortedatum = Convert.ToDateTime(reader["geboortedatum"]);
                p.Email = Convert.ToString(reader["email"]);
                p.Telefoonnummer = Convert.ToString(reader["telefoonnummer"]);
                p.Adres = Convert.ToString(reader["adres"]);
                p.AccountStatus = Convert.ToString(reader["account_status"]);
                lijst.Add(p);
            }

            con.Close();
            return lijst;
        }

        public void Verwijder()
        {
            MySqlConnection con = Database.start();
            con.Open();

            string sql = "DELETE FROM klanten WHERE klant_id = @id;";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", KlantId);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void Wijzig()
        {
            MySqlConnection con = Database.start();
            con.Open();

            string sql = @"UPDATE klanten 
                       SET voornaam=@voornaam, 
                           achternaam=@achternaam, 
                           geboortedatum=@geboortedatum, 
                           email=@email, 
                           telefoonnummer=@telefoonnummer, 
                           adres=@adres, 
                           account_status=@status
                       WHERE klant_id=@id;";

            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", KlantId);
            cmd.Parameters.AddWithValue("@voornaam", Voornaam);
            cmd.Parameters.AddWithValue("@achternaam", Achternaam);
            cmd.Parameters.AddWithValue("@geboortedatum", Geboortedatum);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@telefoonnummer", Telefoonnummer);
            cmd.Parameters.AddWithValue("@adres", Adres);
            cmd.Parameters.AddWithValue("@status", AccountStatus);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public override string ToString()
        {
            return $"{Voornaam} {Achternaam} ({Email}, {AccountStatus})";
        }
    }
}
