namespace CarRentalService
{
    partial class AddCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCarForm));
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.makeLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.rentalPriceLabel = new System.Windows.Forms.Label();
            this.rentalPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.isAvailableCheckBox = new System.Windows.Forms.CheckBox();
            this.carPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.carDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.operationsGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.rentalPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).BeginInit();
            this.carDetailsGroupBox.SuspendLayout();
            this.operationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // makeTextBox
            // 
            this.makeTextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.makeTextBox.Location = new System.Drawing.Point(102, 32);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(228, 27);
            this.makeTextBox.TabIndex = 0;
            this.makeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.makeTextBox_KeyDown);
            // 
            // modelTextBox
            // 
            this.modelTextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.modelTextBox.Location = new System.Drawing.Point(102, 73);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(228, 27);
            this.modelTextBox.TabIndex = 1;
            this.modelTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modelTextBox_KeyDown);
            // 
            // yearTextBox
            // 
            this.yearTextBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.yearTextBox.Location = new System.Drawing.Point(102, 113);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(228, 27);
            this.yearTextBox.TabIndex = 2;
            this.yearTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.yearTextBox_KeyDown);
            // 
            // saveButton
            // 
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Nirmala UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(62, 157);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 37);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Nirmala UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.cancelButton.Location = new System.Drawing.Point(62, 200);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 37);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.makeLabel.Location = new System.Drawing.Point(24, 31);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(61, 25);
            this.makeLabel.TabIndex = 6;
            this.makeLabel.Text = "Make";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.modelLabel.Location = new System.Drawing.Point(24, 72);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(69, 25);
            this.modelLabel.TabIndex = 7;
            this.modelLabel.Text = "Model";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.yearLabel.Location = new System.Drawing.Point(24, 112);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(50, 25);
            this.yearLabel.TabIndex = 8;
            this.yearLabel.Text = "Year";
            this.yearLabel.Click += new System.EventHandler(this.yearLabel_Click);
            // 
            // rentalPriceLabel
            // 
            this.rentalPriceLabel.AutoSize = true;
            this.rentalPriceLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.rentalPriceLabel.Location = new System.Drawing.Point(24, 157);
            this.rentalPriceLabel.Name = "rentalPriceLabel";
            this.rentalPriceLabel.Size = new System.Drawing.Size(155, 25);
            this.rentalPriceLabel.TabIndex = 9;
            this.rentalPriceLabel.Text = "Rental Price In $";
            // 
            // rentalPriceNumericUpDown
            // 
            this.rentalPriceNumericUpDown.BackColor = System.Drawing.Color.DodgerBlue;
            this.rentalPriceNumericUpDown.DecimalPlaces = 2;
            this.rentalPriceNumericUpDown.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.rentalPriceNumericUpDown.ForeColor = System.Drawing.SystemColors.Info;
            this.rentalPriceNumericUpDown.Location = new System.Drawing.Point(185, 155);
            this.rentalPriceNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rentalPriceNumericUpDown.Name = "rentalPriceNumericUpDown";
            this.rentalPriceNumericUpDown.Size = new System.Drawing.Size(145, 33);
            this.rentalPriceNumericUpDown.TabIndex = 4;
            this.rentalPriceNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rentalPriceNumericUpDown_KeyDown);
            // 
            // isAvailableCheckBox
            // 
            this.isAvailableCheckBox.AutoSize = true;
            this.isAvailableCheckBox.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.isAvailableCheckBox.Location = new System.Drawing.Point(102, 202);
            this.isAvailableCheckBox.Name = "isAvailableCheckBox";
            this.isAvailableCheckBox.Size = new System.Drawing.Size(130, 29);
            this.isAvailableCheckBox.TabIndex = 6;
            this.isAvailableCheckBox.Text = "Is Available";
            this.isAvailableCheckBox.UseVisualStyleBackColor = true;
            this.isAvailableCheckBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.isAvailableCheckBox_KeyDown);
            // 
            // carPictureBox
            // 
            this.carPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carPictureBox.Location = new System.Drawing.Point(353, 65);
            this.carPictureBox.Name = "carPictureBox";
            this.carPictureBox.Size = new System.Drawing.Size(208, 166);
            this.carPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carPictureBox.TabIndex = 13;
            this.carPictureBox.TabStop = false;
            // 
            // pictureLabel
            // 
            this.pictureLabel.AutoSize = true;
            this.pictureLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.pictureLabel.Location = new System.Drawing.Point(348, 26);
            this.pictureLabel.Name = "pictureLabel";
            this.pictureLabel.Size = new System.Drawing.Size(75, 25);
            this.pictureLabel.TabIndex = 14;
            this.pictureLabel.Text = "Picture";
            // 
            // browseButton
            // 
            this.browseButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Location = new System.Drawing.Point(486, 26);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 28);
            this.browseButton.TabIndex = 5;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Nirmala UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.loadButton.Location = new System.Drawing.Point(62, 27);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(96, 37);
            this.loadButton.TabIndex = 16;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Nirmala UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.updateButton.Location = new System.Drawing.Point(62, 70);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(96, 37);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Nirmala UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.deleteButton.Location = new System.Drawing.Point(62, 113);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 37);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // carDetailsGroupBox
            // 
            this.carDetailsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.carDetailsGroupBox.Controls.Add(this.makeTextBox);
            this.carDetailsGroupBox.Controls.Add(this.makeLabel);
            this.carDetailsGroupBox.Controls.Add(this.modelTextBox);
            this.carDetailsGroupBox.Controls.Add(this.yearTextBox);
            this.carDetailsGroupBox.Controls.Add(this.isAvailableCheckBox);
            this.carDetailsGroupBox.Controls.Add(this.pictureLabel);
            this.carDetailsGroupBox.Controls.Add(this.browseButton);
            this.carDetailsGroupBox.Controls.Add(this.modelLabel);
            this.carDetailsGroupBox.Controls.Add(this.yearLabel);
            this.carDetailsGroupBox.Controls.Add(this.carPictureBox);
            this.carDetailsGroupBox.Controls.Add(this.rentalPriceNumericUpDown);
            this.carDetailsGroupBox.Controls.Add(this.rentalPriceLabel);
            this.carDetailsGroupBox.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.carDetailsGroupBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.carDetailsGroupBox.Location = new System.Drawing.Point(34, 199);
            this.carDetailsGroupBox.Name = "carDetailsGroupBox";
            this.carDetailsGroupBox.Size = new System.Drawing.Size(582, 253);
            this.carDetailsGroupBox.TabIndex = 19;
            this.carDetailsGroupBox.TabStop = false;
            this.carDetailsGroupBox.Text = "Car Details";
            // 
            // operationsGroupBox
            // 
            this.operationsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.operationsGroupBox.Controls.Add(this.loadButton);
            this.operationsGroupBox.Controls.Add(this.updateButton);
            this.operationsGroupBox.Controls.Add(this.cancelButton);
            this.operationsGroupBox.Controls.Add(this.deleteButton);
            this.operationsGroupBox.Controls.Add(this.saveButton);
            this.operationsGroupBox.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.operationsGroupBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.operationsGroupBox.Location = new System.Drawing.Point(636, 199);
            this.operationsGroupBox.Name = "operationsGroupBox";
            this.operationsGroupBox.Size = new System.Drawing.Size(218, 253);
            this.operationsGroupBox.TabIndex = 20;
            this.operationsGroupBox.TabStop = false;
            this.operationsGroupBox.Text = "Operations";
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.operationsGroupBox);
            this.Controls.Add(this.carDetailsGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Car Form";
            ((System.ComponentModel.ISupportInitialize)(this.rentalPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).EndInit();
            this.carDetailsGroupBox.ResumeLayout(false);
            this.carDetailsGroupBox.PerformLayout();
            this.operationsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label rentalPriceLabel;
        private System.Windows.Forms.NumericUpDown rentalPriceNumericUpDown;
        private System.Windows.Forms.CheckBox isAvailableCheckBox;
        private System.Windows.Forms.PictureBox carPictureBox;
        private System.Windows.Forms.Label pictureLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox carDetailsGroupBox;
        private System.Windows.Forms.GroupBox operationsGroupBox;
    }
}