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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BlueTeamProject
{
    public partial class AddItemForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-U3Q7T4N\\MSSQLSERVER01;Initial Catalog=DbCowboys;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;

        public AddItemForm()
        {
            InitializeComponent();
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {

        }

        private void ItemIDAddItem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ItemNameAddItem_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void ManufacturerAddItem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ItemQuantityAddItem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MinimumUnitsAddItem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PriceAddItem_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void DescriptionAddItem_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void AddItemAddItem_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (IsMachineAddItem.Checked == true)
            {
                check = 1;
            }

            try {
                con.Open();
                cmd = new SqlCommand("SET IDENTITY_INSERT[dbo].[Item] ON",con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("INSERT INTO item (item_id, item_minimum, item_units, unit_price, manufacturer, item_name, description, isMachine) values('" + ItemIDAddItem.Text + "','" + MinimumUnitsAddItem.Text + "', '" + 1 + "' , '" + PriceAddItem.Text + "', '" + ManufacturerAddItem.Text + "', '" + ItemNameAddItem.Text + "' , '" + DescriptionAddItem.Text + "', '"  + check + "')", con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("SET IDENTITY_INSERT[dbo].[Item] OFF",con);
                cmd.ExecuteNonQuery();

                this.Hide();
                var editCatalog = new EditCatalogueForm();
                editCatalog.FormClosed += (s, args) => this.Close();
                editCatalog.Show();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Inserted Successfully");
                }

            } catch(Exception ez) {
                
                MessageBox.Show(ez.Message);

            }

            con.Close();
            
        }

        private void GoBackAddItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var editCatalog = new EditCatalogueForm();
            editCatalog.FormClosed += (s, args) => this.Close();
            editCatalog.Show();
        }
    }
}
