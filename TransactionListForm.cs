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
        List<Transaction> transactions;

        public TransactionListForm(List<Transaction> list)
        {
            InitializeComponent();
            this.transactions = list;

            loadList(transactions);
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
            DateTime temp;
            bool isValidDate = DateTime.TryParse(QueryTransactionList.Text, out temp);
            if (QueryTransactionList.Text.Equals("") || !isValidDate)
            {
                this.TransactionListView.SelectedItems.Clear();
                MessageBox.Show("You must use the following date format: \"mm/dd/yyyy\".", "Incorrect Field Query",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime date = DateTime.Parse(QueryTransactionList.Text);
                this.Hide();
                var back = new TransactionListForm(DBController.searchTransactionByDate(date));
                back.FormClosed += (s, args) => this.Close();
                back.Show();
            }
        }

        private void FilterTransactionID_Click(object sender, EventArgs e)
        {
            if (QueryTransactionList.Text.Equals("") || QueryTransactionList.Text.Any(x => x != ' ' && x != '-' && !char.IsDigit(x)))
            {
                this.TransactionListView.SelectedItems.Clear();
                MessageBox.Show("Do not use letters or symbols with this filter.", "Incorrect Field Query",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Int32.Parse(QueryTransactionList.Text);
                this.Hide();
                var back = new TransactionListForm(DBController.searchTransactionById(id));
                back.FormClosed += (s, args) => this.Close();
                back.Show();
            }
        }

        private void FilterOperation_Click(object sender, EventArgs e)
        {
            if (QueryTransactionList.Text.Equals("") || !QueryTransactionList.Text.Equals("item added") || !QueryTransactionList.Text.Equals("item removed") || !QueryTransactionList.Text.Equals("stock added") || !QueryTransactionList.Text.Equals("stock removed"))
            {
                this.TransactionListView.SelectedItems.Clear();
                MessageBox.Show("You must input one of the following: \n \"item added\", \"item removed\" \n \"stock added\", \"stock removed\"", "Incorrect Field Query",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Int32.Parse(QueryTransactionList.Text);
                this.Hide();
                var back = new TransactionListForm(DBController.searchTransactionByItem(id));
                back.FormClosed += (s, args) => this.Close();
                back.Show();
            }
        }

        private void FilterItemID_Click(object sender, EventArgs e)
        {
            if (QueryTransactionList.Text.Equals("") || QueryTransactionList.Text.Any(x => x != ' ' && x != '-' && !char.IsDigit(x)))
            {
                this.TransactionListView.SelectedItems.Clear();
                MessageBox.Show("Do not use letters or symbols with this filter.", "Incorrect Field Query",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Int32.Parse(QueryTransactionList.Text);
                this.Hide();
                var back = new TransactionListForm(DBController.searchTransactionByItem(id));
                back.FormClosed += (s, args) => this.Close();
                back.Show();
            }
        }

        private void FilterUser_Click(object sender, EventArgs e)
        {
            if (QueryTransactionList.Text.Equals("") || QueryTransactionList.Text.Any(x => x != ' ' && x != '-' && !char.IsDigit(x)))
            {
                this.TransactionListView.SelectedItems.Clear();
                MessageBox.Show("Do not use letters or symbols with this filter.", "Incorrect Field Query",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Int32.Parse(QueryTransactionList.Text);
                this.Hide();
                var back = new TransactionListForm(DBController.searchTransactionByUser(id));
                back.FormClosed += (s, args) => this.Close();
                back.Show();
            }
        }

        private void ViewTransaction_Click(object sender, EventArgs e)
        {
            if (this.TransactionListView.CheckedItems.Count != 1)
            {
                this.TransactionListView.SelectedItems.Clear();
                MessageBox.Show("Please select only one transaction to view.", "Multiple Transactions Selected",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int[] i = TransactionListView.CheckedIndices.Cast<int>().ToArray();
                int transactionIndex = i[0];

                Transaction temp = transactions[transactionIndex];

                this.Hide();
                var view = new ViewTransactionForm(temp.transaction_id);
                view.FormClosed += (s, args) => this.Close();
                view.Show();
            }
        }

        private void loadList(List<Transaction> list)
        {
            TransactionListView.Items.Clear();
            TransactionListView.View = View.Details;
            TransactionListView.FullRowSelect = true;

            TransactionListView.Columns.Add("User", 100);
            TransactionListView.Columns.Add("Date", 300);
            TransactionListView.Columns.Add("Changes", 300);
            TransactionListView.CheckBoxes = true;

            this.transactions = list;

            string[] arr = new string[3];
            ListViewItem transaction;

            for (int i = 0; i < transactions.Count - 1; i++)
            {
                arr[0] = transactions[i].item_id.ToString();
                arr[1] = transactions[i].date.ToString();
                arr[2] = transactions[i].operation_type;
                transaction = new ListViewItem(arr);
                TransactionListView.Items.Add(transaction);
            }
            TransactionListView.Update();
        }

        private void TransactionListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
