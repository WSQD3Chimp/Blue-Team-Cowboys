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
            this.Hide();
            var reset = new PasswordResetForm();
            reset.FormClosed += (s, args) => this.Close();
            reset.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string password = Password.Text;
            string password_hash = HashClass.GetHash(password);

            this.Hide();
            var loggedin = new MainMenuForm(true);
            loggedin.FormClosed += (s, args) => this.Close();
            loggedin.Show();
        }
    }
}
