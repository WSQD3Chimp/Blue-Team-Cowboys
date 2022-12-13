using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueTeamProject
{
    public partial class EditCatalogueForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-U3Q7T4N\\MSSQLSERVER01;Initial Catalog=DbCowboys;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter sqlDataAdapter;
        DataSet dataSet;

        public EditCatalogueForm()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
        }

        private void EditCatalogueForm_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("item_id", 100);
            listView1.Columns.Add("item_name", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("manufacturer", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("description", 100, HorizontalAlignment.Center);
            listView1.View = View.Details;

            con.Open();
            cmd = new SqlCommand("select item_id, item_name, manufacturer, description from Item;", con);

            sqlDataAdapter = new SqlDataAdapter(cmd);
            dataSet = new DataSet();

            sqlDataAdapter.Fill(dataSet, "data");

            con.Close();
            dt = dataSet.Tables["data"];
            int i = 0;

            while (i <= dt.Rows.Count - 1)
            {
                listView1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                i++;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddItemCatalogue_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addItem = new AddItemForm();
            addItem.FormClosed += (s, args) => this.Close();
            addItem.Show();
        }

        private void DeleteItemsCatalogue_Click(object sender, EventArgs e)
        {
                try
                {
                    int item = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                    con.Open();
                    cmd = new SqlCommand("Delete Item where item_id = " + item, con);
                    cmd.ExecuteNonQuery();
                    if(MessageBox.Show("are you sure you wish to delete?", "DELETE",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
                    {
                        if(cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Deleted Successfully");

                            listView1.CheckedItems[0].Remove();
                        }
                    }
                }
                catch(Exception ez)
                {
                    MessageBox.Show(ez.Message);
                }
            con.Close();

        }

        private void GoBackEditCatalogue_Click(object sender, EventArgs e)
        {
            this.Hide();
            var v1 = new ViewInventoryForm();
            v1.FormClosed += (s, args) => this.Close();
            v1.Show();
        }
    }
}
