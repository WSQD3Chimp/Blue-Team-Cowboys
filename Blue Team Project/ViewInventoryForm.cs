using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BlueTeamProject
{
    public partial class ViewInventoryForm : UserControl
    {
        public static ViewInventoryForm instance;
        public ListView lv1;
        SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=Inventory_POS;Intergrated Security=True ");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter sqlDataAdapter;
        DataSet dataSet;

        public ViewInventoryForm()
        {
            InitializeComponent();
            instance= this;
            lv1 = listView1;
        }

        private void ViewInventoryForm_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("item_id", 100);
            listView1.Columns.Add("item_name", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("description", 100, HorizontalAlignment.Center);
            listView1.View = View.Details;

            con.Open();
            cmd = new SqlCommand("select * from DbCowboys", con);

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
            }

            if (listView1.SelectedItems != null)
            {
                //View
                ViewItemForm viewItem = new ViewItemForm();
                viewItem.Show();
            }
            //Remove(listView1.SelectedItems[0])
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
