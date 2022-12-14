using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueTeamProject
{
    public partial class PasswordResetForm : Form
    {
        public PasswordResetForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            var back = new LoginForm();
            back.FormClosed += (s, args) => this.Close();
            back.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.Username.Text;

            User user = DBController.getUser(username);
            if (this.Username.Text.Equals(""))
            {
                MessageBox.Show("No input in username field, please make sure the field is entered.", "Empty Field Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (user.password_hash == null)
            {
                this.Username.Text = "";
                MessageBox.Show("User \"" + username + "\" does not exist, please reinput your username.", "Incorrect username",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                var reset = new ForgotPasswordForm(username);
                reset.FormClosed += (s, args) => this.Close();
                reset.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = this.Username.Text;

            User user = DBController.getUser(username);
            if (this.Username.Text.Equals(""))
            {
                MessageBox.Show("No input in username field, please make sure the field is entered.", "Empty Field Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (user.password_hash == null)
            {
                this.Username.Text = "";
                MessageBox.Show("User \"" + username + "\" does not exist, please reinput your username.", "Incorrect username",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                var reset = new ForgotPasswordForm(username);
                reset.FormClosed += (s, args) => this.Close();
                reset.Show();
            }
        }
        private void GoBackForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            var back = new LoginForm();
            back.FormClosed += (s, args) => this.Close();
            back.Show();
        }
    }
}