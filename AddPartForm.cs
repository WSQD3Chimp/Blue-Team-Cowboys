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
    public partial class AddPartForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-U3Q7T4N\\MSSQLSERVER01;Initial Catalog=DbCowboys;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;

        public AddPartForm()
        {
            InitializeComponent();
        }

        private void AddPartImage_Click(object sender, EventArgs e)
        {
            //Sebastian can you finish by monday what is missing?

            //Alex here LOVEEEEEEEEEEEEEEE yeah thats the goal :))))))) im 90% sure i can so i should be fine 

            //You can do it not that much

            // yeah thats what i was thinking its pretty short
        }

        private void AddPartForm_Load(object sender, EventArgs e)
        { 
            try
            {
                con.Open();
                cmd = new SqlCommand("SET IDENTITY_INSERT[dbo].[Part_Association] ON", con);
                cmd.ExecuteNonQuery();
                //cmd = new SqlCommand("INSERT INTO item (item_id, isMachine) values('" + ItemIDAddItem.Text + "','" + MinimumUnitsAddItem.Text + "', '" + 1 + "' , '" + PriceAddItem.Text + "', '" + ManufacturerAddItem + "', '" + ItemNameAddItem.Text + "' , '" + DescriptionAddItem.Text + "', '" + check + "')", con);
                //cmd.ExecuteNonQuery();
                cmd = new SqlCommand("SET IDENTITY_INSERT[dbo].[Item] OFF", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA INSERTED :>");

            }
            catch (Exception ez)
            {

                MessageBox.Show(ez.Message);

            }

            con.Close();
        }
    }
}
