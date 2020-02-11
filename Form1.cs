using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DomaciZadatak13
{
    public partial class Form1 : Form
    {
        ListClass champClass;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            champClass = new ListClass();
            Connection.Update(champDataGridView);
            //champClass.GetDropdown(comboBox);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (ChampLinqDataContext dbContext = new ChampLinqDataContext()) 
            {
                var champ = new Champ();
                champ.Name = textBoxIme.Text;
                champ.Origin = textBoxOrigin.Text;
                champ.Class = textBoxClass.Text;
                champ.Cost = Int32.Parse(textBoxCost.Text);

                dbContext.Champs.InsertOnSubmit(champ);
                dbContext.SubmitChanges();
            }

            Connection.Update(champDataGridView);
            //champClass.GetDropdown(comboBox);

        }

        private void comboListBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboListBy.Text == "Origin")
            {
                ListOrigin champOrigin = new ListOrigin();
                champOrigin.GetDropdown(comboBox);
                Console.WriteLine(comboListBy.Text);
            }
            else if (comboListBy.Text == "Class") {
                ListClass champOrigin = new ListClass();
                champOrigin.GetDropdown(comboBox);
            }
            else if (comboListBy.Text == "Cost")
            {
                ListCost champOrigin = new ListCost();
                champOrigin.GetDropdown(comboBox);
            }
        }

        private void findBy_Click(object sender, EventArgs e)
        {
            IEnumerable<Champion> result;

            if (comboListBy.Text == "Origin")
            {
                ListOrigin champOrigin = new ListOrigin();
                listBox1.Items.Clear();
                result = champOrigin.GetData().Where(champ => champ.Origin == comboBox.SelectedItem.ToString());

                try
                {
                    foreach (ListOrigin item in result)
                    {
                        listBox1.Items.Add(item.PrintList());
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please select something");
                }
            }
            else if (comboListBy.Text == "Class")
            {
                listBox1.Items.Clear();
                result = champClass.GetData().Where(champ => champ.Class == comboBox.SelectedItem.ToString());

                try
                {

                    foreach (ListClass item in result)
                    {
                        listBox1.Items.Add(item.PrintList());
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please select something");
                }
            }
            else if (comboListBy.Text == "Cost")
            {
                ListCost champCost = new ListCost();
                listBox1.Items.Clear();
                result = champCost.GetData().Where(champ => champ.Cost == Int32.Parse(comboBox.SelectedItem.ToString()));

                try
                {
                    foreach (ListCost item in result)
                    {
                        listBox1.Items.Add(item.PrintList());
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please select something");
                }
            }
        }
    }
}
