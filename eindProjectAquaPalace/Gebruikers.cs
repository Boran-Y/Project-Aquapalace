using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;




namespace eindProjectAquaPalace
{
     class Gebruikers
    {
        public int Id;
        public string firstname;
        public string lastname;
        public string email;
        public string username;
        public string password;
        public int admin;
        public string role;

        public static Gebruikers GetLoginGebruiker(string username, string password)
        {
            Gebruikers gebruikersobject = null;
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT * FROM users WHERE user_username = @username";
            myCommand.Parameters.AddWithValue("@username", username);
            MySqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    string bestaandpassword = Convert.ToString(reader["user_password"]);
                    bool isMatch = BCrypt.Net.BCrypt.Verify(password, bestaandpassword);
                    if (isMatch)
                    {
                        gebruikersobject = new Gebruikers();
                        gebruikersobject.Id = Convert.ToInt32(reader["user_id"]);
                        gebruikersobject.username = Convert.ToString(reader["user_username"]);
                        gebruikersobject.password = bestaandpassword;
                        gebruikersobject.firstname = Convert.ToString(reader["user_firstname"]);
                        gebruikersobject.lastname = Convert.ToString(reader["user_lastname"]);
                        gebruikersobject.email = Convert.ToString(reader["user_email"]);
                    }
                }
            }
            con.Close();
            return gebruikersobject;
        }
        public static List<Gebruikers> Userlist()
        {
            List<Gebruikers> Userlist = new List<Gebruikers>();

            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT * FROM users;";

            MySqlDataReader reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                Gebruikers userObject = new Gebruikers();
                userObject.Id = Convert.ToInt32(reader["user_id"]);
                userObject.firstname = Convert.ToString(reader["user_firstname"]);
                userObject.lastname = Convert.ToString(reader["user_lastname"]);
                userObject.email = Convert.ToString(reader["user_email"]);
                userObject.username = Convert.ToString(reader["user_username"]);
                userObject.password = Convert.ToString(reader["user_password"]);
                userObject.admin = Convert.ToInt32(reader["user_admin"]);
                userObject.role = Convert.ToString(reader["user_role"]);
                Userlist.Add(userObject);
            }

            con.Close();

            return Userlist;
        }

        public static string Aantalusers()
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT COUNT(*) FROM users;";
            string aantalusers = myCommand.ExecuteScalar().ToString();
            Console.WriteLine("Aantal users: " + aantalusers);
            con.Close();
            return aantalusers;

        }

        public void Insert()
        {
            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"INSERT INTO users 
                (user_firstname, user_lastname, user_email, user_username, user_password, user_admin, user_role) 
                VALUES (@firstname, @lastname, @user_email, @username, @password, @admin, @role);";

            myCommand.Parameters.AddWithValue("@firstname", this.firstname);
            myCommand.Parameters.AddWithValue("@lastname", this.lastname);
            myCommand.Parameters.AddWithValue("@user_email", this.email);
            myCommand.Parameters.AddWithValue("@username", this.username);
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(this.password);
            myCommand.Parameters.AddWithValue("@password", hashedPassword);
            myCommand.Parameters.AddWithValue("@admin", this.admin);
            myCommand.Parameters.AddWithValue("@role", this.role);

            myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            con.Close();
        }

        public void Update()
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"UPDATE users SET user_firstname = @firstname, user_lastname = @lastname, user_email = @user_email, user_username = @username, user_password = @password, user_admin = @admin, user_role = @role WHERE user_id = @id;";
            myCommand.Parameters.AddWithValue("@id", this.Id);
            myCommand.Parameters.AddWithValue("@firstname", this.firstname);
            myCommand.Parameters.AddWithValue("@lastname", this.lastname);
            myCommand.Parameters.AddWithValue("@user_email", this.email);
            myCommand.Parameters.AddWithValue("@username", this.username);
            // Hash the password before storing it
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(this.password);
            myCommand.Parameters.AddWithValue("@password", hashedPassword);
            myCommand.Parameters.AddWithValue("@admin", this.admin);
            myCommand.Parameters.AddWithValue("@role", this.role);

            myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            con.Close();
        }

        public void Delete()
        {
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"DELETE FROM users WHERE user_id = @id;";
            myCommand.Parameters.AddWithValue("@id", this.Id);
            myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            con.Close();

        }
    }

}

