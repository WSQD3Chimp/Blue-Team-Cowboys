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

            TransactionListView.Columns.Add("ID", 100);
            TransactionListView.Columns.Add("Date", 300);
            TransactionListView.Columns.Add("Changes", 300);
            TransactionListView.CheckBoxes = true;

            string[] arr = new string[3];
            ListViewItem item;

            arr[0] = "111111";
            arr[1] = "2022/12/5 13:00";
            arr[2] = "Stock Update";
            item = new ListViewItem(arr);
            TransactionListView.Items.Add(item);

            arr[0] = "222222";
            arr[1] = "2077/69/69 23:60";
            arr[2] = "Item Added";
            item = new ListViewItem(arr);
            TransactionListView.Items.Add(item);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
