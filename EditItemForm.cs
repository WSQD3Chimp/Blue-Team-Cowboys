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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BlueTeamProject
{
    public partial class EditItemForm : Form
    {
        SqlCommand cmd;
        int id;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-U3Q7T4N\\MSSQLSERVER01;Initial Catalog=DbCowboys;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public EditItemForm(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void GoBackEditItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Vi = new ViewItemForm(id);
            Vi.FormClosed += (s, args) => this.Close();
            Vi.Show();
        }

        private void EditItemForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveChangesEditItem_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Update item set unit_price= '" + PriceUnitEditItem.Text + "', description='" + DescriptionEditItem.Text + "', item_minimum='" + MinimumUnitsEditItem.Text + "'where item_id=" + id, con);
                cmd.ExecuteNonQuery();

                this.Hide();
                var vI = new ViewInventoryForm();
                vI.FormClosed += (s, args) => this.Close();
                vI.Show();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Inserted Successfully");
                }

            }
            catch (Exception ez)
            {

                MessageBox.Show(ez.Message);

            }
            con.Close();
        }
    }
}
