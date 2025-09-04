using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace eindProjectAquaPalace
{
     class transacties
    {
        public int id;
        public int customer_id;
        public int abonnement_type_id;
        public DateTime transactie_datum;
        public int bedrag;
        public string betaalmethode;
        public string status;

        public override string ToString()
        {
            return $"{this.customer_id} {this.abonnement_type_id} {this.transactie_datum} {this.bedrag} {this.betaalmethode} {this.status} ";

        }

        public static List<transacties> GetTransacties()
        {
            List<transacties> transactiesList = new List<transacties>();
            MySqlConnection con = Database.start();
            con.Open();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = con;
            myCommand.CommandText = @"SELECT * FROM transacties;";
            MySqlDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                transacties transactiesobj = new transacties();
                transactiesobj.id = Convert.ToInt32("id");
                transactiesobj.customer_id = Convert.ToInt32("customer_id");
                transactiesobj.abonnement_type_id = Convert.ToInt32("abonnement_type_id");
                transactiesobj.transactie_datum = Convert.ToDateTime("transactie_datum");
                transactiesobj.bedrag = Convert.ToInt32("bedrag");
                transactiesobj.betaalmethode = Convert.ToString("betaalmethode");




            }






        }
    }
}
