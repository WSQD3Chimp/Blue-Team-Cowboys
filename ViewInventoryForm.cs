﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.Reflection;

namespace BlueTeamProject
{
    public partial class ViewInventoryForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-U3Q7T4N\\MSSQLSERVER01;Initial Catalog=DbCowboys;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter sqlDataAdapter;
        DataSet dataSet;

        public ViewInventoryForm()
        {
            InitializeComponent();
        }

        private void ViewInventoryListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Int32.Parse(ViewInventoryListView.SelectedItems[0].Text);
            ViewItemForm viewitem = new ViewItemForm(id);
            viewitem.Show();
        }

        private void ViewInventoryForm_Load(object sender, EventArgs e)
        {
            ViewInventoryListView.Columns.Add("item_id", 100);
            ViewInventoryListView.Columns.Add("item_name", 100, HorizontalAlignment.Center);
            ViewInventoryListView.Columns.Add("description", 100, HorizontalAlignment.Center);
            ViewInventoryListView.View = View.Details;

            con.Open();
            cmd = new SqlCommand("select * from Item", con);

            sqlDataAdapter = new SqlDataAdapter(cmd);
            dataSet = new DataSet();

            sqlDataAdapter.Fill(dataSet, "data");

            con.Close();
            dt = dataSet.Tables["data"];
            int i = 0;

            while (i <= dt.Rows.Count - 1)
            {
                ViewInventoryListView.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                ViewInventoryListView.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                ViewInventoryListView.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                i++;
            }

        }

        private void GoBackViewInventory_Click(object sender, EventArgs e)
        {
            MainMenuForm m1 = new MainMenuForm(true);
            m1.Show();
        }

        private void EditCatalogue_Click(object sender, EventArgs e)
        {
            EditCatalogueForm editCatalogue = new EditCatalogueForm();
            editCatalogue.Show();
        }
    }
}
