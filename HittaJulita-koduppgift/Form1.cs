using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HittaJulita_koduppgift
{
    public partial class Form1 : Form
    {

        List<Adress> adresses = new List<Adress>();
        public Form1()
        {
            /*Ändra filepath till inputfilen*/
            string[] lines = File.ReadAllLines(@"C:\Users\alans\source\repos\HittaJulita-koduppgift\HittaJulita-koduppgift\input.txt");

            foreach (string line in lines)
            {
                string[] field = line.Split(';');
                adresses.Add(new Adress(field[0].ToLower(), field[1].ToLower(), field[2].ToLower()));
            }

            /* Tar bort första raden i textfilen */
            adresses.RemoveAt(0);
            InitializeComponent();
        }

        public void Search(string streetName, string zip, bool streetContains, bool zipContains, bool and, bool or)
        {

            for (int i = 0; i < adresses.Count; i++)
            {
                
                if(!and && !or && zip == ";" && !streetContains)
                {
                    if (adresses[i].StreetName == streetName){
                        dataGridView1.Rows.Add(adresses[i].StreetName, adresses[i].Zip, adresses[i].City);
                    }
                }
                else if (!and && !or && streetName == ";" && !zipContains)
                {
                    if (adresses[i].Zip == zip)
                    {
                        dataGridView1.Rows.Add(adresses[i].StreetName, adresses[i].Zip, adresses[i].City);
                    }
                }
                else if (!and && !or && zip == ";" && streetContains)
                {
                    if (adresses[i].StreetName.Contains(streetName))
                    {
                        dataGridView1.Rows.Add(adresses[i].StreetName, adresses[i].Zip, adresses[i].City);
                    }
                }
                else if (!and && !or && streetName == ";" && zipContains)
                {
                    if (adresses[i].Zip.Contains(zip))
                    {
                        dataGridView1.Rows.Add(adresses[i].StreetName, adresses[i].Zip, adresses[i].City);
                    }
                }

                else if (streetContains && or && zipContains)
                {
                    if (adresses[i].StreetName.Contains(streetName) || adresses[i].Zip.Contains(zip))
                    {
                        dataGridView1.Rows.Add(adresses[i].StreetName, adresses[i].Zip, adresses[i].City);
                    }
                }
                else if (streetContains && or && !zipContains)
                {
                    if (adresses[i].StreetName.Contains(streetName) || adresses[i].Zip == zip)
                    {
                        dataGridView1.Rows.Add(adresses[i].StreetName, adresses[i].Zip, adresses[i].City);
                    }
                }
                else if (!streetContains && or && zipContains)
                {
                    if (adresses[i].StreetName == streetName || adresses[i].Zip.Contains(zip))
                    {
                        dataGridView1.Rows.Add(adresses[i].StreetName, adresses[i].Zip, adresses[i].City);
                    }
                }
                else if (!streetContains && or && !zipContains)
                {
                    if (adresses[i].StreetName == streetName || adresses[i].Zip == zip)
                    {
                        dataGridView1.Rows.Add(adresses[i].StreetName, adresses[i].Zip, adresses[i].City);
                    }
                }
                else if (streetContains && and && zipContains)
                {
                    if (adresses[i].StreetName.Contains(streetName) && adresses[i].Zip.Contains(zip))
                    {

                        dataGridView1.Rows.Add(adresses[i].StreetName, adresses[i].Zip, adresses[i].City);
                    }
                }
                else if (streetContains && and && !zipContains)
                {
                    if (adresses[i].StreetName.Contains(streetName) && adresses[i].Zip == zip)
                    {
                        dataGridView1.Rows.Add(adresses[i].StreetName, adresses[i].Zip, adresses[i].City);
                    }
                }
                else if (!streetContains && and && zipContains)
                {
                    if (adresses[i].StreetName == streetName && adresses[i].Zip.Contains(zip))
                    {
                        dataGridView1.Rows.Add(adresses[i].StreetName, adresses[i].Zip, adresses[i].City);
                    }
                }

                else if (!streetContains && or && !zipContains)
                {
                    if (adresses[i].StreetName == streetName && adresses[i].Zip == zip)
                    {
                        dataGridView1.Rows.Add(adresses[i].StreetName, adresses[i].Zip, adresses[i].City);
                    }
                }
            }
     
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void search_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (streetName.Text == "")
            {
                streetName.Text += ";";
            }
            if (zip.Text == "")
            {
                zip.Text += ";";
            }
            Search(streetName.Text, zip.Text, contains.Checked, contains1.Checked, and.Checked, or.Checked);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void streetName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
