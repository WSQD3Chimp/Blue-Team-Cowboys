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
    public partial class ViewItemForm : Form 
    {
        SqlCommand cmd;
        int id;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-U3Q7T4N\\MSSQLSERVER01;Initial Catalog=DbCowboys;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        bool isIncremented = false;
        bool isDecremented = false;

        public ViewItemForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ViewItemForm_Load(object sender, EventArgs e)
        {

            DBController.Connect();
            cmd = new SqlCommand("select * from Item where item_id=" + id, con);
            con.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while(reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var itemMinimum = reader.GetDecimal(1);
                    var itemUnits = reader.GetDecimal(2);
                    var unitPrice = reader.GetDecimal(3);
                    var manufacturer = reader.GetString(4);
                    var itemName = reader.GetString(5);
                    var desc = reader.GetString(6);
                    var is_Machine = reader.GetBoolean(7);

                    FlyingValueAddItem.Text = itemUnits.ToString();

                    ItemIDText.Text = id.ToString();
                    NameText.Text = itemName.ToString();
                    ManufacturerText.Text = manufacturer.ToString();
                    QuantityText.Text = itemUnits.ToString();
                    PriceUnitText.Text = unitPrice.ToString();
                    DescriptionText.Text = desc.ToString();


                }
            }
            con.Close();
        }

        private void ViewPartsViewItem_Click(object sender, EventArgs e)
        {
            ViewPartsForm viewParts = new ViewPartsForm();
            viewParts.Show();
        }

        private void GoBackViewItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var vI = new ViewInventoryForm();
            vI.FormClosed += (s, args) => this.Close();
            vI.Show();
        }

        private void DecrementViewItem_Click(object sender, EventArgs e)
        {
            decimal newval = decimal.Parse(FlyingValueAddItem.Text);
            FlyingValueAddItem.Text = "" + (newval - 1);
            isDecremented= true;
        }

        private void EditItemViewItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var eI = new EditItemForm(id);
            eI.FormClosed += (s, args) => this.Close();
            eI.Show();
        }

        private void IncrementViewItem_Click(object sender, EventArgs e)
        {
            decimal newval = decimal.Parse(FlyingValueAddItem.Text);
            FlyingValueAddItem.Text = "" + (newval + 1);
            isIncremented = true;
        }

        private void FlyingValueAddItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveChangesViewItem_Click(object sender, EventArgs e)
        {
            if(isIncremented == true)
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Update item set item_units= '" + FlyingValueAddItem.Text + "'where item_id=" + id, con);
                    cmd.ExecuteNonQuery();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Updated Successfully");
                    }
                    con.Close();
                    this.Hide();
                    var vIF = new ViewItemForm(id);
                    vIF.FormClosed += (s, args) => this.Close();
                    vIF.Show();

                }
                catch (Exception ez)
                {

                    MessageBox.Show(ez.Message);

                }
            }else if (isDecremented == true)
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Update item set item_units= '" + FlyingValueAddItem.Text + "'where item_id=" + id, con);
                    cmd.ExecuteNonQuery();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Updated Successfully");
                    }
                    con.Close();
                    this.Hide();
                    var vIF = new ViewItemForm(id);
                    vIF.FormClosed += (s, args) => this.Close();
                    vIF.Show();

                }
                catch (Exception ez)
                {

                    MessageBox.Show(ez.Message);

                }
            }
            
        }
    }
}
