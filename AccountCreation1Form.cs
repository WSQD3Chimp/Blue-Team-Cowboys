using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
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
            else
            {
                string password_hash = GetHash(password);
                (new AccountCreation2Form(username, password_hash)).Show(); this.Close();
            }
        }

        private void GoBackAccountCreation1_Click(object sender, EventArgs e)
        {
            (new MainMenuForm()).Show(); this.Close();
        }

        public static string GetHash(string inputString)
        {
         HashAlgorithm algorithm = MD5.Create();
         byte[] hashes = algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));

         StringBuilder stringBuilder = new StringBuilder();

         foreach (byte b in hashes) stringBuilder.Append(b.ToString("X2"));
         return stringBuilder.ToString();
        }
    }
}
