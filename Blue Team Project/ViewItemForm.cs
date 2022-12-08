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
    public partial class ViewItemForm : UserControl
    {
        public static ViewItemForm instance;
        SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=Inventory_POS;Intergrated Security=True ");
        SqlCommand cmd;
        String currentId;
        SqlDataAdapter sqlDataAdapter;
        DataSet dataSet;

        public ViewItemForm()
        {
            InitializeComponent();
            instance = this;
            currentId = ViewInventoryForm.instance.lv1.SelectedItems[0].ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewItemForm_Load(object sender, EventArgs e)
        {

            con.Open();
            cmd = new SqlCommand("select * from DbCowboys where item_id=" + currentId, con);

            using (var reader = cmd.ExecuteReader())
            {
                var id = reader.GetSqlInt64(0);
                var itemMinimum = reader.GetFloat(1);
                var itemUnits = reader.GetFloat(2);
                var unitPrice = reader.GetFloat(3);
                var manufacturer = reader.GetString(4);
                var itemName = reader.GetString(5);
                var itemDescription = reader.GetString(6);
                var isMachine = reader.GetString(7);

                var pricePerUnits = unitPrice / itemUnits;

                IdTextBox.Text = id.ToString();
                NameTextBox.Text = itemName.ToString();
                ManufacturerTextBox.Text = manufacturer.ToString();
                QuantitiyTextBox.Text = itemMinimum.ToString();
                PriceTextBox.Text = pricePerUnits.ToString();
                DescTextBox.Text = itemDescription.ToString();
            }
        }
    }
}
