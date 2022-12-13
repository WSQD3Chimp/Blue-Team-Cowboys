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
    public partial class ViewTransactionForm : Form
    {
        Transaction transaction;
        public ViewTransactionForm(int id)
        {
            InitializeComponent();
            this.transaction = DBController.viewTransaction(id);

            TransactionIDText.Text = transaction.transaction_id.ToString();
            TransactionDate.Text = transaction.date.ToString();
            TransactionChangesBy.Text = transaction.account_id.ToString();
            TransactionOperation.Text = transaction.operation_type;
            TransactionAffected.Text = transaction.item_id.ToString();
            if (transaction.unit_change != 0)
            {
                TransactionChange.Text = transaction.unit_change.ToString();
            }
        }

        private void GoBackViewTransaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            var transactions = new TransactionListForm(DBController.viewTransactions());
            transactions.FormClosed += (s, args) => this.Close();
            transactions.Show();
        }
    }
}
