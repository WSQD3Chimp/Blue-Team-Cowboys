namespace BlueTeamProject
{
    partial class ViewInventoryForm
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
            this.ViewInventoryListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.EditCatalogue = new System.Windows.Forms.Button();
            this.GoBackViewInventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewInventoryListView
            // 
            this.ViewInventoryListView.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ViewInventoryListView.HideSelection = false;
            this.ViewInventoryListView.Location = new System.Drawing.Point(24, 92);
            this.ViewInventoryListView.Name = "ViewInventoryListView";
            this.ViewInventoryListView.Size = new System.Drawing.Size(1224, 569);
            this.ViewInventoryListView.TabIndex = 21;
            this.ViewInventoryListView.UseCompatibleStateImageBehavior = false;
            this.ViewInventoryListView.SelectedIndexChanged += new System.EventHandler(this.ViewInventoryListView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 42);
            this.label1.TabIndex = 20;
            this.label1.Text = "Inventory";
            // 
            // EditCatalogue
            // 
            this.EditCatalogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.EditCatalogue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditCatalogue.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EditCatalogue.FlatAppearance.BorderSize = 0;
            this.EditCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCatalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.EditCatalogue.ForeColor = System.Drawing.Color.White;
            this.EditCatalogue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EditCatalogue.Location = new System.Drawing.Point(967, 19);
            this.EditCatalogue.Name = "EditCatalogue";
            this.EditCatalogue.Size = new System.Drawing.Size(136, 48);
            this.EditCatalogue.TabIndex = 19;
            this.EditCatalogue.Text = "Edit Catalogue";
            this.EditCatalogue.UseVisualStyleBackColor = false;
            this.EditCatalogue.Click += new System.EventHandler(this.EditCatalogue_Click);
            // 
            // GoBackViewInventory
            // 
            this.GoBackViewInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.GoBackViewInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GoBackViewInventory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GoBackViewInventory.FlatAppearance.BorderSize = 0;
            this.GoBackViewInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackViewInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.GoBackViewInventory.ForeColor = System.Drawing.Color.White;
            this.GoBackViewInventory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GoBackViewInventory.Location = new System.Drawing.Point(1118, 19);
            this.GoBackViewInventory.Name = "GoBackViewInventory";
            this.GoBackViewInventory.Size = new System.Drawing.Size(130, 48);
            this.GoBackViewInventory.TabIndex = 18;
            this.GoBackViewInventory.Text = "Go Back";
            this.GoBackViewInventory.UseVisualStyleBackColor = false;
            this.GoBackViewInventory.Click += new System.EventHandler(this.GoBackViewInventory_Click);
            // 
            // ViewInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ViewInventoryListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditCatalogue);
            this.Controls.Add(this.GoBackViewInventory);
            this.Name = "ViewInventoryForm";
            this.Text = "ViewInventoryForm";
            this.Load += new System.EventHandler(this.ViewInventoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ViewInventoryListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditCatalogue;
        private System.Windows.Forms.Button GoBackViewInventory;
    }
}