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
    public partial class MainMenuForm : Form
    {
        bool isManager=false;

        public MainMenuForm(bool isManager)
        {
            this.isManager=isManager;
            InitializeComponent();
            if (!isManager)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button2.BackColor = Color.Gray;
                this.button3.BackColor = Color.Gray;
                this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.button2.UseVisualStyleBackColor = false;
                this.button3.UseVisualStyleBackColor = false;

                this.LabelUsernameLevel.Text = "Logged in as Employee";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ViewInventoryForm Vi = new ViewInventoryForm();
            Vi.Show();

            //AddItemForm a1 = new AddItemForm();
            //a1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var transactions = new TransactionListForm(DBController.viewTransactions());
            transactions.FormClosed += (s, args) => this.Close();
            transactions.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var account = new AccountCreation1Form();
            account.FormClosed += (s, args) => this.Close();
            account.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var logout = new LoginForm();
            logout.FormClosed += (s, args) => this.Close();
            logout.Show();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
