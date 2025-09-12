using eindProjectAquaPalace;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

public enum GebruikersRol
{
    Beheerder,
    Medewerker,
    Klant
}

class Gebruikers
{
    public int GebruikerId;
    public string Gebruikersnaam;
    public string WachtwoordHash;
    public GebruikersRol Rol;
    public int? GekoppeldKlant; // Nullable, indien niet altijd gekoppeld

    public static Gebruikers GetLoginGebruiker(string gebruikersnaam, string wachtwoord)
    {
        Gebruikers gebruikersobject = null;
        MySqlConnection con = Database.start();
        con.Open();
        MySqlCommand myCommand = new MySqlCommand();
        myCommand.Connection = con;
        myCommand.CommandText = @"SELECT * FROM users WHERE gebruikersnaam = @gebruikersnaam";
        myCommand.Parameters.AddWithValue("@gebruikersnaam", gebruikersnaam);
        MySqlDataReader reader = myCommand.ExecuteReader();
        while (reader.Read())
        {
            if (reader.HasRows)
            {
                string bestaandHash = Convert.ToString(reader["wachtwoord_hash"]);
                bool isMatch = BCrypt.Net.BCrypt.Verify(wachtwoord, bestaandHash);
                if (isMatch)
                {
                    gebruikersobject = new Gebruikers();
                    gebruikersobject.GebruikerId = Convert.ToInt32(reader["gebruiker_id"]);
                    gebruikersobject.Gebruikersnaam = Convert.ToString(reader["gebruikersnaam"]);
                    gebruikersobject.WachtwoordHash = bestaandHash;
                    string dbRol = Convert.ToString(reader["rol"]);
                    if (Enum.TryParse(dbRol, true, out GebruikersRol parsedRol))
                        gebruikersobject.Rol = parsedRol;
                    else
                        gebruikersobject.Rol = GebruikersRol.Klant;
                    if (reader["gekoppeld_klant"] != DBNull.Value)
                        gebruikersobject.GekoppeldKlant = Convert.ToInt32(reader["gekoppeld_klant"]);
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
            userObject.GebruikerId = Convert.ToInt32(reader["gebruiker_id"]);
            userObject.Gebruikersnaam = Convert.ToString(reader["gebruikersnaam"]);
            userObject.WachtwoordHash = Convert.ToString(reader["wachtwoord_hash"]);
            string dbRol = Convert.ToString(reader["rol"]);
            if (Enum.TryParse(dbRol, true, out GebruikersRol parsedRol))
                userObject.Rol = parsedRol;
            else
                userObject.Rol = GebruikersRol.Klant;
            if (reader["gekoppeld_klant"] != DBNull.Value)
                userObject.GekoppeldKlant = Convert.ToInt32(reader["gekoppeld_klant"]);
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
            (gebruikersnaam, wachtwoord_hash, rol, gekoppeld_klant) 
            VALUES (@gebruikersnaam, @wachtwoord_hash, @rol, @gekoppeld_klant);";
        myCommand.Parameters.AddWithValue("@gebruikersnaam", this.Gebruikersnaam);
        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(this.WachtwoordHash);
        myCommand.Parameters.AddWithValue("@wachtwoord_hash", hashedPassword);
        myCommand.Parameters.AddWithValue("@rol", this.Rol.ToString());
        if (this.GekoppeldKlant.HasValue)
            myCommand.Parameters.AddWithValue("@gekoppeld_klant", this.GekoppeldKlant.Value);
        else
            myCommand.Parameters.AddWithValue("@gekoppeld_klant", DBNull.Value);
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
        myCommand.CommandText = @"UPDATE users SET gebruikersnaam = @gebruikersnaam, wachtwoord_hash = @wachtwoord_hash, rol = @rol, gekoppeld_klant = @gekoppeld_klant WHERE gebruiker_id = @gebruiker_id;";
        myCommand.Parameters.AddWithValue("@gebruiker_id", this.GebruikerId);
        myCommand.Parameters.AddWithValue("@gebruikersnaam", this.Gebruikersnaam);
        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(this.WachtwoordHash);
        myCommand.Parameters.AddWithValue("@wachtwoord_hash", hashedPassword);
        myCommand.Parameters.AddWithValue("@rol", this.Rol.ToString());
        if (this.GekoppeldKlant.HasValue)
            myCommand.Parameters.AddWithValue("@gekoppeld_klant", this.GekoppeldKlant.Value);
        else
            myCommand.Parameters.AddWithValue("@gekoppeld_klant", DBNull.Value);
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
        myCommand.CommandText = @"DELETE FROM users WHERE gebruiker_id = @gebruiker_id;";
        myCommand.Parameters.AddWithValue("@gebruiker_id", this.GebruikerId);
        myCommand.ExecuteNonQuery();
        myCommand.Dispose();
        con.Close();
    }
}
