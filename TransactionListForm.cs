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
    public partial class TransactionListForm : Form
    {
        public TransactionListForm()
        {
            InitializeComponent();
            
            TransactionListView.View = View.Details;
            TransactionListView.FullRowSelect = true;

            TransactionListView.Columns.Add("User", 100);
            TransactionListView.Columns.Add("Date", 300);
            TransactionListView.Columns.Add("Changes", 300);
            TransactionListView.CheckBoxes = true;

            DBController.insertTransaction(4, 1, "Add Stock", 5);
            DBController.insertTransaction(4, 1, "Add Stock", 5);
            DBController.insertTransaction(4, 1, "Add Stock", 5);
            DBController.insertTransaction(4, 1, "Add Stock", 5);
            DBController.insertTransaction(4, 1, "Add Stock", 5);

            List<Transaction> transactions = DBController.viewTransactions();

            string[] arr = new string[3];
            ListViewItem transaction;

            for(int i = 0; i<transactions.Count-1; i++)
            {
                arr[0] = transactions[i].item_id.ToString();
                arr[1] = transactions[i].date.ToString();
                arr[2] = transactions[i].operation_type;
                transaction = new ListViewItem(arr);
                TransactionListView.Items.Add(transaction);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GoBackTransactionList_Click(object sender, EventArgs e)
        {
            this.Hide();
            var back = new MainMenuForm(true);
            back.FormClosed += (s, args) => this.Close();
            back.Show();
        }

        private void FilterDate_Click(object sender, EventArgs e)
        {

        }
    }
}
