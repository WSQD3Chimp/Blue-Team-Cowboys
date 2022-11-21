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
    public partial class AccountCreation2Form : Form
    {
        private string username;
        private string password_hash;

        public AccountCreation2Form(string username, string password_hash)
        {
            this.username = username;
            this.password_hash = password_hash; 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string security1 = CityCreation.Text;
            string security2 = MaidenNameCreation.Text;
            string security3 = ColorCreation.Text;
            if (security1.Equals("")||security2.Equals("")||security3.Equals(""))
            {
                MessageBox.Show("Not all fields are inputed, please make sure all fields are entered.", "Empty Field Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string security1_hash = GetHash(security1);
                string security2_hash = GetHash(security2);
                string security3_hash = GetHash(security3);
            }
        }

        private void GoBackAccountCreation1_Click(object sender, EventArgs e)
        {
            (new AccountCreation1Form()).Show(); this.Close();
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
