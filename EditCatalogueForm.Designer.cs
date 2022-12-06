namespace BlueTeamProject
{
    partial class EditCatalogueForm
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
            this.GoBackEditCatalogue = new System.Windows.Forms.Button();
            this.DeleteItemsCatalogue = new System.Windows.Forms.Button();
            this.AddItemCatalogue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // GoBackEditCatalogue
            // 
            this.GoBackEditCatalogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.GoBackEditCatalogue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GoBackEditCatalogue.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GoBackEditCatalogue.FlatAppearance.BorderSize = 0;
            this.GoBackEditCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackEditCatalogue.Font = new System.Drawing.Font("Inter", 14.25F);
            this.GoBackEditCatalogue.ForeColor = System.Drawing.Color.White;
            this.GoBackEditCatalogue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GoBackEditCatalogue.Location = new System.Drawing.Point(1122, 27);
            this.GoBackEditCatalogue.Name = "GoBackEditCatalogue";
            this.GoBackEditCatalogue.Size = new System.Drawing.Size(130, 48);
            this.GoBackEditCatalogue.TabIndex = 20;
            this.GoBackEditCatalogue.Text = "Go Back";
            this.GoBackEditCatalogue.UseVisualStyleBackColor = false;
            this.GoBackEditCatalogue.Click += new System.EventHandler(this.GoBackViewInventory_Click);
            // 
            // DeleteItemsCatalogue
            // 
            this.DeleteItemsCatalogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.DeleteItemsCatalogue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteItemsCatalogue.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteItemsCatalogue.FlatAppearance.BorderSize = 0;
            this.DeleteItemsCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteItemsCatalogue.Font = new System.Drawing.Font("Inter", 12.25F);
            this.DeleteItemsCatalogue.ForeColor = System.Drawing.Color.White;
            this.DeleteItemsCatalogue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DeleteItemsCatalogue.Location = new System.Drawing.Point(922, 27);
            this.DeleteItemsCatalogue.Name = "DeleteItemsCatalogue";
            this.DeleteItemsCatalogue.Size = new System.Drawing.Size(182, 48);
            this.DeleteItemsCatalogue.TabIndex = 21;
            this.DeleteItemsCatalogue.Text = "Delete Selected Items";
            this.DeleteItemsCatalogue.UseVisualStyleBackColor = false;
            this.DeleteItemsCatalogue.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddItemCatalogue
            // 
            this.AddItemCatalogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(125)))), ((int)(((byte)(100)))));
            this.AddItemCatalogue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddItemCatalogue.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddItemCatalogue.FlatAppearance.BorderSize = 0;
            this.AddItemCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemCatalogue.Font = new System.Drawing.Font("Inter", 14.25F);
            this.AddItemCatalogue.ForeColor = System.Drawing.Color.White;
            this.AddItemCatalogue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddItemCatalogue.Location = new System.Drawing.Point(774, 27);
            this.AddItemCatalogue.Name = "AddItemCatalogue";
            this.AddItemCatalogue.Size = new System.Drawing.Size(130, 48);
            this.AddItemCatalogue.TabIndex = 22;
            this.AddItemCatalogue.Text = "Add Item";
            this.AddItemCatalogue.UseVisualStyleBackColor = false;
            this.AddItemCatalogue.Click += new System.EventHandler(this.AddItemCatalogue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 42);
            this.label1.TabIndex = 23;
            this.label1.Text = "Edit Catalogue";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 98);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1233, 571);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // EditCatalogueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddItemCatalogue);
            this.Controls.Add(this.DeleteItemsCatalogue);
            this.Controls.Add(this.GoBackEditCatalogue);
            this.Name = "EditCatalogueForm";
            this.Text = "EditCatalogueForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GoBackEditCatalogue;
        private System.Windows.Forms.Button DeleteItemsCatalogue;
        private System.Windows.Forms.Button AddItemCatalogue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
    }
}