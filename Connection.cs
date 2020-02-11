using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace DomaciZadatak13
{
    public class Connection
    {
        public static List<Champion> listChamp;
        public static void Update(DataGridView champDataGridView)
        {
            string connectString = ConfigurationManager.ConnectionStrings["DomaciZadatak13.Properties.Settings.ChampConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Champ", connection))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Champ", connection))
            {
                connection.Open();
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                champDataGridView.DataSource = dt;

                listChamp = new List<Champion>();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ListClass champ = new ListClass();
                    champ.Name = rdr["Name"].ToString();
                    champ.Origin = rdr["Origin"].ToString();
                    champ.Class = rdr["Class"].ToString();
                    champ.Cost = Int32.Parse(rdr["Cost"].ToString());

                    listChamp.Add(champ);
                }
            }
        }
    }
}
