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
        SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=Inventory_POS;Intergrated Security=True ");
        SqlCommand cmd;

        public ViewItemForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
