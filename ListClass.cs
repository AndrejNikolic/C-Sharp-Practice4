using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DomaciZadatak13
{
    class ListClass : Champion
    {
        List<Champion> listChamp;
        string connectString = ConfigurationManager.ConnectionStrings["DomaciZadatak13.Properties.Settings.ChampConnectionString"].ConnectionString;

        public override List<Champion> GetData()
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Champ", connection))
            {
                connection.Open();
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
            return listChamp;
        }
        public override void GetDropdown(ComboBox comboSummoner)
        {
            List<string> myStringList = new List<string>();
            foreach (var item in Connection.listChamp)
            {
                if (!myStringList.Contains(item.Class))
                {
                    myStringList.Add(item.Class);
                }
            }
            comboSummoner.Items.Clear();
            foreach (var item in myStringList)
            {
                comboSummoner.Items.Add(item);
            }
        }

        public override string PrintList()
        {
            return "Name: " + Name + " | Origin: " + Origin + " | Cost: " + Cost;
        }
    }
}
