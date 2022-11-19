namespace BlueTeamProject
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.ForgotPasswordTextButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Inter SemiBold", 32F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(0, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1280, 145);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRÉATIONS C.D.Y. INC.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 18F);
            this.label2.Location = new System.Drawing.Point(452, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inventory Management System";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Inter", 14F);
            this.LabelUsername.Location = new System.Drawing.Point(393, 279);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(102, 23);
            this.LabelUsername.TabIndex = 2;
            this.LabelUsername.Text = "Username";
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.Gainsboro;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("Inter", 16F);
            this.Username.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Username.Location = new System.Drawing.Point(398, 309);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(494, 26);
            this.Username.TabIndex = 4;
            this.Username.Text = "Enter Username...";
            this.Username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Inter", 14F);
            this.LabelPassword.Location = new System.Drawing.Point(393, 371);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(98, 23);
            this.LabelPassword.TabIndex = 5;
            this.LabelPassword.Text = "Password";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Gainsboro;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Inter", 16F);
            this.Password.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Password.Location = new System.Drawing.Point(398, 401);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(494, 26);
            this.Password.TabIndex = 4;
            this.Password.Text = "Enter Password...";
            this.Password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(558, 478);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(160, 60);
            this.Login.TabIndex = 7;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            // 
            // ForgotPasswordTextButton
            // 
            this.ForgotPasswordTextButton.AutoSize = true;
            this.ForgotPasswordTextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPasswordTextButton.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPasswordTextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.ForgotPasswordTextButton.Location = new System.Drawing.Point(582, 545);
            this.ForgotPasswordTextButton.Name = "ForgotPasswordTextButton";
            this.ForgotPasswordTextButton.Size = new System.Drawing.Size(113, 16);
            this.ForgotPasswordTextButton.TabIndex = 8;
            this.ForgotPasswordTextButton.Text = "Forgot Password";
            this.ForgotPasswordTextButton.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ForgotPasswordTextButton);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label ForgotPasswordTextButton;
    }
}

