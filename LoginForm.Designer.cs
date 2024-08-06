namespace CarRentalService
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.loginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(281, 124);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(67, 31);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.usernameTextBox.Location = new System.Drawing.Point(122, 34);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(226, 27);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameTextBox_KeyDown);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.passwordTextBox.Location = new System.Drawing.Point(122, 81);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(226, 27);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.usernameLabel.Location = new System.Drawing.Point(15, 33);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(101, 25);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.passwordLabel.Location = new System.Drawing.Point(15, 80);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(96, 25);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // createAccountButton
            // 
            this.createAccountButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.createAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountButton.Location = new System.Drawing.Point(166, 195);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(116, 26);
            this.createAccountButton.TabIndex = 5;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.createAccountLabel.Location = new System.Drawing.Point(71, 197);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(89, 20);
            this.createAccountLabel.TabIndex = 6;
            this.createAccountLabel.Text = "Not a user?";
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.loginGroupBox.Controls.Add(this.usernameLabel);
            this.loginGroupBox.Controls.Add(this.createAccountButton);
            this.loginGroupBox.Controls.Add(this.createAccountLabel);
            this.loginGroupBox.Controls.Add(this.passwordLabel);
            this.loginGroupBox.Controls.Add(this.usernameTextBox);
            this.loginGroupBox.Controls.Add(this.loginButton);
            this.loginGroupBox.Controls.Add(this.passwordTextBox);
            this.loginGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginGroupBox.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginGroupBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loginGroupBox.Location = new System.Drawing.Point(44, 195);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(364, 239);
            this.loginGroupBox.TabIndex = 7;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "Login or Register";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.loginGroupBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Label createAccountLabel;
        private System.Windows.Forms.GroupBox loginGroupBox;
    }
}