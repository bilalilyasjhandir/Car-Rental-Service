namespace CarRentalService
{
    partial class RentCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentCarForm));
            this.rentButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.rentalDateLabel = new System.Windows.Forms.Label();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.rentalDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.returnDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.carsComboBox = new System.Windows.Forms.ComboBox();
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.carsLabel = new System.Windows.Forms.Label();
            this.customersLabel = new System.Windows.Forms.Label();
            this.carPictureBox = new System.Windows.Forms.PictureBox();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rentButton
            // 
            this.rentButton.BackColor = System.Drawing.Color.Transparent;
            this.rentButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.rentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rentButton.Location = new System.Drawing.Point(197, 213);
            this.rentButton.Name = "rentButton";
            this.rentButton.Size = new System.Drawing.Size(78, 29);
            this.rentButton.TabIndex = 0;
            this.rentButton.Text = "Rent";
            this.rentButton.UseVisualStyleBackColor = false;
            this.rentButton.Click += new System.EventHandler(this.rentButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cancelButton.Location = new System.Drawing.Point(290, 213);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(76, 29);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // rentalDateLabel
            // 
            this.rentalDateLabel.AutoSize = true;
            this.rentalDateLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.rentalDateLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rentalDateLabel.Location = new System.Drawing.Point(15, 109);
            this.rentalDateLabel.Name = "rentalDateLabel";
            this.rentalDateLabel.Size = new System.Drawing.Size(113, 25);
            this.rentalDateLabel.TabIndex = 4;
            this.rentalDateLabel.Text = "Rental Date";
            // 
            // returnDateLabel
            // 
            this.returnDateLabel.AutoSize = true;
            this.returnDateLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.returnDateLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.returnDateLabel.Location = new System.Drawing.Point(16, 143);
            this.returnDateLabel.Name = "returnDateLabel";
            this.returnDateLabel.Size = new System.Drawing.Size(118, 25);
            this.returnDateLabel.TabIndex = 5;
            this.returnDateLabel.Text = "Return Date";
            // 
            // rentalDateDateTimePicker
            // 
            this.rentalDateDateTimePicker.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rentalDateDateTimePicker.CalendarMonthBackground = System.Drawing.Color.DodgerBlue;
            this.rentalDateDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.DodgerBlue;
            this.rentalDateDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.DodgerBlue;
            this.rentalDateDateTimePicker.Location = new System.Drawing.Point(140, 108);
            this.rentalDateDateTimePicker.Name = "rentalDateDateTimePicker";
            this.rentalDateDateTimePicker.Size = new System.Drawing.Size(275, 27);
            this.rentalDateDateTimePicker.TabIndex = 9;
            // 
            // returnDateDateTimePicker
            // 
            this.returnDateDateTimePicker.Location = new System.Drawing.Point(140, 142);
            this.returnDateDateTimePicker.Name = "returnDateDateTimePicker";
            this.returnDateDateTimePicker.Size = new System.Drawing.Size(275, 27);
            this.returnDateDateTimePicker.TabIndex = 10;
            // 
            // carsComboBox
            // 
            this.carsComboBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.carsComboBox.FormattingEnabled = true;
            this.carsComboBox.Location = new System.Drawing.Point(140, 33);
            this.carsComboBox.Name = "carsComboBox";
            this.carsComboBox.Size = new System.Drawing.Size(275, 28);
            this.carsComboBox.TabIndex = 12;
            this.carsComboBox.SelectedIndexChanged += new System.EventHandler(this.carsComboBox_SelectedIndexChanged);
            // 
            // customersComboBox
            // 
            this.customersComboBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(140, 72);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(275, 28);
            this.customersComboBox.TabIndex = 13;
            // 
            // carsLabel
            // 
            this.carsLabel.AutoSize = true;
            this.carsLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.carsLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.carsLabel.Location = new System.Drawing.Point(16, 32);
            this.carsLabel.Name = "carsLabel";
            this.carsLabel.Size = new System.Drawing.Size(50, 25);
            this.carsLabel.TabIndex = 15;
            this.carsLabel.Text = "Cars";
            // 
            // customersLabel
            // 
            this.customersLabel.AutoSize = true;
            this.customersLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.customersLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.customersLabel.Location = new System.Drawing.Point(16, 71);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Size = new System.Drawing.Size(106, 25);
            this.customersLabel.TabIndex = 16;
            this.customersLabel.Text = "Customers";
            // 
            // carPictureBox
            // 
            this.carPictureBox.Location = new System.Drawing.Point(432, 32);
            this.carPictureBox.Name = "carPictureBox";
            this.carPictureBox.Size = new System.Drawing.Size(145, 102);
            this.carPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carPictureBox.TabIndex = 17;
            this.carPictureBox.TabStop = false;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.totalAmountLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.totalAmountLabel.Location = new System.Drawing.Point(228, 174);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(133, 25);
            this.totalAmountLabel.TabIndex = 6;
            this.totalAmountLabel.Text = "Total Amount";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.carsComboBox);
            this.groupBox1.Controls.Add(this.rentButton);
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.carPictureBox);
            this.groupBox1.Controls.Add(this.carsLabel);
            this.groupBox1.Controls.Add(this.totalAmountLabel);
            this.groupBox1.Controls.Add(this.returnDateDateTimePicker);
            this.groupBox1.Controls.Add(this.returnDateLabel);
            this.groupBox1.Controls.Add(this.customersLabel);
            this.groupBox1.Controls.Add(this.rentalDateLabel);
            this.groupBox1.Controls.Add(this.rentalDateDateTimePicker);
            this.groupBox1.Controls.Add(this.customersComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(160, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 262);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(16, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "The rent of this car is: ";
            // 
            // RentCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RentCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Car Form";
            this.Load += new System.EventHandler(this.RentCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rentButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label rentalDateLabel;
        private System.Windows.Forms.Label returnDateLabel;
        private System.Windows.Forms.Label carsLabel;
        private System.Windows.Forms.Label customersLabel;
        private System.Windows.Forms.PictureBox carPictureBox;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker rentalDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker returnDateDateTimePicker;
        private System.Windows.Forms.ComboBox carsComboBox;
        private System.Windows.Forms.ComboBox customersComboBox;
    }
}