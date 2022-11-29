namespace BlueTeamProject
{
    partial class PasswordResetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordResetForm));
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.LabelUsernamePassReset = new System.Windows.Forms.Label();
            this.GoBackForgotPassword = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Username
            // 
            resources.ApplyResources(this.Username, "Username");
            this.Username.BackColor = System.Drawing.Color.Gainsboro;
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Username.Name = "Username";
            // 
            // LabelUsernamePassReset
            // 
            resources.ApplyResources(this.LabelUsernamePassReset, "LabelUsernamePassReset");
            this.LabelUsernamePassReset.Name = "LabelUsernamePassReset";
            // 
            // GoBackForgotPassword
            // 
            resources.ApplyResources(this.GoBackForgotPassword, "GoBackForgotPassword");
            this.GoBackForgotPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.GoBackForgotPassword.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GoBackForgotPassword.FlatAppearance.BorderSize = 0;
            this.GoBackForgotPassword.ForeColor = System.Drawing.Color.White;
            this.GoBackForgotPassword.Name = "GoBackForgotPassword";
            this.GoBackForgotPassword.UseVisualStyleBackColor = false;
            this.GoBackForgotPassword.Click += new System.EventHandler(this.Login_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(125)))), ((int)(((byte)(100)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GoBackForgotPassword);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.LabelUsernamePassReset);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label LabelUsernamePassReset;
        private System.Windows.Forms.Button GoBackForgotPassword;
        private System.Windows.Forms.Button button1;
    }
}