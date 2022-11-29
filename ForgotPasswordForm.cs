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
        string username;

        public ForgotPasswordForm(string username)
        {
            InitializeComponent();
        }

        private void GoBackPasswordReset_Click(object sender, EventArgs e)
        {

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
            }
        }
    }
}
