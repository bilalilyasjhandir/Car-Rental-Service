namespace CarRentalService
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.carsToolStripMenuItem,
            this.rentalsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(20, 140, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(185, 481);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(144, 41);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // carsToolStripMenuItem
            // 
            this.carsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCarToolStripMenuItem,
            this.viewCarsToolStripMenuItem});
            this.carsToolStripMenuItem.Name = "carsToolStripMenuItem";
            this.carsToolStripMenuItem.Size = new System.Drawing.Size(144, 41);
            this.carsToolStripMenuItem.Text = "Cars";
            // 
            // addCarToolStripMenuItem
            // 
            this.addCarToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.addCarToolStripMenuItem.Text = "Add Car";
            this.addCarToolStripMenuItem.Click += new System.EventHandler(this.addCarToolStripMenuItem_Click);
            // 
            // viewCarsToolStripMenuItem
            // 
            this.viewCarsToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCarsToolStripMenuItem.Name = "viewCarsToolStripMenuItem";
            this.viewCarsToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.viewCarsToolStripMenuItem.Text = "View Cars";
            this.viewCarsToolStripMenuItem.Click += new System.EventHandler(this.viewCarsToolStripMenuItem_Click);
            // 
            // rentalsToolStripMenuItem
            // 
            this.rentalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentCarToolStripMenuItem,
            this.viewRentalsToolStripMenuItem});
            this.rentalsToolStripMenuItem.Name = "rentalsToolStripMenuItem";
            this.rentalsToolStripMenuItem.Size = new System.Drawing.Size(144, 41);
            this.rentalsToolStripMenuItem.Text = "Rentals";
            // 
            // rentCarToolStripMenuItem
            // 
            this.rentCarToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentCarToolStripMenuItem.Name = "rentCarToolStripMenuItem";
            this.rentCarToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.rentCarToolStripMenuItem.Text = "Rent Car";
            this.rentCarToolStripMenuItem.Click += new System.EventHandler(this.rentCarToolStripMenuItem_Click);
            // 
            // viewRentalsToolStripMenuItem
            // 
            this.viewRentalsToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRentalsToolStripMenuItem.Name = "viewRentalsToolStripMenuItem";
            this.viewRentalsToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.viewRentalsToolStripMenuItem.Text = "View Rentals";
            this.viewRentalsToolStripMenuItem.Click += new System.EventHandler(this.viewRentalsToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomersToolStripMenuItem,
            this.viewCustomersToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(144, 41);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // addCustomersToolStripMenuItem
            // 
            this.addCustomersToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomersToolStripMenuItem.Name = "addCustomersToolStripMenuItem";
            this.addCustomersToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.addCustomersToolStripMenuItem.Text = "Add Customers";
            this.addCustomersToolStripMenuItem.Click += new System.EventHandler(this.addCustomersToolStripMenuItem_Click);
            // 
            // viewCustomersToolStripMenuItem
            // 
            this.viewCustomersToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCustomersToolStripMenuItem.Name = "viewCustomersToolStripMenuItem";
            this.viewCustomersToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.viewCustomersToolStripMenuItem.Text = "View Customers";
            this.viewCustomersToolStripMenuItem.Click += new System.EventHandler(this.viewCustomersToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewUsersToolStripMenuItem});
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(144, 41);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // viewUsersToolStripMenuItem
            // 
            this.viewUsersToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUsersToolStripMenuItem.Name = "viewUsersToolStripMenuItem";
            this.viewUsersToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
            this.viewUsersToolStripMenuItem.Text = "View Users";
            this.viewUsersToolStripMenuItem.Click += new System.EventHandler(this.viewUsersToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUsersToolStripMenuItem;
    }
}

