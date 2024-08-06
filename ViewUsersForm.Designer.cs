namespace CarRentalService
{
    partial class ViewUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUsersForm));
            this.viewUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewUsersDataGridView
            // 
            this.viewUsersDataGridView.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.viewUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewUsersDataGridView.GridColor = System.Drawing.Color.DodgerBlue;
            this.viewUsersDataGridView.Location = new System.Drawing.Point(47, 208);
            this.viewUsersDataGridView.Name = "viewUsersDataGridView";
            this.viewUsersDataGridView.Size = new System.Drawing.Size(790, 245);
            this.viewUsersDataGridView.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.refreshButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.refreshButton.Location = new System.Drawing.Point(746, 164);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(91, 28);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // ViewUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.viewUsersDataGridView);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Users Form";
            this.Load += new System.EventHandler(this.ViewUsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewUsersDataGridView;
        private System.Windows.Forms.Button refreshButton;
    }
}