namespace BlueTeamProject
{
    partial class ViewTransactionForm
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
            this.PanelViewTransaction = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GoBackViewTransaction = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TransactionIDText = new System.Windows.Forms.Label();
            this.TransactionDate = new System.Windows.Forms.Label();
            this.TransactionChangesBy = new System.Windows.Forms.Label();
            this.TransactionOperation = new System.Windows.Forms.Label();
            this.TransactionAffected = new System.Windows.Forms.Label();
            this.TransactionOriginalUnits = new System.Windows.Forms.Label();
            this.TransactionChange = new System.Windows.Forms.Label();
            this.TransactionNewTotal = new System.Windows.Forms.Label();
            this.PanelViewTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelViewTransaction
            // 
            this.PanelViewTransaction.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelViewTransaction.Controls.Add(this.TransactionNewTotal);
            this.PanelViewTransaction.Controls.Add(this.TransactionChange);
            this.PanelViewTransaction.Controls.Add(this.TransactionOriginalUnits);
            this.PanelViewTransaction.Controls.Add(this.TransactionAffected);
            this.PanelViewTransaction.Controls.Add(this.TransactionOperation);
            this.PanelViewTransaction.Controls.Add(this.TransactionChangesBy);
            this.PanelViewTransaction.Controls.Add(this.TransactionDate);
            this.PanelViewTransaction.Controls.Add(this.TransactionIDText);
            this.PanelViewTransaction.Controls.Add(this.label9);
            this.PanelViewTransaction.Controls.Add(this.label8);
            this.PanelViewTransaction.Controls.Add(this.label7);
            this.PanelViewTransaction.Controls.Add(this.label6);
            this.PanelViewTransaction.Controls.Add(this.label5);
            this.PanelViewTransaction.Controls.Add(this.label4);
            this.PanelViewTransaction.Controls.Add(this.label3);
            this.PanelViewTransaction.Controls.Add(this.label2);
            this.PanelViewTransaction.Location = new System.Drawing.Point(26, 98);
            this.PanelViewTransaction.Name = "PanelViewTransaction";
            this.PanelViewTransaction.Size = new System.Drawing.Size(860, 564);
            this.PanelViewTransaction.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 42);
            this.label1.TabIndex = 32;
            this.label1.Text = "Transaction";
            // 
            // GoBackViewTransaction
            // 
            this.GoBackViewTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.GoBackViewTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GoBackViewTransaction.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GoBackViewTransaction.FlatAppearance.BorderSize = 0;
            this.GoBackViewTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackViewTransaction.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackViewTransaction.ForeColor = System.Drawing.Color.White;
            this.GoBackViewTransaction.Location = new System.Drawing.Point(1085, 19);
            this.GoBackViewTransaction.Name = "GoBackViewTransaction";
            this.GoBackViewTransaction.Size = new System.Drawing.Size(160, 60);
            this.GoBackViewTransaction.TabIndex = 31;
            this.GoBackViewTransaction.Text = "Go Back";
            this.GoBackViewTransaction.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Transaction ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 12F);
            this.label3.Location = new System.Drawing.Point(36, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 12F);
            this.label4.Location = new System.Drawing.Point(36, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Changes By:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 12F);
            this.label5.Location = new System.Drawing.Point(36, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Operation:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 12F);
            this.label6.Location = new System.Drawing.Point(36, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Affected Item ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Inter", 12F);
            this.label7.Location = new System.Drawing.Point(36, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Original Total units:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inter", 12F);
            this.label8.Location = new System.Drawing.Point(36, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Change:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Inter", 12F);
            this.label9.Location = new System.Drawing.Point(36, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "New Total units:";
            // 
            // TransactionIDText
            // 
            this.TransactionIDText.AutoSize = true;
            this.TransactionIDText.Font = new System.Drawing.Font("Inter", 12F);
            this.TransactionIDText.Location = new System.Drawing.Point(164, 33);
            this.TransactionIDText.Name = "TransactionIDText";
            this.TransactionIDText.Size = new System.Drawing.Size(62, 19);
            this.TransactionIDText.TabIndex = 8;
            this.TransactionIDText.Text = "label10";
            // 
            // TransactionDate
            // 
            this.TransactionDate.AutoSize = true;
            this.TransactionDate.Font = new System.Drawing.Font("Inter", 12F);
            this.TransactionDate.Location = new System.Drawing.Point(91, 83);
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.Size = new System.Drawing.Size(59, 19);
            this.TransactionDate.TabIndex = 9;
            this.TransactionDate.Text = "label11";
            // 
            // TransactionChangesBy
            // 
            this.TransactionChangesBy.AutoSize = true;
            this.TransactionChangesBy.Font = new System.Drawing.Font("Inter", 12F);
            this.TransactionChangesBy.Location = new System.Drawing.Point(145, 133);
            this.TransactionChangesBy.Name = "TransactionChangesBy";
            this.TransactionChangesBy.Size = new System.Drawing.Size(62, 19);
            this.TransactionChangesBy.TabIndex = 10;
            this.TransactionChangesBy.Text = "label12";
            // 
            // TransactionOperation
            // 
            this.TransactionOperation.AutoSize = true;
            this.TransactionOperation.Font = new System.Drawing.Font("Inter", 12F);
            this.TransactionOperation.Location = new System.Drawing.Point(130, 224);
            this.TransactionOperation.Name = "TransactionOperation";
            this.TransactionOperation.Size = new System.Drawing.Size(62, 19);
            this.TransactionOperation.TabIndex = 11;
            this.TransactionOperation.Text = "label13";
            // 
            // TransactionAffected
            // 
            this.TransactionAffected.AutoSize = true;
            this.TransactionAffected.Font = new System.Drawing.Font("Inter", 12F);
            this.TransactionAffected.Location = new System.Drawing.Point(180, 266);
            this.TransactionAffected.Name = "TransactionAffected";
            this.TransactionAffected.Size = new System.Drawing.Size(62, 19);
            this.TransactionAffected.TabIndex = 12;
            this.TransactionAffected.Text = "label14";
            // 
            // TransactionOriginalUnits
            // 
            this.TransactionOriginalUnits.AutoSize = true;
            this.TransactionOriginalUnits.Font = new System.Drawing.Font("Inter", 12F);
            this.TransactionOriginalUnits.Location = new System.Drawing.Point(197, 306);
            this.TransactionOriginalUnits.Name = "TransactionOriginalUnits";
            this.TransactionOriginalUnits.Size = new System.Drawing.Size(62, 19);
            this.TransactionOriginalUnits.TabIndex = 13;
            this.TransactionOriginalUnits.Text = "label15";
            // 
            // TransactionChange
            // 
            this.TransactionChange.AutoSize = true;
            this.TransactionChange.Font = new System.Drawing.Font("Inter", 12F);
            this.TransactionChange.Location = new System.Drawing.Point(113, 350);
            this.TransactionChange.Name = "TransactionChange";
            this.TransactionChange.Size = new System.Drawing.Size(62, 19);
            this.TransactionChange.TabIndex = 14;
            this.TransactionChange.Text = "label16";
            // 
            // TransactionNewTotal
            // 
            this.TransactionNewTotal.AutoSize = true;
            this.TransactionNewTotal.Font = new System.Drawing.Font("Inter", 12F);
            this.TransactionNewTotal.Location = new System.Drawing.Point(173, 393);
            this.TransactionNewTotal.Name = "TransactionNewTotal";
            this.TransactionNewTotal.Size = new System.Drawing.Size(61, 19);
            this.TransactionNewTotal.TabIndex = 15;
            this.TransactionNewTotal.Text = "label17";
            // 
            // ViewTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.PanelViewTransaction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoBackViewTransaction);
            this.Name = "ViewTransactionForm";
            this.Text = "ViewTransactionForm";
            this.PanelViewTransaction.ResumeLayout(false);
            this.PanelViewTransaction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelViewTransaction;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GoBackViewTransaction;
        private System.Windows.Forms.Label TransactionNewTotal;
        private System.Windows.Forms.Label TransactionChange;
        private System.Windows.Forms.Label TransactionOriginalUnits;
        private System.Windows.Forms.Label TransactionAffected;
        private System.Windows.Forms.Label TransactionOperation;
        private System.Windows.Forms.Label TransactionChangesBy;
        private System.Windows.Forms.Label TransactionDate;
        private System.Windows.Forms.Label TransactionIDText;
    }
}