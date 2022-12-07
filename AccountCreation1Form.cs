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
    public partial class AccountCreation1Form : Form
    {
        public AccountCreation1Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UsernameCreation.Text;
            string password = PasswordCreation.Text;
            string confirm_password = PasswordConfirmCreation.Text;

            if (username.Equals("") || password.Equals("") || confirm_password.Equals(""))
            {
                MessageBox.Show("Not all fields are inputed, please make sure all fields are entered.", "Empty Field Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!password.Equals(confirm_password)){
                PasswordCreation.Text = "";
                PasswordConfirmCreation.Text = "";
                MessageBox.Show("Passwords do not match, please reinput the passwords.", "Password Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(DBController.getUser(username).password_hash != null){
                UsernameCreation.Text = "";
                PasswordCreation.Text = "";
                PasswordConfirmCreation.Text = "";
                MessageBox.Show("The username \""+username+"\" is already in use, please enter another username.", "Username Taken",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string password_hash = HashClass.GetHash(password);

                this.Hide();
                var next = new AccountCreation2Form(username, password_hash);
                next.FormClosed += (s, args) => this.Close();
                next.Show();
            }
        }

        private void GoBackAccountCreation1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MainMenuForm = new MainMenuForm(true);
            MainMenuForm.FormClosed += (s, args) => this.Close();
            MainMenuForm.Show();
        }

        private void AccountCreation1Form_Load(object sender, EventArgs e)
        {

        }
    }
}
