namespace BlueTeamProject
{
    partial class TransactionListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TransactionListView = new System.Windows.Forms.ListView();
            this.FilterUser = new System.Windows.Forms.Button();
            this.FilterItemID = new System.Windows.Forms.Button();
            this.FilterOperation = new System.Windows.Forms.Button();
            this.FilterTransactionID = new System.Windows.Forms.Button();
            this.FilterDate = new System.Windows.Forms.Button();
            this.QueryTransactionList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewTransaction = new System.Windows.Forms.Button();
            this.ExportTransaction = new System.Windows.Forms.Button();
            this.GoBackTransactionList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TransactionListView
            // 
            this.TransactionListView.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TransactionListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransactionListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionListView.HideSelection = false;
            this.TransactionListView.Location = new System.Drawing.Point(19, 78);
            this.TransactionListView.Name = "TransactionListView";
            this.TransactionListView.Size = new System.Drawing.Size(868, 591);
            this.TransactionListView.TabIndex = 50;
            this.TransactionListView.UseCompatibleStateImageBehavior = false;
            this.TransactionListView.SelectedIndexChanged += new System.EventHandler(this.TransactionListView_SelectedIndexChanged);
            // 
            // FilterUser
            // 
            this.FilterUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.FilterUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FilterUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FilterUser.FlatAppearance.BorderSize = 0;
            this.FilterUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterUser.ForeColor = System.Drawing.Color.White;
            this.FilterUser.Location = new System.Drawing.Point(907, 348);
            this.FilterUser.Name = "FilterUser";
            this.FilterUser.Size = new System.Drawing.Size(160, 60);
            this.FilterUser.TabIndex = 49;
            this.FilterUser.Text = "User";
            this.FilterUser.UseVisualStyleBackColor = false;
            this.FilterUser.Click += new System.EventHandler(this.FilterUser_Click);
            // 
            // FilterItemID
            // 
            this.FilterItemID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.FilterItemID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FilterItemID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FilterItemID.FlatAppearance.BorderSize = 0;
            this.FilterItemID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterItemID.ForeColor = System.Drawing.Color.White;
            this.FilterItemID.Location = new System.Drawing.Point(1086, 269);
            this.FilterItemID.Name = "FilterItemID";
            this.FilterItemID.Size = new System.Drawing.Size(160, 60);
            this.FilterItemID.TabIndex = 48;
            this.FilterItemID.Text = "Item ID";
            this.FilterItemID.UseVisualStyleBackColor = false;
            this.FilterItemID.Click += new System.EventHandler(this.FilterItemID_Click);
            // 
            // FilterOperation
            // 
            this.FilterOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.FilterOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FilterOperation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FilterOperation.FlatAppearance.BorderSize = 0;
            this.FilterOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterOperation.ForeColor = System.Drawing.Color.White;
            this.FilterOperation.Location = new System.Drawing.Point(907, 269);
            this.FilterOperation.Name = "FilterOperation";
            this.FilterOperation.Size = new System.Drawing.Size(160, 60);
            this.FilterOperation.TabIndex = 47;
            this.FilterOperation.Text = "Operation";
            this.FilterOperation.UseVisualStyleBackColor = false;
            this.FilterOperation.Click += new System.EventHandler(this.FilterOperation_Click);
            // 
            // FilterTransactionID
            // 
            this.FilterTransactionID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.FilterTransactionID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FilterTransactionID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FilterTransactionID.FlatAppearance.BorderSize = 0;
            this.FilterTransactionID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterTransactionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterTransactionID.ForeColor = System.Drawing.Color.White;
            this.FilterTransactionID.Location = new System.Drawing.Point(1086, 188);
            this.FilterTransactionID.Name = "FilterTransactionID";
            this.FilterTransactionID.Size = new System.Drawing.Size(160, 60);
            this.FilterTransactionID.TabIndex = 46;
            this.FilterTransactionID.Text = "Transaction ID";
            this.FilterTransactionID.UseVisualStyleBackColor = false;
            this.FilterTransactionID.Click += new System.EventHandler(this.FilterTransactionID_Click);
            // 
            // FilterDate
            // 
            this.FilterDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.FilterDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FilterDate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FilterDate.FlatAppearance.BorderSize = 0;
            this.FilterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterDate.ForeColor = System.Drawing.Color.White;
            this.FilterDate.Location = new System.Drawing.Point(907, 188);
            this.FilterDate.Name = "FilterDate";
            this.FilterDate.Size = new System.Drawing.Size(160, 60);
            this.FilterDate.TabIndex = 45;
            this.FilterDate.Text = "Date (yy/mm/dd)";
            this.FilterDate.UseVisualStyleBackColor = false;
            this.FilterDate.Click += new System.EventHandler(this.FilterDate_Click);
            // 
            // QueryTransactionList
            // 
            this.QueryTransactionList.BackColor = System.Drawing.Color.Gainsboro;
            this.QueryTransactionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueryTransactionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.QueryTransactionList.ForeColor = System.Drawing.SystemColors.GrayText;
            this.QueryTransactionList.Location = new System.Drawing.Point(907, 142);
            this.QueryTransactionList.Name = "QueryTransactionList";
            this.QueryTransactionList.Size = new System.Drawing.Size(339, 25);
            this.QueryTransactionList.TabIndex = 44;
            this.QueryTransactionList.Text = "Enter Query...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(902, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Filter By...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 42);
            this.label1.TabIndex = 42;
            this.label1.Text = "Transaction List";
            // 
            // ViewTransaction
            // 
            this.ViewTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.ViewTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ViewTransaction.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ViewTransaction.FlatAppearance.BorderSize = 0;
            this.ViewTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTransaction.ForeColor = System.Drawing.Color.White;
            this.ViewTransaction.Location = new System.Drawing.Point(727, 12);
            this.ViewTransaction.Name = "ViewTransaction";
            this.ViewTransaction.Size = new System.Drawing.Size(160, 60);
            this.ViewTransaction.TabIndex = 41;
            this.ViewTransaction.Text = "View Selected Transaction";
            this.ViewTransaction.UseVisualStyleBackColor = false;
            this.ViewTransaction.Click += new System.EventHandler(this.ViewTransaction_Click);
            // 
            // ExportTransaction
            // 
            this.ExportTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.ExportTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExportTransaction.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ExportTransaction.FlatAppearance.BorderSize = 0;
            this.ExportTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ExportTransaction.ForeColor = System.Drawing.Color.White;
            this.ExportTransaction.Location = new System.Drawing.Point(907, 12);
            this.ExportTransaction.Name = "ExportTransaction";
            this.ExportTransaction.Size = new System.Drawing.Size(160, 60);
            this.ExportTransaction.TabIndex = 40;
            this.ExportTransaction.Text = "Export Selected Transaction";
            this.ExportTransaction.UseVisualStyleBackColor = false;
            // 
            // GoBackTransactionList
            // 
            this.GoBackTransactionList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.GoBackTransactionList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GoBackTransactionList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GoBackTransactionList.FlatAppearance.BorderSize = 0;
            this.GoBackTransactionList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackTransactionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackTransactionList.ForeColor = System.Drawing.Color.White;
            this.GoBackTransactionList.Location = new System.Drawing.Point(1086, 12);
            this.GoBackTransactionList.Name = "GoBackTransactionList";
            this.GoBackTransactionList.Size = new System.Drawing.Size(160, 60);
            this.GoBackTransactionList.TabIndex = 39;
            this.GoBackTransactionList.Text = "Go Back";
            this.GoBackTransactionList.UseVisualStyleBackColor = false;
            this.GoBackTransactionList.Click += new System.EventHandler(this.GoBackTransactionList_Click);
            // 
            // TransactionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.TransactionListView);
            this.Controls.Add(this.FilterUser);
            this.Controls.Add(this.FilterItemID);
            this.Controls.Add(this.FilterOperation);
            this.Controls.Add(this.FilterTransactionID);
            this.Controls.Add(this.FilterDate);
            this.Controls.Add(this.QueryTransactionList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewTransaction);
            this.Controls.Add(this.ExportTransaction);
            this.Controls.Add(this.GoBackTransactionList);
            this.Name = "TransactionListForm";
            this.Text = "TransactionListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView TransactionListView;
        private System.Windows.Forms.Button FilterUser;
        private System.Windows.Forms.Button FilterItemID;
        private System.Windows.Forms.Button FilterOperation;
        private System.Windows.Forms.Button FilterTransactionID;
        private System.Windows.Forms.Button FilterDate;
        private System.Windows.Forms.TextBox QueryTransactionList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewTransaction;
        private System.Windows.Forms.Button ExportTransaction;
        private System.Windows.Forms.Button GoBackTransactionList;
    }
}