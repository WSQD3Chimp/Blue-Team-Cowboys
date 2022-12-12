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
    public partial class ViewPartsForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-U3Q7T4N\\MSSQLSERVER01;Initial Catalog=DbCowboys;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter sqlDataAdapter;
        DataSet dataSet;

        public ViewPartsForm()
        {
            InitializeComponent();
        }

        private void ViewPartsForm_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("item_id", 100);
            listView1.Columns.Add("machine_id", 100);
            listView1.Columns.Add("item_name", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("maufacturer", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("description", 100, HorizontalAlignment.Center);
            listView1.View = View.Details;

            con.Open();
            cmd = new SqlCommand("SELECT Item.item_id, Part.machine_id, Item.item_name, Item.maufacturer, Item.description FROM Item INNER JOIN Part ON Item.item_id=Part.machine_id;", con);

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
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                i++;

            }
        }
    }
}
