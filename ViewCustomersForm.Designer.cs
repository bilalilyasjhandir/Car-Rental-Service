namespace CarRentalService
{
    partial class ViewCustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCustomersForm));
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.GridColor = System.Drawing.Color.DodgerBlue;
            this.customersDataGridView.Location = new System.Drawing.Point(47, 208);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.Size = new System.Drawing.Size(790, 245);
            this.customersDataGridView.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.refreshButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.refreshButton.Location = new System.Drawing.Point(746, 170);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(91, 32);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // ViewCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.customersDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewCustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Customers Form";
            this.Load += new System.EventHandler(this.ViewCustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.Button refreshButton;
    }
}