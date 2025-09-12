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

            public static List<Persoon> GetPersonen()
            {
                List<Persoon> lijst = new List<Persoon>();
                MySqlConnection con = Database.start();
                con.Open();

                string sql = "SELECT * FROM customers;"; // tabelnaam aannemen: klanten
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Persoon p = new Persoon();
                    p.Id = Convert.ToInt32(reader["customer_id"]);
                    p.Voornaam = Convert.ToString(reader["customer_firstname"]);
                    p.Achternaam = Convert.ToString(reader["customer_lastname"]);
                    p.Adres = Convert.ToString(reader["customer_address"]);
                    p.Postcode = Convert.ToString(reader["customer_zipcode"]);
                    p.Stad = Convert.ToString(reader["customer_city"]);
                    p.Email = Convert.ToString(reader["customer_email"]);
                    lijst.Add(p);
                }

                con.Close();
                return lijst;
            }

            public void Verwijder()
            {
                MySqlConnection con = Database.start();
                con.Open();

                string sql = "DELETE FROM klanten WHERE customer_id = @id;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();

                con.Close();
            }

            public void Wijzig()
            {
                MySqlConnection con = Database.start();
                con.Open();

                string sql = @"UPDATE klanten 
                       SET customer_firstname=@voornaam, 
                           customer_lastname=@achternaam, 
                           customer_address=@adres, 
                           customer_zipcode=@postcode, 
                           customer_city=@stad, 
                           customer_email=@email 
                       WHERE customer_id=@id;";

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

