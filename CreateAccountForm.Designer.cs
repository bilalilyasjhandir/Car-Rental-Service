namespace CarRentalService
{
    partial class CreateAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountForm));
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.roleTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.createAccountGroupBox = new System.Windows.Forms.GroupBox();
            this.createAccountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.usernameTextBox.Location = new System.Drawing.Point(128, 42);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(262, 27);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameTextBox_KeyDown);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.passwordTextBox.Location = new System.Drawing.Point(128, 84);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(262, 27);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // roleTextBox
            // 
            this.roleTextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.roleTextBox.Location = new System.Drawing.Point(128, 126);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.Size = new System.Drawing.Size(262, 27);
            this.roleTextBox.TabIndex = 2;
            this.roleTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.roleTextBox_KeyDown);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.usernameLabel.Location = new System.Drawing.Point(21, 41);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(101, 25);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.Location = new System.Drawing.Point(21, 83);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(96, 25);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.roleLabel.Location = new System.Drawing.Point(21, 125);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(50, 25);
            this.roleLabel.TabIndex = 5;
            this.roleLabel.Text = "Role";
            // 
            // createAccountButton
            // 
            this.createAccountButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.createAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountButton.Location = new System.Drawing.Point(220, 182);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(74, 33);
            this.createAccountButton.TabIndex = 3;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(311, 182);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(79, 33);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createAccountGroupBox
            // 
            this.createAccountGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.createAccountGroupBox.Controls.Add(this.usernameTextBox);
            this.createAccountGroupBox.Controls.Add(this.createAccountButton);
            this.createAccountGroupBox.Controls.Add(this.cancelButton);
            this.createAccountGroupBox.Controls.Add(this.passwordTextBox);
            this.createAccountGroupBox.Controls.Add(this.roleTextBox);
            this.createAccountGroupBox.Controls.Add(this.roleLabel);
            this.createAccountGroupBox.Controls.Add(this.usernameLabel);
            this.createAccountGroupBox.Controls.Add(this.passwordLabel);
            this.createAccountGroupBox.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.createAccountGroupBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.createAccountGroupBox.Location = new System.Drawing.Point(247, 204);
            this.createAccountGroupBox.Name = "createAccountGroupBox";
            this.createAccountGroupBox.Size = new System.Drawing.Size(406, 230);
            this.createAccountGroupBox.TabIndex = 8;
            this.createAccountGroupBox.TabStop = false;
            this.createAccountGroupBox.Text = "Create Account";
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.createAccountGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account Form";
            this.Load += new System.EventHandler(this.CreateAccountForm_Load);
            this.createAccountGroupBox.ResumeLayout(false);
            this.createAccountGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox roleTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox createAccountGroupBox;
    }
}