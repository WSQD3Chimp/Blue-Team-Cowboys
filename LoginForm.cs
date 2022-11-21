using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueTeamProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Username.AutoSize = false;
            this.Username.Size = new System.Drawing.Size(494, 28);

            this.Password.AutoSize = false;
            this.Password.Size = new System.Drawing.Size(494, 28);

            this.ForgotPasswordTextButton.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
