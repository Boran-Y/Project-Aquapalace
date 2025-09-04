using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace eindProjectAquaPalace
{
     class abbonementtype
    {
        public int id;
        public string name;
        public string description;
        public int price;
        public DateTime validty;
        public int number_of_entries;

        public override string ToString()
        {
            return $"{this.id}  {this.name}  {this.description}  {this.price}  {this.validty}  {this.number_of_entries}";
        }

        public static List<abbonementtype> Getabbonementtype()
        {
            List<abbonementtype> abbonementtypes = new List<abbonementtype>();
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = "SELECT * FROM subscription_types";
            MySqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                abbonementtype abbonementtype = new abbonementtype();
                abbonementtype.id = reader.GetInt32("id");
                abbonementtype.name = reader.GetString("name");
                abbonementtype.description = reader.GetString("description");
                abbonementtype.price = reader.GetInt32("price");
                abbonementtype.validty = reader.GetDateTime("validty");
                abbonementtype.number_of_entries = reader.GetInt32("number_of_entries");
                abbonementtypes.Add(abbonementtype);


            }
            con.Close();
            return abbonementtypes;







        }

        public static string aantalabbonementtype()
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = "SELECT COUNT(*) FROM subscription_types";
            string count = myCommand.ExecuteScalar().ToString();
            con.Close();
            return count;
        }

        public static void Addabbonementtype(string name, string description, int price, DateTime validty, int number_of_entries)
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = "INSERT INTO subscription_types (name, description, price, validty, number_of_entries) VALUES (@name, @description, @price, @validty, @number_of_entries)";
            myCommand.Parameters.AddWithValue("@name", name);
            myCommand.Parameters.AddWithValue("@description", description);
            myCommand.Parameters.AddWithValue("@price", price);
            myCommand.Parameters.AddWithValue("@validty", validty);
            myCommand.Parameters.AddWithValue("@number_of_entries", number_of_entries);
            myCommand.ExecuteNonQuery();
            con.Close();
        }
        public static List<abbonementtype> FilterAbbonementTypes(string name = null, int? price = null)
        {
            List<abbonementtype> abbonementtypes = new List<abbonementtype>();
            MySqlConnection con = Database.start();
            con.Open();
            StringBuilder query = new StringBuilder("SELECT * FROM subscription_types WHERE 1=1");
            if (!string.IsNullOrEmpty(name))
                query.Append(" AND name = @name");
            if (price.HasValue)
                query.Append(" AND price = @price");

            MySqlCommand myCommand = new MySqlCommand(query.ToString(), con);
            if (!string.IsNullOrEmpty(name))
                myCommand.Parameters.AddWithValue("@name", name);
            if (price.HasValue)
                myCommand.Parameters.AddWithValue("@price", price.Value);

            MySqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                abbonementtype abbonementtype = new abbonementtype();
                abbonementtype.id = reader.GetInt32("id");
                abbonementtype.name = reader.GetString("name");
                abbonementtype.description = reader.GetString("description");
                abbonementtype.price = reader.GetInt32("price");
                abbonementtype.validty = reader.GetDateTime("validty");
                abbonementtype.number_of_entries = reader.GetInt32("number_of_entries");
                abbonementtypes.Add(abbonementtype);
            }
            con.Close();
            return abbonementtypes;
        }


    }

}
