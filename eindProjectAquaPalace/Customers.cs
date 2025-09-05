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

        public int Id;
        public string Voorletters;
        public string Achternaam;
        public string Straat;
        public string Postcode;  
        public string Woonplaats;
        public string Telefoon;
        public string email;
        public override string ToString()
        {
            return $"{this.Voorletters}  {this.Achternaam} te {this.Woonplaats} Telnr.{this.Telefoon}";
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
                klantobject.Id = Convert.ToInt32((reader["customer_id"]));
                klantobject.Voorletters = Convert.ToString(reader["customer_firstname"]);
                klantobject.Achternaam = Convert.ToString(reader["customer_lastname"]);
                klantobject.Straat = Convert.ToString((reader["customer_address"]));
                klantobject.Postcode = Convert.ToString((reader["customer_zipcode"]));
                klantobject.Woonplaats = Convert.ToString(reader["customer_city"]);
                klantobject.Telefoon = Convert.ToString(reader["customer_phone"]);
                klantobject.email = Convert.ToString(reader["customer_email"]);
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
        (customer_firstname, customer_lastname, customer_address, customer_zipcode, customer_city, customer_phone, customer_email) 
        VALUES (@Voorletters, @Achternaam, @Straat, @Postcode, @Woonplaats, @Telefoon, @Email);";

            myCommand.Parameters.AddWithValue("@Voorletters", this.Voorletters);
            myCommand.Parameters.AddWithValue("@Achternaam", this.Achternaam);
            myCommand.Parameters.AddWithValue("@Straat", this.Straat);
            myCommand.Parameters.AddWithValue("@Postcode", this.Postcode);
            myCommand.Parameters.AddWithValue("@Woonplaats", this.Woonplaats);
            myCommand.Parameters.AddWithValue("@Telefoon", this.Telefoon);
            myCommand.Parameters.AddWithValue("@Email", this.email);

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
                                SET customer_firstname = @Voorletters,
                                    customer_lastname = @Achternaam,
                                    customer_address = @Straat,
                                    customer_zipcode = @Postcode,
                                    customer_city = @Woonplaats,
                                    customer_phone = @Telefoon,
                                    customer_email = @Email
                                WHERE customer_id = @Id;";

            myCommand.Parameters.AddWithValue("@Voorletters", this.Voorletters);
            myCommand.Parameters.AddWithValue("@Achternaam", this.Achternaam);
            myCommand.Parameters.AddWithValue("@Straat", this.Straat);
            myCommand.Parameters.AddWithValue("@Postcode", this.Postcode);
            myCommand.Parameters.AddWithValue("@Woonplaats", this.Woonplaats);
            myCommand.Parameters.AddWithValue("@Telefoon", this.Telefoon);
            myCommand.Parameters.AddWithValue("@Email", this.email);
            myCommand.Parameters.AddWithValue("@Id", this.Id);

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
            myCommand.CommandText = @"DELETE FROM customers WHERE customer_id = @Id";
            myCommand.Parameters.AddWithValue("@Id", this.Id);
            myCommand.ExecuteNonQuery();

            myCommand.Dispose();
            con.Close();
        }
    }
}
