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

            this.Hide();
            var reset = new ForgotPasswordForm(username);
            reset.FormClosed += (s, args) => this.Close();
            reset.Show();
        }
    }
}
