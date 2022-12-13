namespace BlueTeamProject
{
    partial class ViewPartsForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.AddItemViewParts = new System.Windows.Forms.Button();
            this.DeleteItemsViewParts = new System.Windows.Forms.Button();
            this.GoBackViewParts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 84);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1233, 581);
            this.listView1.TabIndex = 34;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 42);
            this.label1.TabIndex = 33;
            this.label1.Text = "View Parts";
            // 
            // AddItemViewParts
            // 
            this.AddItemViewParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(125)))), ((int)(((byte)(100)))));
            this.AddItemViewParts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddItemViewParts.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddItemViewParts.FlatAppearance.BorderSize = 0;
            this.AddItemViewParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemViewParts.Font = new System.Drawing.Font("Inter", 14.25F);
            this.AddItemViewParts.ForeColor = System.Drawing.Color.White;
            this.AddItemViewParts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddItemViewParts.Location = new System.Drawing.Point(774, 15);
            this.AddItemViewParts.Name = "AddItemViewParts";
            this.AddItemViewParts.Size = new System.Drawing.Size(130, 48);
            this.AddItemViewParts.TabIndex = 32;
            this.AddItemViewParts.Text = "Add Item";
            this.AddItemViewParts.UseVisualStyleBackColor = false;
            // 
            // DeleteItemsViewParts
            // 
            this.DeleteItemsViewParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.DeleteItemsViewParts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteItemsViewParts.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteItemsViewParts.FlatAppearance.BorderSize = 0;
            this.DeleteItemsViewParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteItemsViewParts.Font = new System.Drawing.Font("Inter", 12.25F);
            this.DeleteItemsViewParts.ForeColor = System.Drawing.Color.White;
            this.DeleteItemsViewParts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DeleteItemsViewParts.Location = new System.Drawing.Point(922, 15);
            this.DeleteItemsViewParts.Name = "DeleteItemsViewParts";
            this.DeleteItemsViewParts.Size = new System.Drawing.Size(182, 48);
            this.DeleteItemsViewParts.TabIndex = 31;
            this.DeleteItemsViewParts.Text = "Delete Selected Items";
            this.DeleteItemsViewParts.UseVisualStyleBackColor = false;
            // 
            // GoBackViewParts
            // 
            this.GoBackViewParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.GoBackViewParts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GoBackViewParts.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GoBackViewParts.FlatAppearance.BorderSize = 0;
            this.GoBackViewParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackViewParts.Font = new System.Drawing.Font("Inter", 14.25F);
            this.GoBackViewParts.ForeColor = System.Drawing.Color.White;
            this.GoBackViewParts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GoBackViewParts.Location = new System.Drawing.Point(1122, 15);
            this.GoBackViewParts.Name = "GoBackViewParts";
            this.GoBackViewParts.Size = new System.Drawing.Size(130, 48);
            this.GoBackViewParts.TabIndex = 30;
            this.GoBackViewParts.Text = "Go Back";
            this.GoBackViewParts.UseVisualStyleBackColor = false;
            // 
            // ViewPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddItemViewParts);
            this.Controls.Add(this.DeleteItemsViewParts);
            this.Controls.Add(this.GoBackViewParts);
            this.Name = "ViewPartsForm";
            this.Text = "ViewPartsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddItemViewParts;
        private System.Windows.Forms.Button DeleteItemsViewParts;
        private System.Windows.Forms.Button GoBackViewParts;
    }
}