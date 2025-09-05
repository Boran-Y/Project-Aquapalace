using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace eindProjectAquaPalace
{
    class raportages
    {
        public int id;
        public string beheerderId;
        public string raportagetype;
        public string periode;
        public DateTime aangemaakt;
        public int data;


        public override string ToString()
        {
            return $"{this.id} {this.beheerderId} {this.raportagetype} {this.periode} {this.aangemaakt} {this.data} ";
        }

        public static List<raportages> GetRaportages()
        {
            List<raportages> raportagesList = new List<raportages>();
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT * FROM raportages;";
            MySqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                raportages raportagesobj = new raportages();
                raportagesobj.id = Convert.ToInt32("id");
                raportagesobj.beheerderId = Convert.ToString("beheerderId");
                raportagesobj.raportagetype = Convert.ToString("raportagetype");
                raportagesobj.periode = Convert.ToString("periode");
                raportagesobj.aangemaakt = Convert.ToDateTime("aangemaakt");
                raportagesobj.data = Convert.ToInt32("data");
                raportagesList.Add(raportagesobj);


            }
            con.Close();
            return raportagesList;
        }

    }
}
