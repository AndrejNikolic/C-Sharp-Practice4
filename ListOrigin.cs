﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DomaciZadatak13
{
    class ListOrigin : Champion
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
                    ListOrigin champ = new ListOrigin();
                    champ.Name = rdr["Name"].ToString();
                    champ.Origin = rdr["Origin"].ToString();
                    champ.Class = rdr["Class"].ToString();
                    champ.Cost = Int32.Parse(rdr["Cost"].ToString());

                    listChamp.Add(champ);
                }
            }
            return listChamp;
        }
        public override void GetDropdown(ComboBox comboOrigin)
        {
            List<string> myStringList = new List<string>();
            foreach (var item in Connection.listChamp)
            {
                if (!myStringList.Contains(item.Origin))
                {
                    myStringList.Add(item.Origin);
                }
            }
            comboOrigin.Items.Clear();
            foreach (var item in myStringList)
            {
                comboOrigin.Items.Add(item);
            }
        }

        public override string PrintList()
        {
            return "Name: " + Name + " | Class: " + Class + " | Cost: " + Cost;
        }
    }
}
