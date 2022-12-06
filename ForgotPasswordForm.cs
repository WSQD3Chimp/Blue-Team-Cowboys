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
    public partial class ForgotPasswordForm : Form
    {
        private User user;

        public ForgotPasswordForm(string username)
        {
            InitializeComponent();
            this.user = DBController.getUser(username);
        }

        private void GoBackPasswordReset_Click(object sender, EventArgs e)
        {
            this.Hide();
            var back = new PasswordResetForm();
            back.FormClosed += (s, args) => this.Close();
            back.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(AnswerCity.Text.Equals("") || AnswerMaidenName.Text.Equals("") || AnswerColor.Text.Equals("") || Password.Text.Equals("") || PasswordConfirmation.Text.Equals(""))
            {
                MessageBox.Show("Not all fields are inputed, please make sure all fields are entered.", "Empty Field Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Password.Text.Equals(PasswordConfirmation.Text)){
                Password.Text = "";
                PasswordConfirmation.Text = "";

                MessageBox.Show("Passwords do not match, please reenter passwords.", "Could not confirm new Password.",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string city = AnswerCity.Text;
                string maiden = AnswerMaidenName.Text;
                string color = AnswerColor.Text;
                string password = Password.Text;

                string city_hash = HashClass.GetHash(city);
                string maiden_hash = HashClass.GetHash(maiden);
                string color_hash = HashClass.GetHash(color);
                string password_hash = HashClass.GetHash(password);

                if (!city_hash.Equals(this.user.security1_hash) || !maiden_hash.Equals(this.user.security2_hash) || !color_hash.Equals(this.user.security3_hash))
                {
                    AnswerCity.Text = "";
                    AnswerMaidenName.Text = "";
                    AnswerColor.Text = "";
                    MessageBox.Show("One or many security questions have been answered incorrectly.", "Incorrect Answer.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DBController.updatePassword(this.user.username, password_hash);

                    MessageBox.Show("Password successfully updated.", "Update Successful.",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    var login = new LoginForm();
                    login.FormClosed += (s, args) => this.Close();
                    login.Show();
                }
            }
        }
    }
}
