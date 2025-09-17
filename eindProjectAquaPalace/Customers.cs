using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace eindProjectAquaPalace
{
    class Customers
    {
        public int KlantId;
        public string Voornaam;
        public string Achternaam;
        public DateTime Geboortedatum;
        public string Email;
        public string Telefoonnummer;
        public string Adres;
        public string AccountStatus;

        public override string ToString()
        {
            return $"{Voornaam} {Achternaam}, {Email}, {Telefoonnummer}, {Adres}, Status: {AccountStatus}";
        }

        public static List<Customers> getKlanten()
        {
            List<Customers> klantlist = new List<Customers>();
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT * FROM customers;";

            MySqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                Customers klantobject = new Customers();
                klantobject.KlantId = Convert.ToInt32(reader["klant_id"]);
                klantobject.Voornaam = Convert.ToString(reader["voornaam"]);
                klantobject.Achternaam = Convert.ToString(reader["achternaam"]);
                klantobject.Geboortedatum = Convert.ToDateTime(reader["geboortedatum"]);
                klantobject.Email = Convert.ToString(reader["email"]);
                klantobject.Telefoonnummer = Convert.ToString(reader["telefoonnummer"]);
                klantobject.Adres = Convert.ToString(reader["adres"]);
                klantobject.AccountStatus = Convert.ToString(reader["account_status"]);
                klantlist.Add(klantobject);
            }
            con.Close();
            return klantlist;
        }

        public static string aantalKlanten()
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT COUNT(*) FROM customers;";
            string aantalKlanten = myCommand.ExecuteScalar().ToString();
            con.Close();
            return aantalKlanten;
        }

        public void Toevoegen()
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"INSERT INTO customers 
                (voornaam, achternaam, geboortedatum, email, telefoonnummer, adres, account_status) 
                VALUES (@Voornaam, @Achternaam, @Geboortedatum, @Email, @Telefoonnummer, @Adres, @AccountStatus);";

            myCommand.Parameters.AddWithValue("@Voornaam", this.Voornaam);
            myCommand.Parameters.AddWithValue("@Achternaam", this.Achternaam);
            myCommand.Parameters.AddWithValue("@Geboortedatum", this.Geboortedatum);
            myCommand.Parameters.AddWithValue("@Email", this.Email);
            myCommand.Parameters.AddWithValue("@Telefoonnummer", this.Telefoonnummer);
            myCommand.Parameters.AddWithValue("@Adres", this.Adres);
            myCommand.Parameters.AddWithValue("@AccountStatus", this.AccountStatus);

            myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            con.Close();
        }

        public void Wijzigen()
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"UPDATE customers
                SET voornaam = @Voornaam,
                    achternaam = @Achternaam,
                    geboortedatum = @Geboortedatum,
                    email = @Email,
                    telefoonnummer = @Telefoonnummer,
                    adres = @Adres,
                    account_status = @AccountStatus
                WHERE klant_id = @KlantId;";

            myCommand.Parameters.AddWithValue("@Voornaam", this.Voornaam);
            myCommand.Parameters.AddWithValue("@Achternaam", this.Achternaam);
            myCommand.Parameters.AddWithValue("@Geboortedatum", this.Geboortedatum);
            myCommand.Parameters.AddWithValue("@Email", this.Email);
            myCommand.Parameters.AddWithValue("@Telefoonnummer", this.Telefoonnummer);
            myCommand.Parameters.AddWithValue("@Adres", this.Adres);
            myCommand.Parameters.AddWithValue("@AccountStatus", this.AccountStatus);
            myCommand.Parameters.AddWithValue("@KlantId", this.KlantId);

            myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            con.Close();
        }

        public void verwijder()
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"DELETE FROM customers WHERE klant_id = @KlantId";
            myCommand.Parameters.AddWithValue("@KlantId", this.KlantId);
            myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            con.Close();
        }
    }
}
